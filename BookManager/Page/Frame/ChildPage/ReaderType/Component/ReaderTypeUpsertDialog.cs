using BookManager.Component;
using BookManager.Model;
using System;
using BookManager.Page.Frame.ChildPage.ReaderType.Model;

namespace BookManager.Page.Frame.ChildPage.ReaderType.Component
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReaderTypeUpsertDialog : BaseDialog
    {
        //是否是更新模式的弹窗
        private ReaderTypeInfo? defaultInfo;

        private Action<ReaderTypeInfo> confirmCB;

        public ReaderTypeUpsertDialog(Action<ReaderTypeInfo> confirmCB, ReaderTypeInfo? readerTypeInfo = null)
        {
            InitializeComponent();
            defaultInfo = readerTypeInfo;
            Text = defaultInfo == null ? "新增读者类型" : "更新读者类型";
            upsertBtn.Text = defaultInfo == null ? "新增确认" : "更新确认";
            this.confirmCB = confirmCB;
            if (defaultInfo != null)
            {
                InitDefaultInfo();
            }
        }


        private void InitDefaultInfo()
        {
            Console.WriteLine(defaultInfo);
            nameInput.Text = defaultInfo.TypeName;
            borrowDayInput.Value = defaultInfo.BorrowDay;
            borrowNumberInput.Value = defaultInfo.BorrowNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            confirmCB(
                new ReaderTypeInfo(
                    defaultInfo?.TypeId,
                    nameInput.Text,
                    int.Parse(borrowDayInput.Text),
                    int.Parse(borrowNumberInput.Text)
                )
            );
            Close();
        }
    }
}