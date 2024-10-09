namespace BookManager.Page.Frame.ChildPage.Book.Component
{
    partial class BookUpsertDialog
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
            this.name = new AntdUI.Input();
            this.author = new AntdUI.Input();
            this.press = new AntdUI.Input();
            this.price = new AntdUI.InputNumber();
            this.upsertBtn = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(22, 20);
            this.name.Name = "name";
            this.name.PlaceholderText = "请输入书本名称（不用书名号）";
            this.name.PrefixText = "图书名称";
            this.name.Size = new System.Drawing.Size(406, 48);
            this.name.TabIndex = 0;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(22, 124);
            this.author.Name = "author";
            this.author.PlaceholderText = "本书作者";
            this.author.PrefixText = "作者";
            this.author.Size = new System.Drawing.Size(277, 48);
            this.author.TabIndex = 3;
            // 
            // press
            // 
            this.press.Location = new System.Drawing.Point(22, 70);
            this.press.Name = "press";
            this.press.PlaceholderText = "输入出版社名字";
            this.press.PrefixText = "出版社";
            this.press.Size = new System.Drawing.Size(237, 48);
            this.press.TabIndex = 1;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(265, 70);
            this.price.Name = "price";
            this.price.PlaceholderText = "价格";
            this.price.PrefixText = "价格";
            this.price.Size = new System.Drawing.Size(163, 48);
            this.price.SuffixText = "CNY ￥";
            this.price.TabIndex = 2;
            this.price.Text = "0";
            // 
            // upsertBtn
            // 
            this.upsertBtn.Location = new System.Drawing.Point(305, 124);
            this.upsertBtn.Name = "upsertBtn";
            this.upsertBtn.Size = new System.Drawing.Size(123, 48);
            this.upsertBtn.TabIndex = 5;
            this.upsertBtn.Text = "button1";
            this.upsertBtn.Type = AntdUI.TTypeMini.Primary;
            this.upsertBtn.Click += new System.EventHandler(this.upsert_confirm);
            // 
            // BookUpsertDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 192);
            this.Controls.Add(this.upsertBtn);
            this.Controls.Add(this.price);
            this.Controls.Add(this.press);
            this.Controls.Add(this.author);
            this.Controls.Add(this.name);
            this.Name = "BookUpsertDialog";
            this.Text = "BookInfoUpsertDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Input name;
        private AntdUI.Input author;
        private AntdUI.Input press;
        private AntdUI.InputNumber price;
        private AntdUI.Button upsertBtn;
    }
}