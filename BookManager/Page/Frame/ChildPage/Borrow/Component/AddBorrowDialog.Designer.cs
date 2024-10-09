namespace BookManager.Page.Frame.ChildPage.Borrow.Component
{
    partial class AddBorrowDialog
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
            this.bookSelect = new AntdUI.Select();
            this.readerSelect = new AntdUI.Select();
            this.addBtn = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // bookSelect
            // 
            this.bookSelect.Location = new System.Drawing.Point(24, 28);
            this.bookSelect.Name = "bookSelect";
            this.bookSelect.PlaceholderText = "需借阅的书籍";
            this.bookSelect.PrefixText = "借阅书籍";
            this.bookSelect.Size = new System.Drawing.Size(348, 48);
            this.bookSelect.TabIndex = 0;
            // 
            // readerSelect
            // 
            this.readerSelect.Location = new System.Drawing.Point(24, 82);
            this.readerSelect.Name = "readerSelect";
            this.readerSelect.PlaceholderText = "借阅读者";
            this.readerSelect.PrefixText = "借阅人";
            this.readerSelect.Size = new System.Drawing.Size(219, 48);
            this.readerSelect.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(249, 82);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 48);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "新增借阅";
            this.addBtn.Type = AntdUI.TTypeMini.Primary;
            this.addBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // AddBorrowDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 158);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.readerSelect);
            this.Controls.Add(this.bookSelect);
            this.Name = "AddBorrowDialog";
            this.Text = "AddBorrowDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Select bookSelect;
        private AntdUI.Select readerSelect;
        private AntdUI.Button addBtn;
    }
}