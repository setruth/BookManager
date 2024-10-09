using AntdUI;
using BookManager.Model;
using BookManager.Page.Frame.ChildPage.ReaderType.Component;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using BookManager.DB.Repository;
using BookManager.Page.Frame.ChildPage.ReaderType.Model;
using BookManager.Util;

namespace BookManager.Page.Frame.ChildPage.ReaderType
{
    public partial class ReaderType : UserControl
    {
        private readonly ReaderTypeRepository _readerTypeRep = ReaderTypeRepository.GetRep();
        private ReaderInfoRepository _readerInfoRep = ReaderInfoRepository.GetRep();
        private readonly Form _context;
        private List<ReaderTypeItem> sourceItemList = new List<ReaderTypeItem>();
        private List<ReaderTypeItem> renderItemList = new List<ReaderTypeItem>();

        public ReaderType(Form parentForm)
        {
            _context = parentForm;
            InitializeComponent();
            InitTable();
            RefreshList();
        }

        private void InitTable()
        {
            var userTableColumnConfig = new ColumnCollection
            {
                new Column("order", "序号", ColumnAlign.Center) { Fixed = false },
                new Column("typeId", "类型编号", ColumnAlign.Center) { Fixed = false },
                new Column("typeName", "类型名称", ColumnAlign.Center) { Fixed = false },
                new Column("borrowNumber", "可借数量/本", ColumnAlign.Center) { Fixed = false },
                new Column("borrowDay", "可借天数/天", ColumnAlign.Center) { Fixed = false },
                new Column("operationBtns", "信息操作", ColumnAlign.Center) { Fixed = true },
            };
            userTypeTable.Columns = userTableColumnConfig;
            userTypeTable.CellButtonClick += ItemOperationClick;
        }

       

        private void ItemOperationClick(object sender, TableButtonEventArgs e)
        {
            if (e.Btn.Id == AppConstant.UpdateBtnTag)
            {
                ItemUpdate(e.Record as ReaderTypeItem ?? throw new InvalidOperationException("拿不到操作的信息"));
            }
            else
            {
                ItemDelete(e.Record as ReaderTypeItem ?? throw new InvalidOperationException("拿不到操作的信息"));
            }
        }

        private void ItemUpdate(ReaderTypeItem readerTypeItem)
        {
            var updateDialog = new ReaderTypeUpsertDialog((itemInfo) =>
                {
                    _readerTypeRep.UpdateReaderType(itemInfo);
                    Console.WriteLine("更新成功");
                    RefreshList();
                },
                new ReaderTypeInfo(
                    readerTypeItem.typeId,
                    readerTypeItem.typeName,
                    readerTypeItem.borrowDay,
                    readerTypeItem.borrowNumber
                )
            );

            updateDialog.ShowDialog(_context);
        }

        private void ItemDelete(ReaderTypeItem readerTypeItem)
        {
            var (msg,hasBinding) = _readerInfoRep.hasBindingType(readerTypeItem.typeId);
            if (hasBinding)
            {
                _context.WarnNotification("删除失败", msg);
                return;
            }
            new AntdUI.Modal.Config(_context, "读者类型删除提示",
                $"你确定要删除读者类型【{readerTypeItem.typeName}】吗",
                AntdUI.TType.Warn)
            {
                Font = new Font("微软雅黑", 12),
                OnOk = config =>
                {
                    _readerTypeRep.DeleteReaderType(readerTypeItem.typeId);
                    RefreshList();
                    return true;
                }
            }.open();
        }

        private void search_input_change(object sender, EventArgs e)
        {
            renderItemList = sourceItemList.Where(item => item.typeName.Contains(search.Text)).ToList();
            userTypeTable.DataSource = renderItemList;
        }

        private void add_btn_click(object sender, EventArgs e)
        {
            var updateDialog = new ReaderTypeUpsertDialog((itemInfo) =>
            {
                _readerTypeRep.AddReaderType(itemInfo.TypeName, itemInfo.BorrowDay, itemInfo.BorrowNumber);
                RefreshList();
            });

            updateDialog.ShowDialog(_context);
        }

        private void RefreshList()
        {
            sourceItemList = _readerTypeRep.GetReaderTypeList().Data.Select((entity, index) =>
                new ReaderTypeItem(
                    index + 1,
                    entity.TypeId,
                    entity.TypeName,
                    entity.BorrowNumber,
                    entity.BorrowDay
                )).ToList();
            renderItemList = sourceItemList;
            userTypeTable.DataSource = renderItemList;
            search.Text = "";
        }
        
    }
}