namespace BookManager.DB.Entity
{
    public class LoginInfoEntity
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $"id:{Id} 账号:{Account} 密码:{Password}";
        }
    }
}