namespace BookManager.DB.Entity
{
    public class ReaderTypeEntity
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int BorrowDay { get; set; }
        public int BorrowNumber { get; set; }
    }
}