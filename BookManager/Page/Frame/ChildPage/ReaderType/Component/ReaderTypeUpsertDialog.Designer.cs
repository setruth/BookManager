namespace BookManager.Page.Frame.ChildPage.ReaderType.Component
{
    partial class ReaderTypeUpsertDialog
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
            this.nameInput = new AntdUI.Input();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.upsertBtn = new AntdUI.Button();
            this.borrowDayInput = new AntdUI.InputNumber();
            this.borrowNumberInput = new AntdUI.InputNumber();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.AllowClear = true;
            this.nameInput.Location = new System.Drawing.Point(35, 30);
            this.nameInput.Name = "nameInput";
            this.nameInput.PlaceholderText = "类型名称";
            this.nameInput.Size = new System.Drawing.Size(261, 43);
            this.nameInput.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(35, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.borrowNumberInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.borrowDayInput);
            this.splitContainer1.Size = new System.Drawing.Size(261, 43);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 2;
            // 
            // upsertBtn
            // 
            this.upsertBtn.Location = new System.Drawing.Point(72, 138);
            this.upsertBtn.Name = "upsertBtn";
            this.upsertBtn.Size = new System.Drawing.Size(163, 43);
            this.upsertBtn.TabIndex = 4;
            this.upsertBtn.Text = "更新类型信息";
            this.upsertBtn.Type = AntdUI.TTypeMini.Primary;
            this.upsertBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // borrowDayInput
            // 
            this.borrowDayInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowDayInput.Location = new System.Drawing.Point(0, 0);
            this.borrowDayInput.Name = "borrowDayInput";
            this.borrowDayInput.PlaceholderText = "可借天数";
            this.borrowDayInput.Size = new System.Drawing.Size(127, 43);
            this.borrowDayInput.SuffixText = "/天";
            this.borrowDayInput.TabIndex = 5;
            // 
            // borrowNumberInput
            // 
            this.borrowNumberInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowNumberInput.Location = new System.Drawing.Point(0, 0);
            this.borrowNumberInput.Name = "borrowNumberInput";
            this.borrowNumberInput.PlaceholderText = "可借数量";
            this.borrowNumberInput.Size = new System.Drawing.Size(130, 43);
            this.borrowNumberInput.SuffixText = "/本";
            this.borrowNumberInput.TabIndex = 6;
            // 
            // UserTypeUpsertDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 203);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.upsertBtn);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserTypeUpsertDialog";
            this.Text = "用户类型更新";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Input nameInput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AntdUI.Button upsertBtn;
        private AntdUI.InputNumber borrowDayInput;
        private AntdUI.InputNumber borrowNumberInput;
    }
}