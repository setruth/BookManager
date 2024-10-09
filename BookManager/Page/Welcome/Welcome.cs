using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManager.Component;
using BookManager.Page.Welcome.Component;

namespace BookManager.Page.Welcome
{
    public partial class Welcome : BaseWindow
    {
        private readonly Login _loginContent;
        private readonly Register _registerContent;
        private readonly Form _welcomeForm;

        public Welcome()
        {
            InitializeComponent();
            _loginContent = new Login();
            _loginContent.ToRegister += ToRegister;
            _loginContent.LoginSuccess += LoginSuccess;
            _registerContent = new Register();
            _registerContent.ToLogin += ToLogin;
            _registerContent.RegisterSuccess += RegisterSuccess;
            ChangeMenuContent(_loginContent);
            _welcomeForm = this;
        }


        private void ChangeMenuContent(UserControl loadingContent)
        {
            Console.WriteLine(loadingContent);
            loadingContent.Dock = DockStyle.Fill;
            content.Controls.Clear();
            content.Controls.Add(loadingContent);
            loadingContent.Show();
        }

        private void ToLogin()
        {
            ChangeMenuContent(_loginContent);
        }

        private void LoginSuccess()
        {

            var th = new Thread(() => { new Frame.Frame().ShowDialog(); });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();

        }


        private void ToRegister()
        {
            ChangeMenuContent(_registerContent);
        }

        private void RegisterSuccess(string act)
        {
            _loginContent.SetLoginAct(act);
            ChangeMenuContent(_loginContent);
        }


    }
}