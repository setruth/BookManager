using System;
using AntdUI;
using BookManager.DB.Entity;
using BookManager.Model;

namespace BookManager.Page.Frame.ChildPage.Book.Model
{
    public class BookInfoItem:NotifyProperty
    {
        public BookInfoItem(BookInfoEntity bookInfoEntity)
        {
            _bookId = bookInfoEntity.BookId;
            _author = bookInfoEntity.Author;
            _press = bookInfoEntity.Press;
            _price = bookInfoEntity.Price;
            _status = new CellBadge(bookInfoEntity.Status == 1 ? "未借出" : "已借出")
            {
                State = bookInfoEntity.Status == 1 ? TState.Primary : TState.Warn
            };
            StatusSource= bookInfoEntity.Status;
            _name= bookInfoEntity.Name;
            _operationBtns = new CellLink[]
            {
                new CellButton(AppConstant.UpdateBtnTag)
                    { Text = "更新", Type = TTypeMini.Primary, IconSvg = "EditOutlined" },
                new CellButton(AppConstant.DeleteBtnTag)
                    { Text = "删除", Type = TTypeMini.Error, IconSvg = "ClearOutlined" }
            };
        }
        private string _bookId;

        public string BookId
        {
            get => _bookId;
            set
            {
                _bookId = value;
                OnPropertyChanged();
            }
        }

        private String _name;

        public String Name
        {
            get => $"《{_name}》";
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public String NameSource => _name;

        private string _author;

        public string Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged();
            }
        }

        private string _press;

        public string Press
        {
            get => _press;
            set
            {
                _press = value;
                OnPropertyChanged();
            }
        }

        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        
        private CellBadge _status;

        public CellBadge Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }

        public int StatusSource
        {
            get; private set;
        }
        
        private CellLink[] _operationBtns;

        public CellLink[] OperationBtns
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