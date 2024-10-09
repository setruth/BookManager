using BookManager.DB;
using BookManager.Model;
using BookManager.Page.Welcome;
using System;
using System.Windows.Forms;
using BookManager.Page.Frame;

namespace BookManager
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlServerHelper.InitInstance(AppConstant.SqlServerConnectInfo);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Frame());
        }
    }
}
