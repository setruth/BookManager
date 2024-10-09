using System.Collections.Generic;
using System.Data.SqlClient;
using BookManager.DB.Entity;
using BookManager.Model;
using BookManager.Page.Frame.ChildPage.Book.Model;
using BookManager.Util;

namespace BookManager.DB.Repository
{
    public class BookInfoRepository
    {
        private const string TableName = "book_info";
        private static BookInfoRepository? _instance;
        private static readonly object LockObj = new object();
        private readonly SqlServerHelper _sqlHelper;

        private BookInfoRepository(string connectionString)
        {
            _sqlHelper = SqlServerHelper.InitInstance(connectionString);
        }

        /// <summary>
        /// 获取 repository 单例
        /// </summary>
        /// <returns></returns>
        public static BookInfoRepository GetRep()
        {
            if (_instance != null) return _instance;
            lock (LockObj)
            {
                _instance ??= new BookInfoRepository(AppConstant.SqlServerConnectInfo);
            }

            return _instance;
        }

        /// <summary>
        /// 新增书籍信息
        /// </summary>
        /// <param name="bookInfo">书籍信息对象</param>
        /// <returns>返回一个SQLRes对象，包含插入结果</returns>
        public SQLRes<bool> AddBookInfo(BookInfo bookInfo)
        {
            var sql = $"INSERT INTO {TableName} (bookId, name, author, press, price, status) " +
                      $"VALUES (@bookId, @name, @author, @press, @price, @status)";
            var parameters = new[]
            {
                new SqlParameter("@bookId", IdGenerator.GenerateId()),
                new SqlParameter("@name", bookInfo.Name),
                new SqlParameter("@author", bookInfo.Author),
                new SqlParameter("@press", bookInfo.Press),
                new SqlParameter("@price", bookInfo.Price),
                new SqlParameter("@status", bookInfo.Status)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) >= 0
                ? new SQLRes<bool>("添加成功", true)
                : new SQLRes<bool>("添加失败，SQL未生效", false);
        }

        /// <summary>
        /// 删除书籍信息
        /// </summary>
        /// <param name="bookId">书籍ID</param>
        /// <returns>返回一个SQLRes对象，包含删除结果</returns>
        public SQLRes<bool> DeleteBookInfo(string bookId)
        {
            var sql = $"DELETE FROM {TableName} WHERE bookId = @bookId";
            var parameters = new[]
            {
                new SqlParameter("@bookId", bookId)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("删除成功", true)
                : new SQLRes<bool>("删除失败，未找到匹配的记录", false);
        }

        /// <summary>
        /// 更新书籍信息
        /// </summary>
        /// <param name="updateInfo">书籍信息对象</param>
        /// <returns>返回一个SQLRes对象，包含更新结果</returns>
        public SQLRes<bool> UpdateBookInfo(BookInfo updateInfo)
        {
            var sql = $"UPDATE {TableName} SET name = @name, author = @author, press = @press, " +
                      $"price = @price, status = @status WHERE bookId = @bookId";
            var parameters = new[]
            {
                new SqlParameter("@bookId", updateInfo.BookId),
                new SqlParameter("@name", updateInfo.Name),
                new SqlParameter("@author", updateInfo.Author),
                new SqlParameter("@press", updateInfo.Press),
                new SqlParameter("@price", updateInfo.Price),
                new SqlParameter("@status", updateInfo.Status)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("更新成功", true)
                : new SQLRes<bool>("更新失败，未找到匹配的记录", false);
        }

        /// <summary>
        /// 获取所有书籍信息
        /// </summary>
        /// <returns>返回一个SQLRes对象，包含书籍信息列表</returns>
        public SQLRes<List<BookInfoEntity>> GetBookInfoList()
        {
            var sql = $"SELECT * FROM {TableName}";
            return new SQLRes<List<BookInfoEntity>>("获取成功",
                SqlServerUtil.ConvertDataTableToList<BookInfoEntity>(_sqlHelper.ExecuteQuery(sql)));
        }

        /// <summary>
        /// 检查是否存在重复的书籍信息
        /// </summary>
        /// <param name="bookName">书籍名称</param>
        /// <param name="author">作者</param>
        /// <param name="press">出版社</param>
        /// <returns>如果存在重复的书籍信息，则返回true；否则返回false</returns>
        public SQLRes<bool> HasRepeatBookInfo(string bookName, string author, string press)
        {
            var sql = $"SELECT * FROM {TableName} WHERE name = @name AND author = @author AND press = @press";

            var parameters = new[]
            {
                new SqlParameter("@name", bookName),
                new SqlParameter("@author", author),
                new SqlParameter("@press", press)
            };

            return _sqlHelper.ExecuteQuery(sql, parameters).Rows.Count > 0
                ? new SQLRes<bool>($@"有重复的书籍 名字:{bookName} 作者:{author} 出版社:{press}", true)
                : new SQLRes<bool>("没有重复的书籍", false);
        }
        /// <summary>
        /// 修改图书状态
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="status">1 在库 0借出</param>
        /// <returns></returns>
        public SQLRes<bool> ChangeBookStatus(string bookId, int status)
        {
            var sql = $"UPDATE {TableName} SET status = @status WHERE bookId = @bookId";
            var parameters = new[]
            {
                new SqlParameter("@bookId", bookId),
                new SqlParameter("@status", status),
            };
            return _sqlHelper.ExecuteNonQuery(sql, parameters) < 0 ? new SQLRes<bool>("修改失败，SQL未生效", false) : new SQLRes<bool>("修改成功", true);
        }
    }
}