using AntdUI;
using BookManager.Component;
using BookManager.Model;
using BookManager.Page.Frame.ChildPage.Reader;
using BookManager.Page.Frame.ChildPage.ReaderType;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BookManager.Page.Frame.ChildPage.Book;
using BookManager.Page.Frame.ChildPage.Borrow;
using BookManager.Util;

namespace BookManager.Page.Frame
{
    public partial class Frame : BaseWindow
    {

        private readonly Form context;
        private MenuTag nowContentMenuTag;
        public Frame()
        {
            context = this;
            InitializeComponent();
            ChangeMenuContent(new ReaderType(this));
            loading.Visible = false;
            BroadcastCenter.Subscribe<FrameLoadingLaunchBcast>(LoadingLaunch);
            BroadcastCenter.Subscribe<FrameLoadingStopBcast>(LoadingStop);
        }

        private void LoadingLaunch(FrameLoadingLaunchBcast bcast)
        {
            loading.Visible = true;
            loading.Text = bcast.Msg;
            
        }
        private void LoadingStop(FrameLoadingStopBcast bcast)
        {
            loading.Visible = false;
        }
        private void menu_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            if (!(e.Value.Tag is MenuTag menuTag)) return;
            if (nowContentMenuTag == menuTag)
            {
                return;
            }
            switch (menuTag)
            {
                case MenuTag.ReaderType:
                    ChangeMenuContent(new ReaderType(this));
                    break;
                case MenuTag.ReaderManager:
                    ChangeMenuContent(new Reader(this));
                    break;
                case MenuTag.Book:
                    ChangeMenuContent(new Book(this));
                    break;
                case MenuTag.DebitBook:
                    ChangeMenuContent(new Borrow(this));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            nowContentMenuTag = menuTag;
        }

        private void ChangeMenuContent(UserControl content)
        {
            content.Dock = DockStyle.Fill;
            menuContentCard.Controls.Clear();
            menuContentCard.Controls.Add(content);
            content.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(this, "退出登录提示", "你确认要退出登录嘛，退出后将返回登录页面", AntdUI.TType.Warn)
            {
                Font = new Font("微软雅黑", 12),
                OnOk = config =>
                {

                    new Thread(delegate () { new Welcome.Welcome().ShowDialog(); }).Start();
                    context.Invoke(new Action(() =>
                    {
                        context.Close();
                    }));
                    return true;
                }
            });
        }
    }
}
