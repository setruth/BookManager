namespace BookManager.Page.Welcome.Component
{
    partial class Login
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton = new AntdUI.Button();
            this.toRegisterBtn = new AntdUI.Button();
            this.label5 = new AntdUI.Label();
            this.passwordInput = new System.Windows.Forms.SplitContainer();
            this.label1 = new AntdUI.Label();
            this.loginPwdInput = new AntdUI.Input();
            this.accountInput = new System.Windows.Forms.SplitContainer();
            this.label2 = new AntdUI.Label();
            this.loginActInput = new AntdUI.Input();
            this.content = new AntdUI.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.passwordInput)).BeginInit();
            this.passwordInput.Panel1.SuspendLayout();
            this.passwordInput.Panel2.SuspendLayout();
            this.passwordInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountInput)).BeginInit();
            this.accountInput.Panel1.SuspendLayout();
            this.accountInput.Panel2.SuspendLayout();
            this.accountInput.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BorderWidth = 1F;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginButton.Location = new System.Drawing.Point(95, 194);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(167, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "登录";
            this.loginButton.Type = AntdUI.TTypeMini.Primary;
            this.loginButton.Click += new System.EventHandler(this.login_confirm);
            // 
            // toRegisterBtn
            // 
            this.toRegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toRegisterBtn.BorderWidth = 1F;
            this.toRegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toRegisterBtn.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toRegisterBtn.Ghost = true;
            this.toRegisterBtn.IsLink = true;
            this.toRegisterBtn.Location = new System.Drawing.Point(95, 240);
            this.toRegisterBtn.Name = "toRegisterBtn";
            this.toRegisterBtn.ShowArrow = true;
            this.toRegisterBtn.Size = new System.Drawing.Size(167, 40);
            this.toRegisterBtn.TabIndex = 6;
            this.toRegisterBtn.Text = "没有账号？去注册";
            this.toRegisterBtn.Type = AntdUI.TTypeMini.Primary;
            this.toRegisterBtn.Click += new System.EventHandler(this.to_register);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(59, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "登录";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.TooltipConfig = null;
            // 
            // passwordInput
            // 
            this.passwordInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordInput.BackColor = System.Drawing.Color.Transparent;
            this.passwordInput.IsSplitterFixed = true;
            this.passwordInput.Location = new System.Drawing.Point(27, 132);
            this.passwordInput.Name = "passwordInput";
            // 
            // passwordInput.Panel1
            // 
            this.passwordInput.Panel1.Controls.Add(this.label1);
            this.passwordInput.Panel1MinSize = 30;
            // 
            // passwordInput.Panel2
            // 
            this.passwordInput.Panel2.Controls.Add(this.loginPwdInput);
            this.passwordInput.Size = new System.Drawing.Size(303, 45);
            this.passwordInput.SplitterDistance = 46;
            this.passwordInput.TabIndex = 5;
            this.passwordInput.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "密码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.TooltipConfig = null;
            // 
            // loginPwdInput
            // 
            this.loginPwdInput.AllowClear = true;
            this.loginPwdInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPwdInput.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginPwdInput.Location = new System.Drawing.Point(0, 0);
            this.loginPwdInput.Name = "loginPwdInput";
            this.loginPwdInput.PasswordPaste = false;
            this.loginPwdInput.PrefixSvg = resources.GetString("loginPwdInput.PrefixSvg");
            this.loginPwdInput.Size = new System.Drawing.Size(253, 45);
            this.loginPwdInput.TabIndex = 1;
            this.loginPwdInput.UseSystemPasswordChar = true;
            // 
            // accountInput
            // 
            this.accountInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountInput.BackColor = System.Drawing.Color.Transparent;
            this.accountInput.IsSplitterFixed = true;
            this.accountInput.Location = new System.Drawing.Point(27, 81);
            this.accountInput.Name = "accountInput";
            // 
            // accountInput.Panel1
            // 
            this.accountInput.Panel1.Controls.Add(this.label2);
            this.accountInput.Panel1MinSize = 30;
            // 
            // accountInput.Panel2
            // 
            this.accountInput.Panel2.Controls.Add(this.loginActInput);
            this.accountInput.Size = new System.Drawing.Size(303, 45);
            this.accountInput.SplitterDistance = 46;
            this.accountInput.TabIndex = 4;
            this.accountInput.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "账号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.TooltipConfig = null;
            // 
            // loginActInput
            // 
            this.loginActInput.AllowClear = true;
            this.loginActInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginActInput.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginActInput.Location = new System.Drawing.Point(0, 0);
            this.loginActInput.Name = "loginActInput";
            this.loginActInput.PrefixSvg = resources.GetString("loginActInput.PrefixSvg");
            this.loginActInput.Size = new System.Drawing.Size(253, 45);
            this.loginActInput.TabIndex = 0;
            // 
            // content
            // 
            this.content.Controls.Add(this.accountInput);
            this.content.Controls.Add(this.passwordInput);
            this.content.Controls.Add(this.label5);
            this.content.Controls.Add(this.toRegisterBtn);
            this.content.Controls.Add(this.loginButton);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(357, 325);
            this.content.TabIndex = 11;
            this.content.Text = "panel1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.content);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(357, 325);
            this.passwordInput.Panel1.ResumeLayout(false);
            this.passwordInput.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordInput)).EndInit();
            this.passwordInput.ResumeLayout(false);
            this.accountInput.Panel1.ResumeLayout(false);
            this.accountInput.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountInput)).EndInit();
            this.accountInput.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Button loginButton;
        private AntdUI.Button toRegisterBtn;
        private AntdUI.Label label5;
        private System.Windows.Forms.SplitContainer passwordInput;
        private AntdUI.Label label1;
        private AntdUI.Input loginPwdInput;
        private System.Windows.Forms.SplitContainer accountInput;
        private AntdUI.Label label2;
        private AntdUI.Input loginActInput;
        private AntdUI.Panel content;
    }
}
