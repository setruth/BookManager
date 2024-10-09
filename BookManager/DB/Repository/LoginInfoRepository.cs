using BookManager.DB.Entity;
using BookManager.Model;
using BookManager.Util;
using System;
using System.Data.SqlClient;

namespace BookManager.DB.Repository
{
    public class LoginInfoRepository
    {
        private const string TableName = "login_info";
        private static LoginInfoRepository? _instance;
        private static readonly object LockObj = new object();
        private readonly SqlServerHelper _sqlHelper;

        private LoginInfoRepository(string connectionString)
        {
            _sqlHelper = SqlServerHelper.InitInstance(connectionString);
        }

        /// <summary>
        /// 获取repository单例
        /// </summary>
        /// <returns></returns>
        public static LoginInfoRepository GetRep()
        {
            if (_instance != null) return _instance;
            lock (LockObj)
            {
                _instance ??= new LoginInfoRepository(AppConstant.SqlServerConnectInfo);
            }

            return _instance;
        }

        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="act">用户账号</param>
        /// <param name="pwd">用户密码</param>
        /// <returns>返回一个SQLRes对象，包含注册结果（true为成功，false为失败）和相关提示信息</returns>
        public SQLRes<bool> Register(string act, string pwd)
        {
            var sql = $"INSERT INTO {TableName} (account,password) VALUES (@act, @pwd)";
            var parameters = new[]
            {
                new SqlParameter("@act", act),
                new SqlParameter("@pwd", pwd)
            };
            return _sqlHelper.ExecuteNonQuery(sql, parameters) >= 0
                ? new SQLRes<bool>("注册成功", true)
                : new SQLRes<bool>("注册失败，SQL未生效", false);
        }

        /// <summary>
        /// 获取登录信息
        /// </summary>
        /// <param name="act">登录账号</param>
        /// <returns>返回一个包含登录信息的SQLRes对象，不存在则为null</returns>
        /// <exception cref="Exception">如果存在多个重复的账号将抛出异常.</exception>
        public SQLRes<LoginInfoEntity?> GetLoginInfo(string act)
        {
            var sql = $"select * from {TableName} where account = @act";

            var parameters = new[]
            {
                new SqlParameter("@act", act)
            };

            var dataTable = _sqlHelper.ExecuteQuery(sql, parameters);
            return dataTable.Rows.Count switch
            {
                1 => new SQLRes<LoginInfoEntity?>("账号存在",
                    SqlServerUtil.ConvertDataTableToList<LoginInfoEntity>(dataTable)[0]),
                0 => new SQLRes<LoginInfoEntity?>("账号不存在", null),
                _ => throw new Exception("有多个重复的账号，账号应该是唯一的")
            };
        }

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="act">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns>true：登录成功 false：登录失败</returns>
        public SQLRes<bool> Login(string act, string pwd)
        {
            try
            {
                var (msg, data) = GetLoginInfo(act);
                if (data == null)
                {
                    return new SQLRes<bool>("账号不存在", false);
                }

                return data?.Password == pwd
                    ? new SQLRes<bool>("密码正确", true)
                    : new SQLRes<bool>("密码错误", false);
            }
            catch (Exception e)
            {
                return new SQLRes<bool>($"获取登录信息异常{e.Message}", false);
            }
        }

        /// <summary>
        /// 获取所有的记录条数
        /// </summary>
        /// <returns></returns>
        private int GetCountRecord()
        {
            var sql = $"SELECT * FROM  {TableName}";
            var dataTable = _sqlHelper.ExecuteQuery(sql);
            return dataTable.Rows.Count;
        }
    }
}