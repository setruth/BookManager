namespace BookManager.DB.Entity
{
    public class BookInfoEntity
    {
        public string BookId { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Press { get; set; }

        public decimal Price { get; set; }

        public int Status { get; set; }
    }

}