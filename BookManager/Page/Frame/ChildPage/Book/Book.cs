using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using BookManager.DB.Entity;
using BookManager.DB.Repository;
using BookManager.Model;
using BookManager.Page.Frame.ChildPage.Book.Component;
using BookManager.Page.Frame.ChildPage.Book.Model;
using BookManager.Page.Frame.ChildPage.Reader.Model;
using BookManager.Util;

namespace BookManager.Page.Frame.ChildPage.Book
{
    public partial class Book : UserControl
    {
        private Form _context;
        private BookInfoRepository _bookInfoRep = BookInfoRepository.GetRep();
        private BorrowInfoRepository _borrowInfoRep = BorrowInfoRepository.GetRep();
        
        private List<BookInfoItem> sourceItemList = new List<BookInfoItem>();
        private List<BookInfoItem> renderItemList = new List<BookInfoItem>();
        private List<BookInfoItem> selectItemList = new List<BookInfoItem>();

        public Book(Form parentForm)
        {
            _context = parentForm;
            InitializeComponent();
            InitTable();
            RefreshList();
        }

        private void InitTable()
        {
            var tableColumnConfig = new ColumnCollection
            {
                new ColumnCheck(nameof(BookInfoItem.Check)) { Fixed = false },
                new Column(nameof(BookInfoItem.BookId), "书籍编号", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BookInfoItem.Name), "书籍名称", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BookInfoItem.Author), "作者", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BookInfoItem.Press), "出版社", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BookInfoItem.Price), "价格/RMB￥", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BookInfoItem.Status), "是否已经借出", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BookInfoItem.OperationBtns), "操作", ColumnAlign.Center) { Fixed = true },
            };
            table.Columns = tableColumnConfig;
            table.CellButtonClick += ItemOperationClick;
            table.CheckedChanged += TypeItemCheck;
        }
        private void search_change(object sender, EventArgs e)
        {
            selectItemList.Clear();
            foreach (var bookInfoItem in sourceItemList)
            {
                bookInfoItem.Check = false;
            }
            selectLabel.Text = $@"已选中{selectItemList.Count}项";
            renderItemList = sourceItemList.Where(item => item.Name.Contains(search.Text)).ToList();
            table.DataSource = renderItemList;
        }
        private void TypeItemCheck(object sender, TableCheckEventArgs e)
        {
            var selectItem = e.Record as BookInfoItem;
            if (e.Value) selectItemList.Add(selectItem);
            else selectItemList.Remove(selectItem);
            selectLabel.Text = $@"已选中{selectItemList.Count}项";
        }

        private void ItemOperationClick(object sender, TableButtonEventArgs e)
        {
            if (e.Btn.Id == AppConstant.UpdateBtnTag)
            {
                ItemUpdate(e.Record as BookInfoItem ?? throw new InvalidOperationException("拿不到操作的信息"));
            }
            else
            {
                ItemDelete(e.Record as BookInfoItem ?? throw new InvalidOperationException("拿不到操作的信息"));
            }
        }

        private void ItemDelete(BookInfoItem record)
        {
            if (record.StatusSource == 0)
            {
                _context.WarnNotification("删除提示", $"书籍{record.Name}已经借出，不能删除");
                return;
            }

            new AntdUI.Modal.Config(_context, "书籍删除提示",
                $"你确定要删除书籍{record.Name}吗，删除图书会同时删除相关的借阅记录",
                AntdUI.TType.Warn)
            {
                Font = new Font("微软雅黑", 12),
                OnOk = config =>
                {
                    _context.Invoke(new Action(() =>
                    {
                        BroadcastCenter.Publish(new FrameLoadingLaunchBcast("正在删除"));
                    }));
                    _borrowInfoRep.DeleteBorrowInfoByBook(record.BookId);
                    var (msg, res) = _bookInfoRep.DeleteBookInfo(record.BookId);
                    if (res)
                    {
                        RefreshList();
                        _context.SuccessNotification("删除结果", msg);
                    }
                    else
                    {
                        _context.ErrNotification("删除结果", msg);
                    }
                    _context.Invoke(new Action(() =>
                    {
                        BroadcastCenter.Publish(new FrameLoadingStopBcast());
                    }));
                    return true;
                }
            }.open();
        }

        private void ItemUpdate(BookInfoItem record)
        {
            new BookUpsertDialog(_context, item =>
                {
                    BroadcastCenter.Publish(new FrameLoadingLaunchBcast("正在修改"));
                    var (msg, res) = _bookInfoRep.UpdateBookInfo(item);
                    if (res)
                    {
                        RefreshList();
                        _context.SuccessNotification("书本信息更新成功", msg);
                    }
                    else
                    {
                        _context.ErrNotification("书本信息更新失败", msg);
                    }

                    BroadcastCenter.Publish(new FrameLoadingStopBcast());
                },
                new BookInfo(
                    record.BookId,
                    record.NameSource,
                    record.Author,
                    record.Press,
                    record.Price,
                    record.StatusSource
                )
            ).ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            new BookUpsertDialog(_context, (bookInfo) =>
            {
                BroadcastCenter.Publish(new FrameLoadingLaunchBcast("正在新增"));
                bookInfo.BookId = IdGenerator.GenerateId();
                var (msg, res) = _bookInfoRep.AddBookInfo(bookInfo);
                if (res)
                {
                    RefreshList();
                    _context.SuccessNotification($"添加书籍《{bookInfo.Name}》信息成功成功", msg);
                }
                else
                {
                    _context.ErrNotification($"添加书籍《{bookInfo.Name}》信息失败", msg);
                }

                BroadcastCenter.Publish(new FrameLoadingStopBcast());
            }).ShowDialog();
        }

        private void multiply_del(object sender, EventArgs e)
        {
            if (selectItemList.Count == 0)
            {
                _context.WarnNotification("批量删除无效", "没有勾选需要删除的项");
                return;
            }
            new AntdUI.Modal.Config(_context, "批量删除提示",
                $"你确定要删除所选的{selectItemList.Count}项吗？已借出的书籍无法删除，删除图书会同时删除相关的借阅记录",
                AntdUI.TType.Warn)
            {
                Font = new Font("微软雅黑", 12),
                OnOk = config =>
                {
                    _context.Invoke(new Action(() =>
                    {
                        BroadcastCenter.Publish(new FrameLoadingLaunchBcast($"正在批量删除"));
                    }));
                    var delFailList = new List<BookInfoItem>();
                    var delCount = selectItemList.Count;
                    foreach (var delItem in selectItemList)
                    {
                        if (delItem.StatusSource==0)
                        {
                            delFailList.Add(delItem);
                            continue;
                        }
                        _borrowInfoRep.DeleteBorrowInfoByBook(delItem.BookId);
                        var (_, res) = _bookInfoRep.DeleteBookInfo(delItem.BookId);
                        if (!res)
                        {
                            delFailList.Add(delItem);
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
        private void RefreshList()
        {
            selectItemList.Clear();
            sourceItemList = _bookInfoRep.GetBookInfoList().Data.Select(item => new BookInfoItem(item)).ToList();
            renderItemList = sourceItemList;
            table.DataSource = renderItemList;
            search.Text = "";
            selectLabel.Text = $@"已选中{selectItemList.Count}项";
        }
    }
}