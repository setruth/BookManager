using BookManager.DB.Entity;
using BookManager.Model;
using BookManager.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using BookManager.Page.Frame.ChildPage.ReaderType.Model;

namespace BookManager.DB.Repository
{
    public class ReaderTypeRepository
    {
        private const string TableName = "reader_type";
        private static ReaderTypeRepository? _instance;
        private static readonly object LockObj = new object();
        private readonly SqlServerHelper _sqlHelper;

        private ReaderTypeRepository(string connectionString)
        {
            _sqlHelper = SqlServerHelper.InitInstance(connectionString);
        }

        /// <summary>
        /// 获取repository单例
        /// </summary>
        /// <returns></returns>
        public static ReaderTypeRepository GetRep()
        {
            if (_instance != null) return _instance;
            lock (LockObj)
            {
                _instance ??= new ReaderTypeRepository(AppConstant.SqlServerConnectInfo);
            }

            return _instance;
        }

        /// <summary>
        /// 新增阅读者类型
        /// </summary>
        /// <param name="typeName">类型名称</param>
        /// <param name="borrowDay">借阅天数</param>
        /// <param name="borrowNumber">借阅数量</param>
        /// <returns>返回一个SQLRes对象，包含插入结果</returns>
        public SQLRes<bool> AddReaderType(string typeName, int borrowDay, int borrowNumber)
        {
            var sql =
                $"INSERT INTO {TableName} (typeName, borrowDay, borrowNumber) VALUES (@typeName, @borrowDay, @borrowNumber)";
            var parameters = new[]
            {
                new SqlParameter("@typeName", typeName),
                new SqlParameter("@borrowDay", borrowDay),
                new SqlParameter("@borrowNumber", borrowNumber)
            };
            return _sqlHelper.ExecuteNonQuery(sql, parameters) >= 0
                ? new SQLRes<bool>("添加成功", true)
                : new SQLRes<bool>("添加失败，SQL未生效", false);
        }

        /// <summary>
        /// 删除阅读者类型
        /// </summary>
        /// <param name="typeId">类型ID</param>
        /// <returns>返回一个SQLRes对象，包含删除结果</returns>
        public SQLRes<bool> DeleteReaderType(int typeId)
        {
            var sql = $"DELETE FROM {TableName} WHERE typeId = @typeId";
            var parameters = new[]
            {
                new SqlParameter("@typeId", typeId)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("删除成功", true)
                : new SQLRes<bool>("删除失败，未找到匹配的记录", false);
        }

        /// <summary>
        /// 更新阅读者类型
        /// </summary>
        /// <param name="updateInfo">类型ID</param>
        /// <returns>返回一个SQLRes对象，包含更新结果</returns>
        public SQLRes<bool> UpdateReaderType(ReaderTypeInfo updateInfo)
        {
            var sql =
                $"UPDATE {TableName} SET typeName = @typeName, borrowDay = @borrowDay, borrowNumber = @borrowNumber WHERE typeId = @typeId";
            var parameters = new[]
            {
                new SqlParameter("@typeId", updateInfo.TypeId),
                new SqlParameter("@typeName", updateInfo.TypeName),
                new SqlParameter("@borrowDay", updateInfo.BorrowDay),
                new SqlParameter("@borrowNumber", updateInfo.BorrowNumber)
            };

            return _sqlHelper.ExecuteNonQuery(sql, parameters) > 0
                ? new SQLRes<bool>("更新成功", true)
                : new SQLRes<bool>("更新失败，未找到匹配的记录", false);
        }

        public SQLRes<ReaderTypeEntity?> GetReaderType(int typeId)
        {
            var sql = $"SELECT * FROM {TableName} WHERE typeId = @typeId";
            var parameters = new[]
            {
                new SqlParameter("@typeId", typeId)
            };
            var dataTable = _sqlHelper.ExecuteQuery(sql, parameters);
            return dataTable.Rows.Count == 0
                ? new SQLRes<ReaderTypeEntity?>("未找到匹配的记录", null)
                : new SQLRes<ReaderTypeEntity?>("获取成功",
                    SqlServerUtil.ConvertDataTableToList<ReaderTypeEntity>(dataTable).FirstOrDefault());
        }

        public SQLRes<List<ReaderTypeEntity>> GetReaderTypeList()
        {
            var sql = $"SELECT * FROM {TableName}";
            return new SQLRes<List<ReaderTypeEntity>>("获取成功",
                SqlServerUtil.ConvertDataTableToList<ReaderTypeEntity>(_sqlHelper.ExecuteQuery(sql)));
        }
    }
}