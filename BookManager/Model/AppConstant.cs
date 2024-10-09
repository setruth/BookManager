namespace BookManager.Model
{
    public class AppConstant
    {
        private static class DbConfig
        {
            public const string ConnectUrl = "localhost";
            public const string DataBase = "bookManager";
            public const string ConnectAct = "sa";
            public const string ConnectPwd = "071721";
        }

        public static string UpdateBtnTag = "updateBtn";
        public static string DeleteBtnTag = "deleteBtn";

        public static string SqlServerConnectInfo = $"Server={DbConfig.ConnectUrl};Database={DbConfig.DataBase};User Id={DbConfig.ConnectAct};Password={DbConfig.ConnectPwd};";
    }
}