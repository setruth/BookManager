using BookManager.DB.Repository;
using BookManager.Model;
using BookManager.Util;
using System;
using System.Windows.Forms;

namespace BookManager.Page.Welcome.Component
{
    public partial class Register : UserControl
    {
        private readonly LoginInfoRepository _loginInfoRep = LoginInfoRepository.GetRep();
        public event ToLoginEventHandler? ToLogin;
        public event RegisterSuccessEventHandler? RegisterSuccess;

        public Register()
        {
            InitializeComponent();
        }

        private void register_confirm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(registerActInput.Text))
            {
                ParentForm?.WarnNotification("注册提示", "账号不能为空");
                return;
            }

            if (string.IsNullOrEmpty(registerPwdInput.Text))
            {
                ParentForm?.WarnNotification("注册提示", "登录密码不能为空");
                return;
            }

            if (registerPwdInput.Text != registerPwdConfirmInput.Text)
            {
                ParentForm?.WarnNotification("注册提示", "确认登录密码与登录密码不相同");
                return;
            }

            try
            {
                if (_loginInfoRep.GetLoginInfo(registerActInput.Text).Data != null)
                {
                    ParentForm?.WarnNotification("注册提示", "登录账号重复");
                    return;
                }
                var (msg, data) = _loginInfoRep.Register(registerActInput.Text, registerPwdInput.Text);
                if (data)
                {
                    ParentForm?.SuccessNotification("注册成功", msg);
                    RegisterSuccess?.Invoke(registerActInput.Text);
                }
                else
                {
                    ParentForm?.ErrNotification("注册失败", msg);
                }
            }
            catch (Exception exception)
            {
                ParentForm?.ErrNotification("注册失败", exception.Message);
            }
        }

        private void to_login(object sender, EventArgs e)
        {
            ToLogin?.Invoke();
        }
    }
}