using System;

namespace BookManager.DB.Entity
{
    public class BorrowInfoEntity
    {
        public string ReaderId { get; set; }
        public string BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime BorrowOverDate { get; set; }
        // 1是已经还了 0是还未还 -1是超时
        public int Status { get; set; }
    }
}