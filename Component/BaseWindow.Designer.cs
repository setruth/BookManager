using BookManager.Page.Welcome;
using BookManager.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace BookManager.Component
{
    partial class BaseWindow
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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(this.GetType());
            ClientSize = new System.Drawing.Size(1074, 617);
            components = new System.ComponentModel.Container();
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Icon = ((Icon)(resources.GetObject("$this.Icon")));
            Name = "Welcome";
            Text = "图书管理系统";
        }


        #endregion
    }
}