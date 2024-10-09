using System.Collections.Generic;
using System.Data.SqlClient;
using BookManager.DB.Entity;
using BookManager.Model;
using BookManager.Page.Frame.ChildPage.Borrow.Model;
using BookManager.Util;


namespace BookManager.DB.Repository
{
    public class BorrowInfoRepository
    {
        private const string TableName = "borrow_info";
        private static BorrowInfoRepository? _instance;
        private static readonly object LockObj = new object();
        private readonly SqlServerHelper _sqlHelper;

        private BorrowInfoRepository(string connectionString)
        {
            _sqlHelper = SqlServerHelper.InitInstance(connectionString);
        }

        /// <summary>
        /// 获取 repository 单例
        /// </summary>
        /// <returns></returns>
        public static BorrowInfoRepository GetRep()
        {
            if (_instance != null) return _instance;
            lock (LockObj)
            {
                _instance ??= new BorrowInfoRepository(AppConstant.SqlServerConnectInfo);
            }

            return _instance;
        }

        /// <summary>
        /// 新增借阅信息
        /// </summary>
        /// <param name="borrowInfo">借阅信息对象</param>
        /// <returns>返回一个SQLRes对象，包含插入结果</returns>
        public SQLRes<bool> AddBorrowInfo(BorrowInfo borrowInfo)
        {
            var sql = $"INSERT INTO {TableName} (readerId, bookId, borrowDate, borrowOverDate, status) " +
                      $"VALUES (@readerId, @bookId, @borrowDate, @borrowOverDate, @status)";
            var parameters = new[]
            {
                new SqlParameter("@readerId", borrowInfo.ReaderId),
                new SqlParameter("@bookId", borrowInfo.BookId),
                new SqlParameter("@borrowDate", borrowInfo.BorrowDate),
                new SqlParameter("@borrowOverDate", borrowInfo.BorrowOverDate),
                new SqlParameter("@status", (int)borrowInfo.EntityStatus)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) >= 0
                ? new SQLRes<bool>("添加成功", true)
                : new SQLRes<bool>("添加失败，SQL未生效", false);
        }

        /// <summary>
        /// 删除借阅信息
        /// </summary>
        /// <param name="readerId">读者ID</param>
        /// <param name="bookId">书籍ID</param>
        /// <returns>返回一个SQLRes对象，包含删除结果</returns>
        public SQLRes<bool> DeleteBorrowInfo(string readerId, string bookId)
        {
            var sql = $"DELETE FROM {TableName} WHERE readerId = @readerId AND bookId = @bookId";
            var parameters = new[]
            {
                new SqlParameter("@readerId", readerId),
                new SqlParameter("@bookId", bookId)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("删除成功", true)
                : new SQLRes<bool>("删除失败，未找到匹配的记录", false);
        }
        /// <summary>
        /// 删除借阅记录基于读者ID
        /// </summary>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public SQLRes<bool> DeleteBorrowInfoByReader(string readerId)
        {
            var sql = $"DELETE FROM {TableName} WHERE readerId = @readerId ";
            var parameters = new[]
            {
                new SqlParameter("@readerId", readerId),
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("删除成功", true)
                : new SQLRes<bool>("删除失败，未找到匹配的记录", false);
        }
        
        /// <summary>
        /// 删除借阅记录基于读者ID
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public SQLRes<bool> DeleteBorrowInfoByBook(string bookId)
        {
            var sql = $"DELETE FROM {TableName} WHERE bookId = @bookId ";
            var parameters = new[]
            {
                new SqlParameter("@bookId", bookId),
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("删除成功", true)
                : new SQLRes<bool>("删除失败，未找到匹配的记录", false);
        }

        /// <summary>
        /// 更新借阅状态
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="readerId"></param>
        /// <param name="newStatus"></param>
        /// <returns></returns>
        public SQLRes<bool> UpdateBorrowStatus(string bookId, string readerId, BorrowEntityStatus newStatus)
        {
            var sql = $"UPDATE {TableName} SET status = @status WHERE readerId = @readerId AND bookId = @bookId";
            var parameters = new[]
            {
                new SqlParameter("@status", (int)newStatus),
                new SqlParameter("@readerId", readerId),
                new SqlParameter("@bookId", bookId),
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("更新成功", true)
                : new SQLRes<bool>("更新失败，未找到匹配的记录", false);
        }

        /// <summary>
        /// 获取所有借阅信息
        /// </summary>
        /// <returns>返回一个SQLRes对象，包含借阅信息列表</returns>
        public SQLRes<List<BorrowInfoEntity>> GetBorrowInfoList()
        {
            var sql = $"SELECT * FROM {TableName}";
            return new SQLRes<List<BorrowInfoEntity>>("获取成功",
                SqlServerUtil.ConvertDataTableToList<BorrowInfoEntity>(_sqlHelper.ExecuteQuery(sql)));
        }

       /// <summary>
       /// 读者是否存在借阅记录
       /// </summary>
       /// <param name="readerId"></param>
       /// <returns></returns>
        public SQLRes<bool> ReaderHasBorrow(string readerId)
        {
            var sql = $"SELECT * FROM {TableName} WHERE readerId = @readerId AND status =@status";

            var parameters = new[]
            {
                new SqlParameter("@readerId", readerId),
                new SqlParameter("@status", BorrowEntityStatus.Await),
            };

            return _sqlHelper.ExecuteQuery(sql, parameters).Rows.Count > 0
                ? new SQLRes<bool>($@"有借阅记录", true)
                : new SQLRes<bool>("没有借阅记录", false);
        }
    }
}