using AntdUI;
using System.Drawing;
using System.Windows.Forms;

namespace BookManager.Util
{
    /// <summary>
    /// 通知功能的扩展类，提供不同类型的通知显示方法
    /// </summary>
    public static class Notification
    {
        /// <summary>
        /// 错误通知的持续时间（秒）
        /// </summary>
        private const int Duration = 4;

        /// <summary>
        /// 通知的圆角半径
        /// </summary>
        private const int Radius = 10;

        /// <summary>
        /// 通知的圆角半径
        /// </summary>
        private const TAlignFrom Direction = TAlignFrom.Top;
        /// <summary>
        /// 显示错误类型的通知
        /// </summary>
        /// <param name="window">关联的窗口对象</param>
        /// <param name="title">通知标题</param>
        /// <param name="msg">通知内容</param>
        public static void ErrNotification(this Form window, string title, string msg)
        {
            ShowNotification(window, title, msg, TType.Error);
        }

        /// <summary>
        /// 显示信息类型的通知
        /// </summary>
        /// <param name="window">关联的窗口对象</param>
        /// <param name="title">通知标题</param>
        /// <param name="msg">通知内容</param>
        public static void InfoNotification(this Form window, string title, string msg)
        {
            ShowNotification(window, title, msg, TType.Info);
        }

        /// <summary>
        /// 显示警告类型的通知
        /// </summary>
        /// <param name="window">关联的窗口对象</param>
        /// <param name="title">通知标题</param>
        /// <param name="msg">通知内容</param>
        public static void WarnNotification(this Form window, string title, string msg)
        {
            ShowNotification(window, title, msg, TType.Warn);
        }

        /// <summary>
        /// 显示成功类型的通知
        /// </summary>
        /// <param name="window">关联的窗口对象</param>
        /// <param name="title">通知标题</param>
        /// <param name="msg">通知内容</param>
        public static void SuccessNotification(this Form window, string title, string msg)
        {
            ShowNotification(window, title, msg, TType.Success);
        }

        /// <summary>
        /// 显示默认类型的通知
        /// </summary>
        /// <param name="window">关联的窗口对象</param>
        /// <param name="title">通知标题</param>
        /// <param name="msg">通知内容</param>
        public static void DefaultNotification(this Form window, string title, string msg)
        {
            ShowNotification(window, title, msg, TType.None);
        }

        /// <summary>
        /// 内部方法，用于实际显示通知
        /// </summary>
        /// <param name="window">关联的窗口对象</param>
        /// <param name="title">通知标题</param>
        /// <param name="msg">通知内容</param>
        /// <param name="iconType">通知图标类型</param>
        private static void ShowNotification(this Form window, string title, string msg, TType iconType)
        {
            new AntdUI.Notification.Config(window, title, msg, iconType, Direction)
            {
                AutoClose = Duration,
                Radius = Radius,
                FontStyleTitle = FontStyle.Bold
            }.open();
        }
    }

}