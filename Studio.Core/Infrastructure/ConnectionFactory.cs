using System.Data;
using System.Data.Common;
using System.Diagnostics;

namespace Studio.Core.Infrastructure
{
    public class ConnectionFactory : Disposable, IConnectionFactory
    {
#if DEBUG
        private readonly string _connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog =SocialGoal; User ID = m7-app; Password=123456;";
#else
         private readonly string _connectionString = "Data Source=118.70.185.190,1433;Initial Catalog =SocialGoal; User ID = linhdk0712; Password=213456789;" ;
#endif

        private IDbConnection _dbConnection;
        // TODO : Khởi tạo kết nối đến cơ sở dữ liệu
        public IDbConnection GetConnection()
        {
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            var conn = factory.CreateConnection();
            Debug.Assert(conn != null, nameof(conn) + " != null");
            conn.ConnectionString = _connectionString;
            conn.Open();
            return _dbConnection = conn;
        }

        protected override void DisposeCore()
        {
           _dbConnection?.Dispose();
        }
    }
}
