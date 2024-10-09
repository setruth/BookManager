namespace BookManager.Page.Frame.ChildPage.Book.Model
{
    public class BookInfo
    {
        public BookInfo(string? bookId, string name, string author, string press, decimal price, int status)
        {
            BookId = bookId;
            Name = name;
            Author = author;
            Press = press;
            Price = price;
            Status = status;
        }

        public string? BookId { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Press { get; set; }

        public decimal Price { get; set; }

        public int Status { get; set; }
    }
}