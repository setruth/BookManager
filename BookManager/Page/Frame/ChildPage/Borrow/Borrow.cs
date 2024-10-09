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
using BookManager.Component;
using BookManager.DB.Entity;
using BookManager.DB.Repository;
using BookManager.Model;
using BookManager.Page.Frame.ChildPage.Borrow.Component;
using BookManager.Page.Frame.ChildPage.Borrow.Model;
using BookManager.Util;

namespace BookManager.Page.Frame.ChildPage.Borrow
{
    public partial class Borrow : UserControl
    {
        private BorrowInfoRepository _borrowInfoRep = BorrowInfoRepository.GetRep();
        private static readonly ReaderInfoRepository _readerInfoRep = ReaderInfoRepository.GetRep();
        private  BookInfoRepository _bookInfoRep = BookInfoRepository.GetRep();
        private List<ReaderInfoEntity> _readerList = _readerInfoRep.GetReaderInfoList().Data;
        private List<BookInfoEntity> _bookList = new List<BookInfoEntity>();

        private List<BorrowInfoItem> sourceItemList = new List<BorrowInfoItem>();
        private List<BorrowInfoItem> renderItemList = new List<BorrowInfoItem>();
        private readonly Form _context;

        public Borrow(Form parentForm)
        {
            _context = parentForm;
            InitializeComponent();
            InitTable();
            RefreshList();
            filter.Items.AddRange((new[]
            {
                new SegmentedItem { Text = "全部", Tag = BorrowFilterType.All },
                new SegmentedItem { Text = "待还", Tag = BorrowFilterType.Await },
                new SegmentedItem { Text = "已还", Tag = BorrowFilterType.Already },
                new SegmentedItem { Text = "超时", Tag = BorrowFilterType.Timeout },
            }));
            filter.SelectIndex = 0;
        }

        private void search_change(object sender, EventArgs e)
        {
            FilterList();
        }

        private void filter_borrow_status(object sender, SegmentedItemEventArgs e)
        {
            FilterList(e.Item.Tag! is BorrowFilterType ? (BorrowFilterType)e.Item.Tag! : BorrowFilterType.All);
        }

