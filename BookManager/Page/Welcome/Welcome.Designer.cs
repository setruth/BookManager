namespace BookManager.Page.Welcome
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new AntdUI.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new AntdUI.Panel();
            this.panel3 = new AntdUI.Panel();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.content = new AntdUI.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(96, 97);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 10;
            this.panel1.Shadow = 10;
            this.panel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.ShadowOffsetX = 5;
            this.panel1.ShadowOffsetY = 5;
            this.panel1.ShadowOpacity = 1F;
            this.panel1.Size = new System.Drawing.Size(731, 344);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.content);
            this.splitContainer1.Size = new System.Drawing.Size(711, 324);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BookManager.Properties.Resources.mainLeftBG;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 5;
            this.panel2.Size = new System.Drawing.Size(380, 324);
            this.panel2.TabIndex = 0;
            this.panel2.Text = "panel2";
            // 
            // panel3
            // 
            this.panel3.Back = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 324);
            this.panel3.TabIndex = 0;
            this.panel3.Text = "panel3";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(16, 179);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(275, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "图书管理系统";
            this.label2.TooltipConfig = null;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.TooltipConfig = null;
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Radius = 10;
            this.content.Size = new System.Drawing.Size(327, 324);
            this.content.TabIndex = 0;
            this.content.Text = "panel4";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookManager.Properties.Resources.loginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 539);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AntdUI.Panel panel2;
        private AntdUI.Panel panel3;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Panel content;
    }
}