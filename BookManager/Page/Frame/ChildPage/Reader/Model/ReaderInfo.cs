namespace BookManager.Page.Frame.ChildPage.Reader.Model
{
    public class ReaderInfo
    {
        public ReaderInfo(string? readerId, int typeId, string name, string department, string qq, int alreadyBorrow)
        {
            ReaderId = readerId;
            TypeId = typeId;
            Name = name;
            Department = department;
            QQ = qq;
            AlreadyBorrow = alreadyBorrow;
        }

        public string? ReaderId { get; set; }  
        public int TypeId { get; set; }  
        public string Name { get; set; }  
        public string Department { get; set; }  
        public string QQ { get; set; }  
        public int AlreadyBorrow { get; set; }  
    }
}