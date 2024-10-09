using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AntdUI;
using BookManager.DB.Entity;
using BookManager.DB.Repository;
using BookManager.Model;
using BookManager.Page.Frame.ChildPage.Reader.Component;
using BookManager.Page.Frame.ChildPage.Reader.Model;
using BookManager.Page.Frame.ChildPage.ReaderType.Model;
using BookManager.Page.Welcome.Component;
using BookManager.Util;

namespace BookManager.Page.Frame.ChildPage.Reader
{
    public partial class Reader : UserControl
    {
        private ReaderInfoRepository _readerInfoRep = ReaderInfoRepository.GetRep();
        private ReaderTypeRepository _readerTypeRep = ReaderTypeRepository.GetRep();
        private BorrowInfoRepository _borrowInfoRep = BorrowInfoRepository.GetRep();
        private readonly Form _context;
        private List<ReaderInfoItem> sourceItemList = new List<ReaderInfoItem>();
        private List<ReaderInfoItem> renderItemList = new List<ReaderInfoItem>();
        private List<ReaderInfoItem> selectItemList = new List<ReaderInfoItem>();
        private readonly List<ReaderTypeEntity> readerTypeList;

        private int? filterTypeId;

        public Reader(Form parentForm)
        {
            _context = parentForm;
            InitializeComponent();
            readerTypeList = _readerTypeRep.GetReaderTypeList().Data;
            if (readerTypeList.Count == 0)
            {
                _context.WarnNotification("读者管理页面停止渲染", "读者类型为空，请先新增读者类型");
                addBtn.Enabled = false;
                return;
            }

            typeFilter.Items.AddRange(readerTypeList.Select(item => new SelectItem(item.TypeId)
            {
                Text = item.TypeName,
            }).ToArray<object>());
            InitTable();
            RefreshList();
        }

        private void InitTable()
        {
            var tableColumnConfig = new ColumnCollection
            {
                new ColumnCheck(nameof(ReaderInfoItem.Check)) { Fixed = false },
                new Column(nameof(ReaderInfoItem.ReaderId), "读者编号", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(ReaderInfoItem.Name), "读者名称", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(ReaderInfoItem.TypeName), "读者类型", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(ReaderInfoItem.Department), "部门", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(ReaderInfoItem.QQ), "QQ号", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(ReaderInfoItem.AlreadyBorrow), "已借书籍", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(ReaderInfoItem.BorrowNumber), "可借数量/本", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(ReaderInfoItem.BorrowDay), "可借天数/天", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(ReaderInfoItem.OperationBtns), "操作", ColumnAlign.Center) { Fixed = true },
            };
            table.Columns = tableColumnConfig;
            table.CellButtonClick += ItemOperationClick;
            table.CheckedChanged += TypeItemCheck;
        }

        private void TypeItemCheck(object sender, TableCheckEventArgs e)
        {
            var selectItem = e.Record as ReaderInfoItem;
            if (e.Value) selectItemList.Add(selectItem);
            else selectItemList.Remove(selectItem);
            selectLabel.Text = $@"已选中{selectItemList.Count}项";
        }

        private void RefreshList()
        {
            sourceItemList = _readerInfoRep.GetReaderInfoList().Data.Select(infoEntity =>
            {
                var readerTypeEntity = readerTypeList.Find(typeEntity => typeEntity.TypeId == infoEntity.TypeId);
                return readerTypeEntity == null ? null : new ReaderInfoItem(infoEntity, readerTypeEntity);
            }).Where(item => item != null).ToList()!;
            renderItemList = sourceItemList;
            table.DataSource = renderItemList;
            selectItemList.Clear();
            selectLabel.Text = @"已选中0项";
            search.Text = "";
            filterTypeId = null;
            typeFilter.SelectedValue = null;
        }

        private void ItemOperationClick(object sender, TableButtonEventArgs e)
        {
            if (e.Btn.Id == AppConstant.UpdateBtnTag)
            {
                ItemUpdate(e.Record as ReaderInfoItem ?? throw new InvalidOperationException("拿不到操作的信息"));
            }
            else
            {
                ItemDelete(e.Record as ReaderInfoItem ?? throw new InvalidOperationException("拿不到操作的信息"));
            }
        }

        private void ItemUpdate(ReaderInfoItem record)
        {
            new ReaderInfoUpsertDialog(_context, readerTypeList, item =>
                {
                    BroadcastCenter.Publish(new FrameLoadingLaunchBcast("正在修改"));
                    var (msg, res) = _readerInfoRep.UpdateReaderInfo(item);
                    if (res)
                    {
                        RefreshList();
                        _context.SuccessNotification("读者信息更新成功", msg);
                    }
                    else
                    {
                        _context.ErrNotification("读者信息更新失败", msg);
                    }

                    BroadcastCenter.Publish(new FrameLoadingStopBcast());
                },
                new ReaderInfo(
                    record.ReaderId,
                    record.TypeId,
                    record.Name,
                    record.Department,
                    record.QQ,
                    record.AlreadyBorrow
                )
            ).ShowDialog();
        }

