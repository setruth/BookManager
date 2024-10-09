using BookManager.DB.Repository;
using BookManager.Model;
using BookManager.Util;
using System;
using System.Windows.Forms;

namespace BookManager.Page.Welcome.Component
{
    public partial class Login : UserControl
    {
        private readonly LoginInfoRepository _loginInfoRep = LoginInfoRepository.GetRep();
        public event LoginSuccessEventHandler? LoginSuccess;
        public event ToRegisterEventHandler? ToRegister;
        public Login()
        {
            InitializeComponent();
        }

        public void login_confirm(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(loginActInput.Text))
            {
                ParentForm?.WarnNotification("登录提示", "账号不能为空");
                return;
            }

            if (string.IsNullOrEmpty(loginPwdInput.Text))
            {
                ParentForm?.WarnNotification("登录提示", "登录密码不能为空");
                return;
            }

            var (msg, data) = _loginInfoRep.Login(loginActInput.Text, loginPwdInput.Text);
            if (data)
            {
                ParentForm?.SuccessNotification("登录成功", msg);
                LoginSuccess?.Invoke();
            }
            else
            {
                ParentForm?.ErrNotification("登录失败", msg);
            }
        }

        private void to_register(object sender, EventArgs e)
        {
            ToRegister?.Invoke();
        }

        public void SetLoginAct(string loginAct)
        {
            loginActInput.Text = loginAct;
        }

    }
}