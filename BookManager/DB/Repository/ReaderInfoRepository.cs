using BookManager.DB.Entity;
using BookManager.Model;
using BookManager.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BookManager.Page.Frame.ChildPage.Reader.Model;
using BookManager.Page.Frame.ChildPage.ReaderType.Model;

namespace BookManager.DB.Repository
{
    public class ReaderInfoRepository
    {
        private const string TableName = "reader_info";
        private static ReaderInfoRepository? _instance;
        private static readonly object LockObj = new object();
        private readonly SqlServerHelper _sqlHelper;

        private ReaderInfoRepository(string connectionString)
        {
            _sqlHelper = SqlServerHelper.InitInstance(connectionString);
        }

        /// <summary>
        /// 获取repository单例
        /// </summary>
        /// <returns></returns>
        public static ReaderInfoRepository GetRep()
        {
            if (_instance != null) return _instance;
            lock (LockObj)
            {
                _instance ??= new ReaderInfoRepository(AppConstant.SqlServerConnectInfo);
            }

            return _instance;
        }

        /// <summary>
        /// 新增阅读者信息
        /// </summary>
        /// <param name="readerInfo">阅读者信息对象</param>
        /// <returns>返回一个SQLRes对象，包含插入结果</returns>
        public SQLRes<bool> AddReaderInfo(ReaderInfo readerInfo)
        {
            var sql = $"INSERT INTO {TableName} (readerId, typeId, name, department, qq, alreadyBorrow) " +
                      $"VALUES (@readerId, @typeId, @name, @department, @qq, @alreadyBorrow)";
            var parameters = new[]
            {
                new SqlParameter("@readerId", IdGenerator.GenerateId()),
                new SqlParameter("@typeId", readerInfo.TypeId),
                new SqlParameter("@name", readerInfo.Name),
                new SqlParameter("@department", readerInfo.Department),
                new SqlParameter("@qq", readerInfo.QQ),
                new SqlParameter("@alreadyBorrow", readerInfo.AlreadyBorrow)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) >= 0
                ? new SQLRes<bool>("添加成功", true)
                : new SQLRes<bool>("添加失败，SQL未生效", false);
        }

        /// <summary>
        /// 删除阅读者信息
        /// </summary>
        /// <param name="readerId">阅读者ID</param>
        /// <returns>返回一个SQLRes对象，包含删除结果</returns>
        public SQLRes<bool> DeleteReaderInfo(string readerId)
        {
            var sql = $"DELETE FROM {TableName} WHERE readerId = @readerId";
            var parameters = new[]
            {
                new SqlParameter("@readerId", readerId)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("删除成功", true)
                : new SQLRes<bool>("删除失败，未找到匹配的记录", false);
        }

        /// <summary>
        /// 更新阅读者信息
        /// </summary>
        /// <param name="updateInfo">阅读者信息对象</param>
        /// <returns>返回一个SQLRes对象，包含更新结果</returns>
        public SQLRes<bool> UpdateReaderInfo(ReaderInfo updateInfo)
        {
            var sql = $"UPDATE {TableName} SET typeId = @typeId, name = @name, department = @department, " +
                      $"qq = @qq, alreadyBorrow = @alreadyBorrow WHERE readerId = @readerId";
            var parameters = new[]
            {
                new SqlParameter("@readerId", updateInfo.ReaderId),
                new SqlParameter("@typeId", updateInfo.TypeId),
                new SqlParameter("@name", updateInfo.Name),
                new SqlParameter("@department", updateInfo.Department),
                new SqlParameter("@qq", updateInfo.QQ),
                new SqlParameter("@alreadyBorrow", updateInfo.AlreadyBorrow)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("更新成功", true)
                : new SQLRes<bool>("更新失败，未找到匹配的记录", false);
        }

        /// <summary>
        /// 获取所有阅读者信息
        /// </summary>
        /// <returns>返回一个SQLRes对象，包含阅读者信息列表</returns>
        public SQLRes<List<ReaderInfoEntity>> GetReaderInfoList()
        {
            var sql = $"SELECT * FROM {TableName}";
            return new SQLRes<List<ReaderInfoEntity>>("获取成功",
                SqlServerUtil.ConvertDataTableToList<ReaderInfoEntity>(_sqlHelper.ExecuteQuery(sql)));
        }

        /// <summary>
        /// 检查是否存在重复的读者信息
        /// </summary>
        /// <param name="readerName">读者姓名</param>
        /// <param name="department">所属部门</param>
        /// <param name="qq">QQ号码</param>
        /// <returns>如果存在重复的读者信息，则返回true；否则返回false</returns>
        public SQLRes<bool> HasRepeatReaderInfo(string readerName, string department, string qq)
        {
            // 构造SQL查询语句，根据姓名、部门和QQ号码查询读者信息
            var sql = $"SELECT * FROM {TableName} where name = @name AND  department = @department AND  qq = @qq";

            // 定义SQL参数，避免SQL注入
            var parameters = new[]
            {
                new SqlParameter("@name", readerName),
                new SqlParameter("@department", readerName),
                new SqlParameter("@qq", qq),
            };

            // 执行SQL查询，并判断查询结果的行数是否大于0，以确定是否存在重复的读者信息
            return _sqlHelper.ExecuteQuery(sql, parameters).Rows.Count > 0 ? new SQLRes<bool>($@"有重复的用户 名字:{readerName} 部门:{department} QQ:{qq}", true) : new SQLRes<bool>("没重复的用户", false);
        }

        public SQLRes<bool> hasBindingType(int typeId)
        {
            var sql = $"SELECT * FROM {TableName} where typeId = @typeId";
            var parameters = new[]
            {
                new SqlParameter("@typeId", typeId)
            };
            return _sqlHelper.ExecuteQuery(sql, parameters).Rows.Count > 0 ? new SQLRes<bool>("该类型已绑定用户", true) : new SQLRes<bool>("该类型未绑定用户", false);
        }
    }
}