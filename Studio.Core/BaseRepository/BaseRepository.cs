using System.Collections.Generic;
using System.Data;
using Dapper;
using Studio.Core.Infrastructure;

namespace Studio.Core.BaseRepository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly IUnitOfWork _unitOfWork;
        public BaseRepository(IConnectionFactory connectionFactory, IUnitOfWork unitOfWork)
        {
            _connectionFactory = connectionFactory;
            _unitOfWork = unitOfWork;
        }
        //TODO : Thêm mới bản ghi vào cơ sở dữ liệu
        public int Create(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                var affectedRows = connection.Execute(sqlQuery, param, commandTimeout: 1800, commandType: commandType);
                _unitOfWork.Commit();
                return affectedRows;
            }
        }
        //TODO : Cập nhật thông tin bản ghi
        public int Update(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                var affectedRows = connection.Execute(sqlQuery, param, commandTimeout: 1800, commandType: commandType);
                _unitOfWork.Commit();
                return affectedRows;
            }
        }
        //TODO : Xóa thông tin bản ghi
        public int Delete(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                var affectedRows = connection.Execute(sqlQuery, param, commandTimeout: 1800, commandType: commandType);
                _unitOfWork.Commit();
                return affectedRows;
            }
        }
        //TODO: Truy vấn thông tin một bản ghi
        public TEntity GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                var result = connection.QueryFirstOrDefault<TEntity>(sqlQuery, param, commandTimeout: 1800, commandType: commandType);
                _unitOfWork.Commit();
                return  result;
            }
        }
        //TODO: Truy vấn danh sách thông tin các bản ghi
        public IEnumerable<TEntity> GetAllEntities(string sqlQuery, DynamicParameters param,CommandType commandType)
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                var result = connection.Query<TEntity>(sqlQuery,param,commandTimeout:1800,commandType:commandType);
               _unitOfWork.Commit();
                return  result;
            }
        }
    }
}
