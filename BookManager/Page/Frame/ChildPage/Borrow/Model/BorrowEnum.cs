namespace BookManager.Page.Frame.ChildPage.Borrow.Model
{
    public enum BorrowEntityStatus
    {
        Already = 1,
        Await = 0,
    }
    public enum BorrowFilterType
    {
        All,
        Await,
        Already,
        Timeout,
    }
    public enum BorrowStatus
    {
        Await,
        Already,
        Timeout,
    }
}