        private void InitTable()
        {
            var tableColumnConfig = new ColumnCollection
            {
                new Column(nameof(BorrowInfoItem.BookName), "被借阅书籍", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BorrowInfoItem.ReaderName), "借阅人", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BorrowInfoItem.BorrowDate), "借书日期", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BorrowInfoItem.BorrowOverDate), "还书日期", ColumnAlign.Center) { Fixed = false },
                new Column(nameof(BorrowInfoItem.Status), "当前状态", ColumnAlign.Center) { Fixed = true },
                new Column(nameof(BorrowInfoItem.OperationBtns), "操作", ColumnAlign.Center) { Fixed = true },
            };
            table.Columns = tableColumnConfig;
            table.CellButtonClick += ItemOperationClick;
        }

        private void ItemOperationClick(object sender, TableButtonEventArgs e)
        {
            if (e.Btn.Id == AppConstant.UpdateBtnTag)
            {
                ItemUpdate(e.Record as BorrowInfoItem ?? throw new InvalidOperationException("拿不到操作的信息"));
            }
            else
            {
                ItemDelete(e.Record as BorrowInfoItem ?? throw new InvalidOperationException("拿不到操作的信息"));
            }
           
        }

        private void ItemDelete(BorrowInfoItem record)
        {
            new AntdUI.Modal.Config(_context, "借阅记录删除提示",
                $"{record},你确定要删除此借阅记录嘛吗,",
                AntdUI.TType.Warn)
            {
                Font = new Font("微软雅黑", 12),
                OnOk = config =>
                {
                    _context.Invoke(new Action(() =>
                    {
                        BroadcastCenter.Publish(new FrameLoadingLaunchBcast("正在删除"));
                    }));
                    var (msg, res) = _borrowInfoRep.DeleteBorrowInfo(record.ReaderId, record.BookId);
                    if (res)
                    {
                        RefreshList();
                        _context.SuccessNotification("删除成功", msg);
                    }
                    else
                    {
                        _context.ErrNotification("删除失败", msg);
                    }
                    _context.Invoke(new Action(() =>
                    {
                        BroadcastCenter.Publish(new FrameLoadingStopBcast());
                    }));
                    return true;
                }
            }.open();
        }
        private void ItemUpdate(BorrowInfoItem record)
        {
            new AntdUI.Modal.Config(_context, "还书提示",
                $"你确定要读者【{record.ReaderName}】归还还书籍{record.BookName}吗",
                AntdUI.TType.Info)
            {
                Font = new Font("微软雅黑", 12),
                OnOk = config =>
                {
                    _context.Invoke(new Action(() =>
                    {
                        BroadcastCenter.Publish(new FrameLoadingLaunchBcast("正在归还"));
                    }));
                    _bookInfoRep.ChangeBookStatus(record.BookId, 1);
                    var (msg, res) = _borrowInfoRep.UpdateBorrowStatus(record.BookId, record.ReaderId, BorrowEntityStatus.Already);
                    if (res)
                    {
                        RefreshList();
                        _context.SuccessNotification("归还书籍成功", msg);
                    }
                    else
                    {
                        _bookInfoRep.ChangeBookStatus(record.BookId, 0);
                        _context.ErrNotification("归还书籍失败", msg);
                    }

                    _context.Invoke(new Action(() => { BroadcastCenter.Publish(new FrameLoadingStopBcast()); }));
                    return true;
                }
            }.open();
        }
        private void add_borrow(object sender, EventArgs e)
        {
            new AddBorrowDialog(_readerList, _bookList, _context, (borrowInfo) =>
            {
                _context.Invoke(new Action(() => { BroadcastCenter.Publish(new FrameLoadingLaunchBcast("正在新增")); }));
                _bookInfoRep.ChangeBookStatus(borrowInfo.BookId, 0);
                var (msg, data) = _borrowInfoRep.AddBorrowInfo(borrowInfo);
                if (data)
                {
                    _context.SuccessNotification("新增成功", msg);
                    RefreshList();
                }
                else
                {
                    _bookInfoRep.ChangeBookStatus(borrowInfo.BookId, 1);
                    _context.ErrNotification("新增失败", msg);
                }

                _context.Invoke(new Action(() => { BroadcastCenter.Publish(new FrameLoadingStopBcast()); }));
            }).ShowDialog();
        }

        private void RefreshList()
        {
            _bookList= _bookInfoRep.GetBookInfoList().Data;
            sourceItemList = _borrowInfoRep.GetBorrowInfoList().Data.Select(item =>
            {
                var bookName = _bookList.Find(x => x.BookId == item.BookId)?.Name;
                if (bookName == null) return null;
                var readerName = _readerList.Find(x => x.ReaderId == item.ReaderId)?.Name;
                return readerName == null ? null : new BorrowInfoItem(item, readerName, bookName);
            }).Where(item => item != null).ToList()!;
            renderItemList = sourceItemList;
            table.DataSource = renderItemList;
            search.Text = "";
        }

        private void FilterList(BorrowFilterType? filterBorrowType = null)
        {
            var newRenderList = sourceItemList.Where(item => item.BookName.Contains(search.Text));
            if (filterBorrowType != null)
            {
                switch (filterBorrowType)
                {
                    case BorrowFilterType.All:
                        break;
                    case BorrowFilterType.Await:
                        newRenderList = newRenderList.Where(item => item.StatusEnum == BorrowStatus.Await);
                        break;
                    case BorrowFilterType.Already:
                        newRenderList = newRenderList.Where(item => item.StatusEnum == BorrowStatus.Already);
                        break;
                    case BorrowFilterType.Timeout:
                        newRenderList = newRenderList.Where(item => item.StatusEnum == BorrowStatus.Timeout);
                        break;
                    case null:
                        break;
                    default:
                        throw new Exception("无法解析的过滤类型");
                }
            }

            renderItemList = newRenderList.ToList();
            table.DataSource = renderItemList;
        }
    }
}