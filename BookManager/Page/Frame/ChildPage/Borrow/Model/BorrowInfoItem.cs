using System;
using AntdUI;
using BookManager.DB.Entity;
using BookManager.Model;

namespace BookManager.Page.Frame.ChildPage.Borrow.Model
{
    public class BorrowInfoItem : NotifyProperty
    {
        public BorrowInfoItem(BorrowInfoEntity borrowInfoEntity, string readerName, string bookName)
        {
            ReaderId = borrowInfoEntity.ReaderId;
            BookId = borrowInfoEntity.BookId;
            _bookName = bookName;
            _readerName = readerName;
            _borrowOverDate = borrowInfoEntity.BorrowOverDate;
            _borrowDate = borrowInfoEntity.BorrowDate;
            var (status, statusEnum) = borrowInfoEntity.Status switch
            {
                (int)BorrowEntityStatus.Already => (new CellTag("已还", TTypeMini.Default), BorrowStatus.Already),
                (int)BorrowEntityStatus.Await => DateTime.Now > borrowInfoEntity.BorrowOverDate
                    ? (new CellTag("超时", TTypeMini.Error), BorrowStatus.Timeout)
                    : (new CellTag("待还", TTypeMini.Info), BorrowStatus.Await),

                _ => throw new Exception("未知状态")
            };
            _status = status;
            StatusEnum = statusEnum;
            _operationBtns = new CellLink[]
            {
                new CellButton(AppConstant.UpdateBtnTag)
                    { Text = "还书", Type = TTypeMini.Primary, IconSvg = "CloudUploadOutlined" ,Enabled = statusEnum!=BorrowStatus.Already},
                new CellButton(AppConstant.DeleteBtnTag)
                    { Text = "删除", Type = TTypeMini.Error, IconSvg = "DeleteOutlined",Enabled = statusEnum==BorrowStatus.Already },
            };
        }

        public BorrowStatus StatusEnum;
        public string ReaderId;
        public string BookId;
        private string _readerName;

        public string ReaderName
        {
            get => _readerName;
            set
            {
                _readerName = value;
                OnPropertyChanged();
            }
        }

        private DateTime _borrowDate;

        public DateTime BorrowDate
        {
            get => _borrowDate;
            set
            {
                _borrowDate = value;
                OnPropertyChanged();
            }
        }

        private DateTime _borrowOverDate;

        public DateTime BorrowOverDate
        {
            get => _borrowOverDate;
            set
            {
                _borrowOverDate = value;
                OnPropertyChanged();
            }
        }

        private string _bookName;

        public string BookName
        {
            get => $"《{_bookName}》";
            set
            {
                _bookName = value;
                OnPropertyChanged();
            }
        }

        private CellTag _status;

        public CellTag Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
            }
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

        public override string ToString()
        {
            return $"读者{ReaderName}在${BorrowDate}借阅书籍{BookName}，应于{BorrowOverDate}前归还";
        }
    }
}