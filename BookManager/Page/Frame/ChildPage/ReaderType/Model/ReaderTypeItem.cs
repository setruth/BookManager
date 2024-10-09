using BookManager.Model;

namespace BookManager.Page.Frame.ChildPage.ReaderType.Model
{
    public class ReaderTypeItem : AntdUI.NotifyProperty
    {
        public ReaderTypeItem(int order, int typeId, string typeName, int borrowNumber, int borrowDay)
        {
            _order = order;
            _typeId = typeId;
            _typeName = typeName;
            _borrowNumber = borrowNumber;
            _borrowDay = borrowDay;
            _operationBtns = new AntdUI.CellLink[]
            {
            new AntdUI.CellButton(AppConstant.UpdateBtnTag) { Text = "更新", Type = AntdUI.TTypeMini.Primary, IconSvg = "EditOutlined" },
            new AntdUI.CellButton(AppConstant.DeleteBtnTag) { Text = "删除", Type = AntdUI.TTypeMini.Error, IconSvg = "ClearOutlined" }
            };
        }

        private int _order;

        public int order
        {
            get => _order;
            set
            {
                _order = value;
                OnPropertyChanged("order");
            }
        }

        private int _typeId;

        public int typeId
        {
            get => _typeId;
            set
            {
                _typeId = value;
                OnPropertyChanged("typeId");
            }
        }

        private string _typeName;

        public string typeName
        {
            get => _typeName;
            set
            {
                _typeName = value;
                OnPropertyChanged("typeName");
            }
        }

        private int _borrowNumber;

        public int borrowNumber
        {
            get => _borrowNumber;
            set
            {
                _borrowNumber = value;
                OnPropertyChanged("borrowNumber");
            }
        }

        private int _borrowDay;

        public int borrowDay
        {
            get => _borrowDay;
            set
            {
                _borrowDay = value;
                OnPropertyChanged("borrowDay");
            }
        }

        private AntdUI.CellLink[] _operationBtns;

        public AntdUI.CellLink[] operationBtns
        {
            get => _operationBtns;
            set
            {
                _operationBtns = value;
                OnPropertyChanged("operationBtns");
            }
        }

        
    }

}