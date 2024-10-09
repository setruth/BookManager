using System;

namespace BookManager.Page.Frame.ChildPage.Borrow.Model
{
    public class BorrowInfo
    {
        public BorrowInfo(string readerId, string bookId, DateTime borrowDate, DateTime borrowOverDate,BorrowEntityStatus entityStatus)
        {
            ReaderId = readerId;
            BookId = bookId;
            BorrowDate = borrowDate;
            BorrowOverDate = borrowOverDate;
            EntityStatus = entityStatus;
        }

        public string ReaderId { get; set; }
        public string BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime BorrowOverDate { get; set; }
        public BorrowEntityStatus EntityStatus { get; set; }
    }
}