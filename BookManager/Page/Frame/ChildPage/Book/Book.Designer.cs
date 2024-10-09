namespace BookManager.Page.Frame.ChildPage.Book
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.search = new AntdUI.Input();
            this.selectLabel = new AntdUI.Label();
            this.button2 = new AntdUI.Button();
            this.addBtn = new AntdUI.Button();
            this.panel1 = new AntdUI.Panel();
            this.table = new AntdUI.Table();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Panel1.Controls.Add(this.selectLabel);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.addBtn);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 2;
            // 
            // search
            // 
            this.search.AllowClear = true;
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.search.Location = new System.Drawing.Point(13, 9);
            this.search.Name = "search";
            this.search.PlaceholderText = "输入书名称搜素";
            this.search.PrefixSvg = "";
            this.search.PrefixText = "图书过滤";
            this.search.Size = new System.Drawing.Size(236, 42);
            this.search.SuffixSvg = resources.GetString("search.SuffixSvg");
            this.search.TabIndex = 0;
            this.search.TextChanged += new System.EventHandler(this.search_change);
            // 
            // selectLabel
            // 
            this.selectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selectLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectLabel.Location = new System.Drawing.Point(255, 19);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(110, 23);
            this.selectLabel.TabIndex = 6;
            this.selectLabel.Text = "已选中 0";
            this.selectLabel.TooltipConfig = null;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.IconSvg = resources.GetString("button2.IconSvg");
            this.button2.Location = new System.Drawing.Point(558, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "批量删除";
            this.button2.Type = AntdUI.TTypeMini.Error;
            this.button2.Click += new System.EventHandler(this.multiply_del);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.IconSvg = resources.GetString("addBtn.IconSvg");
            this.addBtn.Location = new System.Drawing.Point(661, 9);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 42);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = " 图书信息新增";
            this.addBtn.Type = AntdUI.TTypeMini.Primary;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Book";
            this.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private AntdUI.Input search;
        private AntdUI.Label selectLabel;
        private AntdUI.Button button2;
        private AntdUI.Button addBtn;
        private AntdUI.Panel panel1;
        private AntdUI.Table table;
    }
}
