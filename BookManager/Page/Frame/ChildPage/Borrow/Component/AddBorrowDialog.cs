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
using BookManager.Page.Frame.ChildPage.Borrow.Model;
using BookManager.Util;

namespace BookManager.Page.Frame.ChildPage.Borrow.Component
{
    public partial class AddBorrowDialog : BaseDialog
    {
        private Form _context;
        private ReaderTypeRepository _readerTypeRep = ReaderTypeRepository.GetRep();
        private List<ReaderInfoEntity> _readerList;
        private readonly Action<BorrowInfo> _confirmCB;

        public AddBorrowDialog(List<ReaderInfoEntity> readerList, List<BookInfoEntity> bookList, Form context,
            Action<BorrowInfo> confirmCB)
        {
            _context = context;
            InitializeComponent();
            Text = "新增借阅";
            _confirmCB = confirmCB;
            readerSelect.Items.AddRange(readerList.Select(item => new SelectItem(item.ReaderId)
            {
                Text = item.Name,
            }).ToArray<object>());
            bookSelect.Items.AddRange(bookList.Where(item => item.Status == 1).Select(item =>
                new SelectItem(item.BookId)
                {
                    Text = item.Name,
                }).ToArray<object>());
            _readerList = readerList;
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            if (bookSelect.SelectedValue == null)
            {
                _context.WarnNotification("操作提示", "请选择需要借阅书籍");
                return;
            }

            if (readerSelect.SelectedValue == null)
            {
                _context.WarnNotification("操作提示", "请选择借书的读者");
                return;
            }

            var readerInfo = _readerList.Find(item => item.ReaderId == readerSelect.SelectedValue.ToString());
            var (_, typeInfo) = _readerTypeRep.GetReaderType(readerInfo.TypeId);
            if (typeInfo == null)
            {
                _context.ErrNotification("操作提示", "读者类型不存在");
                return;
            }

            var nowDate = DateTime.Now;
            var overDate = nowDate.AddDays(typeInfo.BorrowDay);
            Close();
            _confirmCB(new BorrowInfo(
                readerSelect.SelectedValue.ToString(),
                bookSelect.SelectedValue.ToString(),
                nowDate,
                overDate,
                BorrowEntityStatus.Await
            ));
        }
    }
}