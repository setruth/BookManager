namespace BookManager.Page.Frame.ChildPage.Reader.Component
{
    partial class ReaderInfoUpsertDialog
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.name = new AntdUI.Input();
            this.qq = new AntdUI.Input();
            this.department = new AntdUI.Input();
            this.typeSelect = new AntdUI.Select();
            this.upsertBtn = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(23, 22);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.name);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.qq);
            this.splitContainer1.Size = new System.Drawing.Size(381, 48);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // name
            // 
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Name = "name";
            this.name.PlaceholderText = "读者名字";
            this.name.PrefixText = "名字";
            this.name.Size = new System.Drawing.Size(190, 48);
            this.name.TabIndex = 0;
            // 
            // qq
            // 
            this.qq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qq.Location = new System.Drawing.Point(0, 0);
            this.qq.Name = "qq";
            this.qq.PlaceholderText = "读者联系QQ号";
            this.qq.PrefixText = "QQ";
            this.qq.Size = new System.Drawing.Size(187, 48);
            this.qq.TabIndex = 1;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(23, 77);
            this.department.Name = "department";
            this.department.PlaceholderText = "读者所在院校或则单位等";
            this.department.PrefixText = "读者部门";
            this.department.Size = new System.Drawing.Size(381, 48);
            this.department.TabIndex = 2;
            // 
            // typeSelect
            // 
            this.typeSelect.Location = new System.Drawing.Point(23, 132);
            this.typeSelect.Name = "typeSelect";
            this.typeSelect.PlaceholderText = "选择读者的类型";
            this.typeSelect.PrefixText = "读者类型";
            this.typeSelect.Size = new System.Drawing.Size(261, 48);
            this.typeSelect.TabIndex = 3;
            // 
            // upsertBtn
            // 
            this.upsertBtn.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upsertBtn.Location = new System.Drawing.Point(290, 134);
            this.upsertBtn.Name = "upsertBtn";
            this.upsertBtn.Size = new System.Drawing.Size(114, 46);
            this.upsertBtn.TabIndex = 3;
            this.upsertBtn.Text = "新增";
            this.upsertBtn.Type = AntdUI.TTypeMini.Primary;
            this.upsertBtn.Click += new System.EventHandler(this.upsert_confirm);
            // 
            // ReaderInfoUpsertDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 203);
            this.Controls.Add(this.upsertBtn);
            this.Controls.Add(this.typeSelect);
            this.Controls.Add(this.department);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReaderInfoUpsertDialog";
            this.Text = " ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private AntdUI.Input name;
        private AntdUI.Input department;
        private AntdUI.Select typeSelect;
        private AntdUI.Button upsertBtn;
        private AntdUI.Input qq;
    }
}