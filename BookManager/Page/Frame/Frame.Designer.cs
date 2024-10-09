using System.Windows.Forms;
using BookManager.Model;

namespace BookManager.Page.Frame
{
    partial class Frame
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
            AntdUI.MenuItem menuItem5 = new AntdUI.MenuItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            AntdUI.MenuItem menuItem6 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem7 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem8 = new AntdUI.MenuItem();
            this.frameSplit = new System.Windows.Forms.SplitContainer();
            this.leftSplit = new System.Windows.Forms.SplitContainer();
            this.panel3 = new AntdUI.Panel();
            this.titleSplit = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new AntdUI.Label();
            this.panel1 = new AntdUI.Panel();
            this.button1 = new AntdUI.Button();
            this.menu = new AntdUI.Menu();
            this.menuContentCard = new AntdUI.Panel();
            this.container = new AntdUI.Panel();
            this.loading = new AntdUI.Spin();
            ((System.ComponentModel.ISupportInitialize)(this.frameSplit)).BeginInit();
            this.frameSplit.Panel1.SuspendLayout();
            this.frameSplit.Panel2.SuspendLayout();
            this.frameSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplit)).BeginInit();
            this.leftSplit.Panel1.SuspendLayout();
            this.leftSplit.Panel2.SuspendLayout();
            this.leftSplit.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleSplit)).BeginInit();
            this.titleSplit.Panel1.SuspendLayout();
            this.titleSplit.Panel2.SuspendLayout();
            this.titleSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // frameSplit
            // 
            this.frameSplit.AllowDrop = true;
            this.frameSplit.BackColor = System.Drawing.Color.Transparent;
            this.frameSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.frameSplit.IsSplitterFixed = true;
            this.frameSplit.Location = new System.Drawing.Point(0, 0);
            this.frameSplit.Name = "frameSplit";
            // 
            // frameSplit.Panel1
            // 
            this.frameSplit.Panel1.Controls.Add(this.leftSplit);
            this.frameSplit.Panel1.Padding = new System.Windows.Forms.Padding(13, 13, 5, 13);
            // 
            // frameSplit.Panel2
            // 
            this.frameSplit.Panel2.Controls.Add(this.menuContentCard);
            this.frameSplit.Panel2.Padding = new System.Windows.Forms.Padding(0, 13, 13, 13);
            this.frameSplit.Size = new System.Drawing.Size(1074, 617);
            this.frameSplit.SplitterDistance = 230;
            this.frameSplit.TabIndex = 0;
            this.frameSplit.TabStop = false;
            // 
            // leftSplit
            // 
            this.leftSplit.BackColor = System.Drawing.Color.Transparent;
            this.leftSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.leftSplit.IsSplitterFixed = true;
            this.leftSplit.Location = new System.Drawing.Point(13, 13);
            this.leftSplit.Margin = new System.Windows.Forms.Padding(0);
            this.leftSplit.Name = "leftSplit";
            this.leftSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftSplit.Panel1
            // 
            this.leftSplit.Panel1.Controls.Add(this.panel3);
            this.leftSplit.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            // 
            // leftSplit.Panel2
            // 
            this.leftSplit.Panel2.Controls.Add(this.panel1);
            this.leftSplit.Size = new System.Drawing.Size(212, 591);
            this.leftSplit.SplitterDistance = 70;
            this.leftSplit.SplitterWidth = 1;
            this.leftSplit.TabIndex = 0;
            this.leftSplit.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.titleSplit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Radius = 8;
            this.panel3.Size = new System.Drawing.Size(212, 65);
            this.panel3.TabIndex = 1;
            this.panel3.Text = "panel3";
            // 
            // titleSplit
            // 
            this.titleSplit.BackColor = System.Drawing.Color.Transparent;
            this.titleSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleSplit.Enabled = false;
            this.titleSplit.Location = new System.Drawing.Point(0, 0);
            this.titleSplit.Name = "titleSplit";
            // 
            // titleSplit.Panel1
            // 
            this.titleSplit.Panel1.Controls.Add(this.pictureBox1);
            // 
            // titleSplit.Panel2
            // 
            this.titleSplit.Panel2.Controls.Add(this.label1);
            this.titleSplit.Size = new System.Drawing.Size(212, 65);
            this.titleSplit.SplitterDistance = 63;
            this.titleSplit.TabIndex = 0;
            this.titleSplit.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BookManager.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书管理系统";
            this.label1.TooltipConfig = null;
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 8;
            this.panel1.Size = new System.Drawing.Size(212, 520);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(11, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "退出登录";
            this.button1.Type = AntdUI.TTypeMini.Error;
            this.button1.Click += new System.EventHandler(this.Logout);
            // 
            // menu
            // 
            this.menu.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.ForeActive = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            menuItem5.Expand = false;
            menuItem5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem5.IconSvg = resources.GetString("menuItem5.IconSvg");
            menuItem5.PARENTITEM = null;
            menuItem5.Select = true;
            menuItem5.Tag = BookManager.Model.MenuTag.ReaderType;
            menuItem5.Text = "读者类别";
            menuItem6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem6.IconSvg = resources.GetString("menuItem6.IconSvg");
            menuItem6.PARENTITEM = null;
            menuItem6.Select = false;
            menuItem6.Tag = BookManager.Model.MenuTag.ReaderManager;
            menuItem6.Text = "读者管理";
            menuItem7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem7.IconSvg = resources.GetString("menuItem7.IconSvg");
            menuItem7.PARENTITEM = null;
            menuItem7.Select = false;
            menuItem7.Tag = BookManager.Model.MenuTag.Book;
            menuItem7.Text = "图书管理";
            menuItem8.Expand = false;
            menuItem8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem8.IconSvg = resources.GetString("menuItem8.IconSvg");
            menuItem8.PARENTITEM = null;
            menuItem8.Select = false;
            menuItem8.Tag = BookManager.Model.MenuTag.DebitBook;
            menuItem8.Text = "借书还书";
            this.menu.Items.Add(menuItem5);
            this.menu.Items.Add(menuItem6);
            this.menu.Items.Add(menuItem7);
            this.menu.Items.Add(menuItem8);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Mode = AntdUI.TMenuMode.Vertical;
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10);
            this.menu.Radius = 5;
            this.menu.Size = new System.Drawing.Size(212, 520);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu1";
            this.menu.SelectChanged += new AntdUI.SelectEventHandler(this.menu_SelectChanged);
            // 
            // menuContentCard
            // 
            this.menuContentCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuContentCard.Location = new System.Drawing.Point(0, 13);
            this.menuContentCard.Name = "menuContentCard";
            this.menuContentCard.Radius = 8;
            this.menuContentCard.Size = new System.Drawing.Size(827, 591);
            this.menuContentCard.TabIndex = 0;
            this.menuContentCard.Text = "panel4";
            // 
            // container
            // 
            this.container.Back = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.container.Controls.Add(this.frameSplit);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1074, 617);
            this.container.TabIndex = 0;
            this.container.Text = "panel2";
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.White;
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.loading.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(1074, 617);
            this.loading.TabIndex = 1;
            this.loading.Text = "spin1";
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1074, 617);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.container);
            this.Name = "Frame";
            this.frameSplit.Panel1.ResumeLayout(false);
            this.frameSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frameSplit)).EndInit();
            this.frameSplit.ResumeLayout(false);
            this.leftSplit.Panel1.ResumeLayout(false);
            this.leftSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftSplit)).EndInit();
            this.leftSplit.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.titleSplit.Panel1.ResumeLayout(false);
            this.titleSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleSplit)).EndInit();
            this.titleSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer frameSplit;
        private SplitContainer leftSplit;
        private SplitContainer titleSplit;
        private PictureBox pictureBox1;
        private AntdUI.Label label1;
        private AntdUI.Panel panel1;
        private AntdUI.Panel container;
        private AntdUI.Panel panel3;
        private AntdUI.Panel menuContentCard;
        private AntdUI.Menu menu;
        private AntdUI.Button button1;
        private AntdUI.Spin loading;
    }
}