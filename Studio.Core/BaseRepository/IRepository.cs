using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Studio.Core.BaseRepository
{
    public interface IRepository<out TEntity> where TEntity : class
    {
        int Create(string sqlQuery,DynamicParameters param,CommandType commandType);
        int Update(string sqlQuery, DynamicParameters param, CommandType commandType);
        int Delete(string sqlQuery, DynamicParameters param, CommandType commandType);
        TEntity GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType);
        IEnumerable<TEntity> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType);
    }
}
