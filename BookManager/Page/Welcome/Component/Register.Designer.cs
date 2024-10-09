namespace BookManager.Page.Welcome.Component
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.registerContainer = new AntdUI.Panel();
            this.button2 = new AntdUI.Button();
            this.toLoginBtn = new AntdUI.Button();
            this.label6 = new AntdUI.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label9 = new AntdUI.Label();
            this.registerPwdConfirmInput = new AntdUI.Input();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new AntdUI.Label();
            this.registerPwdInput = new AntdUI.Input();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label8 = new AntdUI.Label();
            this.registerActInput = new AntdUI.Input();
            this.registerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerContainer
            // 
            this.registerContainer.Controls.Add(this.button2);
            this.registerContainer.Controls.Add(this.toLoginBtn);
            this.registerContainer.Controls.Add(this.label6);
            this.registerContainer.Controls.Add(this.splitContainer3);
            this.registerContainer.Controls.Add(this.splitContainer1);
            this.registerContainer.Controls.Add(this.splitContainer2);
            this.registerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerContainer.Location = new System.Drawing.Point(0, 0);
            this.registerContainer.Name = "registerContainer";
            this.registerContainer.Size = new System.Drawing.Size(392, 333);
            this.registerContainer.TabIndex = 10;
            this.registerContainer.Text = "panel3";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BorderWidth = 1F;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(54, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "注册";
            this.button2.Type = AntdUI.TTypeMini.Primary;
            this.button2.Click += new System.EventHandler(this.register_confirm);
            // 
            // toLoginBtn
            // 
            this.toLoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toLoginBtn.BorderWidth = 1F;
            this.toLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toLoginBtn.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toLoginBtn.Ghost = true;
            this.toLoginBtn.IsLink = true;
            this.toLoginBtn.Location = new System.Drawing.Point(169, 244);
            this.toLoginBtn.Name = "toLoginBtn";
            this.toLoginBtn.ShowArrow = true;
            this.toLoginBtn.Size = new System.Drawing.Size(166, 40);
            this.toLoginBtn.TabIndex = 6;
            this.toLoginBtn.Text = "已有账号？去登录";
            this.toLoginBtn.Type = AntdUI.TTypeMini.Primary;
            this.toLoginBtn.Click += new System.EventHandler(this.to_login);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(113, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 40);
            this.label6.TabIndex = 7;
            this.label6.Text = "账号注册";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.TooltipConfig = null;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer3.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(48, 184);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label9);
            this.splitContainer3.Panel1MinSize = 30;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.registerPwdConfirmInput);
            this.splitContainer3.Size = new System.Drawing.Size(303, 45);
            this.splitContainer3.SplitterDistance = 65;
            this.splitContainer3.TabIndex = 8;
            this.splitContainer3.TabStop = false;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 45);
            this.label9.TabIndex = 1;
            this.label9.TabStop = false;
            this.label9.Text = "确认密码";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.TooltipConfig = null;
            // 
            // registerPwdConfirmInput
            // 
            this.registerPwdConfirmInput.AllowClear = true;
            this.registerPwdConfirmInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPwdConfirmInput.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.registerPwdConfirmInput.Location = new System.Drawing.Point(0, 0);
            this.registerPwdConfirmInput.Name = "registerPwdConfirmInput";
            this.registerPwdConfirmInput.PasswordPaste = false;
            this.registerPwdConfirmInput.PrefixSvg = resources.GetString("registerPwdConfirmInput.PrefixSvg");
            this.registerPwdConfirmInput.Size = new System.Drawing.Size(234, 45);
            this.registerPwdConfirmInput.TabIndex = 2;
            this.registerPwdConfirmInput.UseSystemPasswordChar = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(45, 133);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1MinSize = 30;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.registerPwdInput);
            this.splitContainer1.Size = new System.Drawing.Size(303, 45);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 45);
            this.label7.TabIndex = 1;
            this.label7.TabStop = false;
            this.label7.Text = "登录密码";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.TooltipConfig = null;
            // 
            // registerPwdInput
            // 
            this.registerPwdInput.AllowClear = true;
            this.registerPwdInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPwdInput.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.registerPwdInput.Location = new System.Drawing.Point(0, 0);
            this.registerPwdInput.Name = "registerPwdInput";
            this.registerPwdInput.PasswordPaste = false;
            this.registerPwdInput.PrefixSvg = resources.GetString("registerPwdInput.PrefixSvg");
            this.registerPwdInput.Size = new System.Drawing.Size(229, 45);
            this.registerPwdInput.TabIndex = 1;
            this.registerPwdInput.UseSystemPasswordChar = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(45, 82);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1MinSize = 30;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.registerActInput);
            this.splitContainer2.Size = new System.Drawing.Size(303, 45);
            this.splitContainer2.SplitterDistance = 70;
            this.splitContainer2.TabIndex = 4;
            this.splitContainer2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 45);
            this.label8.TabIndex = 0;
            this.label8.TabStop = false;
            this.label8.Text = "登录账号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.TooltipConfig = null;
            // 
            // registerActInput
            // 
            this.registerActInput.AllowClear = true;
            this.registerActInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerActInput.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.registerActInput.Location = new System.Drawing.Point(0, 0);
            this.registerActInput.Name = "registerActInput";
            this.registerActInput.PrefixSvg = resources.GetString("registerActInput.PrefixSvg");
            this.registerActInput.Size = new System.Drawing.Size(229, 45);
            this.registerActInput.TabIndex = 0;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.registerContainer);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(392, 333);
            this.registerContainer.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel registerContainer;
        private AntdUI.Button button2;
        private AntdUI.Button toLoginBtn;
        private AntdUI.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private AntdUI.Label label9;
        private AntdUI.Input registerPwdConfirmInput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AntdUI.Label label7;
        private AntdUI.Input registerPwdInput;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private AntdUI.Label label8;
        private AntdUI.Input registerActInput;
    }
}
