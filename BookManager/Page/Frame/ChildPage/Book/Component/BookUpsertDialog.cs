using System;
using System.Windows.Forms;
using BookManager.Component;
using BookManager.Page.Frame.ChildPage.Book.Model;
using BookManager.Util;

namespace BookManager.Page.Frame.ChildPage.Book.Component
{
    public partial class BookUpsertDialog : BaseDialog
    {
        private Action<BookInfo> _confirmCB;
        private Form _context;
        private BookInfo? _defaultInfo;

        public BookUpsertDialog(Form context, Action<BookInfo> confirmCB, BookInfo? defaultInfo = null)
        {
            _context = context;
            InitializeComponent();
            _defaultInfo = defaultInfo;
            _confirmCB = confirmCB;
            Text = _defaultInfo == null ? "新增书本信息" : "更新书本信息";
            upsertBtn.Text = _defaultInfo == null ? "新增确认" : "更新确认";
            if (defaultInfo != null)
            {
                InitDefaultInfo();
            }
        }

        private void InitDefaultInfo()
        {
            name.Text = _defaultInfo!.Name;
            author.Text = _defaultInfo.Author;
            press.Text = _defaultInfo.Press;
            price.Value = _defaultInfo.Price;
        }

        private void upsert_confirm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                _context.WarnNotification("操作提示", "书名不能为空");
                return;
            }

            if (string.IsNullOrEmpty(author.Text))
            {
                _context.WarnNotification("操作提示", "作者不能为空");
                return;
            }

            if (string.IsNullOrEmpty(press.Text))
            {
                _context.WarnNotification("操作提示", "出版社不能为空");
                return;
            }

            if (price.Value <= 0)
            {
                _context.WarnNotification("操作提示", "价格的值有问题");
                return;
            }

            _confirmCB(new BookInfo(
                _defaultInfo?.BookId,
                name.Text,
                author.Text,
                press.Text,
                price.Value,
                _defaultInfo?.Status ?? 1
            ));
            Close();
        }
    }
}