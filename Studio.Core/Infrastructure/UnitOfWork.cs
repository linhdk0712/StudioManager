namespace Studio.Core.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IConnectionFactory _connectionFactory;

        public UnitOfWork(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        // TODO : Đóng và giải phóng kết nối đến cơ sở dữ liệu
        public void Commit()
        {
           _connectionFactory.GetConnection().Close();
            _connectionFactory.GetConnection().Dispose();
        }
    }
}
