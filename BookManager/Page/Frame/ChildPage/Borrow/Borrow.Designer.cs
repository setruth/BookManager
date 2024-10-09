namespace BookManager.Page.Frame.ChildPage.Borrow
{
    partial class Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            this.search = new AntdUI.Input();
            this.addBtn = new AntdUI.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.filter = new AntdUI.Segmented();
            this.panel1 = new AntdUI.Panel();
            this.table = new AntdUI.Table();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.AllowClear = true;
            this.search.Location = new System.Drawing.Point(13, 9);
            this.search.Name = "search";
            this.search.PlaceholderText = "输入图书名称搜素";
            this.search.PrefixSvg = "";
            this.search.PrefixText = "书籍过滤";
            this.search.Size = new System.Drawing.Size(236, 42);
            this.search.SuffixSvg = resources.GetString("search.SuffixSvg");
            this.search.TabIndex = 3;
            this.search.TextChanged += new System.EventHandler(this.search_change);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.addBtn.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.addBtn.IconSvg = resources.GetString("addBtn.IconSvg");
            this.addBtn.Location = new System.Drawing.Point(661, 9);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 42);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "新增借书记录";
            this.addBtn.Type = AntdUI.TTypeMini.Primary;
            this.addBtn.Click += new System.EventHandler(this.add_borrow);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.filter);
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Panel1.Controls.Add(this.addBtn);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 5;
            // 
            // filter
            // 
            this.filter.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.filter.BarPadding = 10;
            this.filter.ForeActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filter.Full = true;
            this.filter.Location = new System.Drawing.Point(255, 9);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(182, 42);
            this.filter.TabIndex = 4;
            this.filter.Text = "segmented1";
            this.filter.ItemClick += new AntdUI.SegmentedItemEventHandler(this.filter_borrow_status);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.table);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 366);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.White;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowSelectedBg = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.table.Size = new System.Drawing.Size(780, 366);
            this.table.TabIndex = 0;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Borrow";
            this.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Input search;
        private AntdUI.Button addBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AntdUI.Panel panel1;
        private AntdUI.Table table;
        private AntdUI.Segmented filter;
    }
}