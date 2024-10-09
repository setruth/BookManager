using System.Windows.Forms;

namespace BookManager.Component
{
    public partial class BaseDialog : Form
    {
        public BaseDialog()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            AntdUI.Config.SetCorrectionTextRendering("Microsoft YaHei UI", "宋体");
            FormBorderStyle = FormBorderStyle.FixedSingle; // 不可调整大小
            MaximizeBox = false;
        }
    }
}
