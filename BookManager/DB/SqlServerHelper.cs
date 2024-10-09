using System;
using System.Data;
using System.Data.SqlClient;

namespace BookManager.DB
{
    public class SqlServerHelper
    {
        private static SqlServerHelper? _instance;
        private static readonly object LockObj = new object();
        private readonly SqlConnection _connection;

        private SqlServerHelper(string connectionInfo)
        {
            _connection = new SqlConnection(connectionInfo);
        }

        public static SqlServerHelper InitInstance(string connectionString)
        {
            if (_instance != null) return _instance;
            lock (LockObj)
            {
                _instance ??= new SqlServerHelper(connectionString);
            }

            return _instance;
        }

        public static SqlServerHelper? GetInstance()
        {
            return _instance;
        }

        public bool GetConnectionStatus()
        {
            try
            {
                _connection.Open();
                return _connection.State == System.Data.ConnectionState.Open;
            }
            catch (Exception e)
            {
                Console.WriteLine($@"数据库连接失败: {e.Message}");
                return false;
            }
            finally
            {
                // 确保连接在检查后关闭
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

        /// <summary>
        /// 查询执行
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameter"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql, SqlParameter[]? sqlParameter = null)
        {
            var resultTable = new DataTable();

            using var sqlCommand = new SqlCommand(sql, _connection);

            if (sqlParameter != null)
            {
                sqlCommand.Parameters.AddRange(sqlParameter);
            }

            using var sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(resultTable);

            return resultTable;
        }

        /// <summary>
        /// 执行插入、更新、删除操作
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="sqlParameter">SQL参数</param>
        /// <returns>返回受影响的行数</returns>
        public int ExecuteNonQuery(string sql, SqlParameter[]? sqlParameter = null)
        {
            using var sqlCommand = new SqlCommand(sql, _connection);

            if (sqlParameter != null)
            {
                sqlCommand.Parameters.AddRange(sqlParameter);
            }

            _connection.Open();
            var rowsAffected = sqlCommand.ExecuteNonQuery();
            _connection.Close();

            return rowsAffected;
        }
    }
}