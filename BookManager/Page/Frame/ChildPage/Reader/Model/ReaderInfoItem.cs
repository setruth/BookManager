using BookManager.DB.Entity;
using BookManager.Model;

namespace BookManager.Page.Frame.ChildPage.Reader.Model
{
    public class ReaderInfoItem : AntdUI.NotifyProperty
    {
        public ReaderInfoItem(ReaderInfoEntity readerInfoEntity, ReaderTypeEntity readerTypeEntity)
        {
            _readerId = readerInfoEntity.ReaderId;
            _typeId = readerInfoEntity.TypeId;
            _name = readerInfoEntity.Name;
            _typeName = readerTypeEntity.TypeName;
            _department = readerInfoEntity.Department;
            _qq = readerInfoEntity.QQ;
            _alreadyBorrow = readerInfoEntity.AlreadyBorrow;
            _borrowNumber = readerTypeEntity.BorrowNumber;
            _borrowDay = readerTypeEntity.BorrowDay;
            _operationBtns = new AntdUI.CellLink[]
            {
                new AntdUI.CellButton(AppConstant.UpdateBtnTag)
                    { Text = "更新", Type = AntdUI.TTypeMini.Primary, IconSvg = "EditOutlined" },
                new AntdUI.CellButton(AppConstant.DeleteBtnTag)
                    { Text = "删除", Type = AntdUI.TTypeMini.Error, IconSvg = "ClearOutlined" }
            };
        }

        private string _readerId;

        public string ReaderId
        {
            get => _readerId;
            set
            {
                _readerId = value;
                OnPropertyChanged();
            }
        }

        private int _typeId;

        public int TypeId
        {
            get => _typeId;
            set
            {
                _typeId = value;
                OnPropertyChanged();
            }
        }

        private string _typeName;

        public string TypeName
        {
            get => _typeName;
            set
            {
                _typeName = value;
                OnPropertyChanged();
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _department;

        public string Department
        {
            get => _department;
            set
            {
                _department = value;
                OnPropertyChanged();
            }
        }

        private string _qq;

        public string QQ
        {
            get => _qq;
            set
            {
                _qq = value;
                OnPropertyChanged();
            }
        }

        private int _alreadyBorrow;

        public int AlreadyBorrow
        {
            get => _alreadyBorrow;
            set
            {
                _alreadyBorrow = value;
                OnPropertyChanged();
            }
        }

        private int _borrowNumber;

        public int BorrowNumber
        {
            get => _borrowNumber;
            set
            {
                _borrowNumber = value;
                OnPropertyChanged();
            }
        }

        private int _borrowDay;

        public int BorrowDay
        {
            get => _borrowDay;
            set
            {
                _borrowDay = value;
                OnPropertyChanged();
            }
        }

        private AntdUI.CellLink[] _operationBtns;

        public AntdUI.CellLink[] OperationBtns
        {
            get => _operationBtns;
            set
            {
                _operationBtns = value;
                OnPropertyChanged();
            }
        }

        private bool _check;

        public bool Check
        {
            get => _check;
            set
            {
                if (_check == value) return;
                _check = value;
                OnPropertyChanged();
            }
        }
    }
}