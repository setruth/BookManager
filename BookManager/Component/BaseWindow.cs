using AntdUI;
using System.Windows.Forms;

namespace BookManager.Component
{
    public partial class BaseWindow : BaseForm
    {
        public BaseWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            AntdUI.Config.SetCorrectionTextRendering("Microsoft YaHei UI", "宋体");
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}