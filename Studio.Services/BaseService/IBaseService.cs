using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Studio.Services.BaseService
{
    public interface IBaseService<out TEntity> where TEntity : class
    {
        int Create(string sqlQuery, DynamicParameters param, CommandType commandType);
        int Update(string sqlQuery, DynamicParameters param, CommandType commandType);
        int Delete(string sqlQuery, DynamicParameters param, CommandType commandType);
        TEntity GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType);
        IEnumerable<TEntity> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType);
    }
}
