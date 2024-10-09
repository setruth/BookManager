namespace BookManager.DB.Entity
{
    public class ReaderInfoEntity
    {
        public string ReaderId { get; set; }  
        public int TypeId { get; set; }  
        public string Name { get; set; }  
        public string Department { get; set; }  
        public string QQ { get; set; }  
        public int AlreadyBorrow { get; set; }
        public override string ToString()
        {
            return $"读者名字：{Name} 部门：{Department} QQ：{QQ} 读者Id ：{ReaderId} 类型Id ：{TypeId} 已借书：{AlreadyBorrow}";
        }
    }
}