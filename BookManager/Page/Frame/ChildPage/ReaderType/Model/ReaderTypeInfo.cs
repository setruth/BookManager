namespace BookManager.Page.Frame.ChildPage.ReaderType.Model
{
    // 用于逻辑层传递的类型信息
    public class ReaderTypeInfo
    {
        public ReaderTypeInfo(int? typeId, string typeName, int borrowDay, int borrowNumber)
        {
            TypeId = typeId;
            TypeName = typeName;
            BorrowDay = borrowDay;
            BorrowNumber = borrowNumber;
        }
        //id可能为空 比如upsert窗口中 如果返回的信息中的id是空的 证明是新增的而不是更新信息
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public int BorrowDay { get; set; }
        public int BorrowNumber { get; set; }
    }
}