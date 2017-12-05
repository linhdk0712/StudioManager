using System.Data;

namespace Studio.Core.Infrastructure
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
