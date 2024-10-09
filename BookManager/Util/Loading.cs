using System;
using System.Drawing;
using AntdUI;

namespace BookManager.Util
{
    public static class Loading
    {
        private static readonly Spin.Config _defaultConfig = new Spin.Config()
        {
            Back = Color.FromArgb(100, 59, 95, 110),
            Color = Color.FromArgb(255, 37, 175, 244),
            Font =   new Font("宋体", 12, FontStyle.Bold),
        };

        public static void antdLoading(this IControl control, string msg, Action action, Action? end = null)
        {
            _defaultConfig.Text = msg;
            control.Spin(_defaultConfig, action, end);
        }
    }
}