        private void ItemDelete(ReaderInfoItem record)
        {
            var (msg, res) = _borrowInfoRep.ReaderHasBorrow(record.ReaderId);
            if (res)
            {
                _context.ErrNotification("无法删除读者", msg);
                return;
            }

            new AntdUI.Modal.Config(_context, "读者信息删除提示",
                $"你确定要删除读者【{record.Name}】吗",
                AntdUI.TType.Warn)
            {
                Font = new Font("微软雅黑", 12),
                OnOk = config =>
                {
                    _context.Invoke(new Action(() =>
                    {
                        BroadcastCenter.Publish(new FrameLoadingLaunchBcast($"正在删除{record.Name}信息"));
                    }));
                    var (msg, res) = _readerInfoRep.DeleteReaderInfo(record.ReaderId);
                    if (!res)
                    {
                        _context.Invoke(new Action(() => { BroadcastCenter.Publish(new FrameLoadingStopBcast()); }));
                        _context.ErrNotification($"删除读者{record.Name}信息失败", msg);
                        return true;
                    }

                    RefreshList();
                    _context.Invoke(new Action(() => { BroadcastCenter.Publish(new FrameLoadingStopBcast()); }));
                    return true;
                },
            }.open();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            new ReaderInfoUpsertDialog(_context, readerTypeList, item =>
            {
                BroadcastCenter.Publish(new FrameLoadingLaunchBcast("正在新增"));
                var (repeatMsg, repeatRes) = _readerInfoRep.HasRepeatReaderInfo(item.Name, item.Department, item.QQ);
                if (repeatRes)
                {
                    _context.ErrNotification($"添加读者{item.Name}信息失败", repeatMsg);
                    BroadcastCenter.Publish(new FrameLoadingStopBcast());
                    return;
                }

                item.ReaderId = IdGenerator.GenerateId();
                var (addMsg, addRes) = _readerInfoRep.AddReaderInfo(item);
                if (addRes)
                {
                    RefreshList();
                    _context.SuccessNotification($"添加读者{item.Name}信息成功成功", addMsg);
                }
                else
                {
                    _context.ErrNotification($"添加读者{item.Name}信息失败", addMsg);
                }

                BroadcastCenter.Publish(new FrameLoadingStopBcast());
            }).ShowDialog();
        }

        private void type_filter_change(object sender, ObjectNEventArgs e)
        {
            if (e.Value == null)
            {
                filterTypeId = null;
            }
            else
            {
                filterTypeId = Convert.ToInt32(e.Value);
            }

            filterSourceList();
        }

        private void search_change(object sender, EventArgs e)
        {
            filterSourceList();
        }

        private void multiple_del(object sender, EventArgs e)
        {
            if (selectItemList.Count == 0)
            {
                _context.WarnNotification("批量删除无效", "没有勾选需要删除的项");
                return;
            }

            new AntdUI.Modal.Config(_context, "批量删除提示",
                $"你确定要删除所选的{selectItemList.Count}项吗？",
                AntdUI.TType.Warn)
            {
                Font = new Font("微软雅黑", 12),
                OnOk = config =>
                {
                    _context.Invoke(new Action(() =>
                    {
                        BroadcastCenter.Publish(new FrameLoadingLaunchBcast($"正在批量删除"));
                    }));
                    var delFailList = new List<ReaderInfoItem>();
                    var delCount = selectItemList.Count;
                    foreach (var readerInfoItem in selectItemList)
                    {
                        var (_, hasBorrow) = _borrowInfoRep.ReaderHasBorrow(readerInfoItem.ReaderId);
                        if (hasBorrow)
                        {
                            delFailList.Add(readerInfoItem);
                            continue;
                        }

                        var (_, res) = _readerInfoRep.DeleteReaderInfo(readerInfoItem.ReaderId);
                        if (!res)
                        {
                            delFailList.Add(readerInfoItem);
                        }
                    }

                    RefreshList();
                    if (delFailList.Count == 0)
                    {
                        _context.SuccessNotification($"批量删除结束", $"删除总数 {delCount}项");
                    }
                    else
                    {
                        _context.WarnNotification($"批量删除结束", $"删除总数 {delCount}项 ,失败 {delFailList.Count}项");
                    }

                    _context.Invoke(new Action(() => { BroadcastCenter.Publish(new FrameLoadingStopBcast()); }));
                    return true;
                },
            }.open();
        }

        private void filterSourceList()
        {
            foreach (var readerInfoItem in sourceItemList)
            {
                readerInfoItem.Check = false;
            }

            selectItemList.Clear();
            selectLabel.Text = @"已选中0项";
            var newRenderList = sourceItemList;
            if (filterTypeId != null)
            {
                newRenderList = newRenderList.Where(item => item.TypeId == filterTypeId).ToList();
            }

            renderItemList = newRenderList.Where(item => item.Name.Contains(search.Text)).ToList();
            table.DataSource = renderItemList;
        }
    }
}