using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Studio.Core.Repositoties;
using Studio.Entities;
using Studio.Services.BaseService;

namespace Studio.Services
{
    public interface IBusinessService : IBaseService<Business>
    {
        
    }

    public class BusinessService : IBusinessService

    {
        private readonly IBusinessRepository _businessRepository;
        public BusinessService(IBusinessRepository businessRepository)
        {
            _businessRepository = businessRepository;
        }
        public int Create(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _businessRepository.Create(sqlQuery, param, commandType);
        }

        public int Update(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _businessRepository.Update(sqlQuery, param, commandType);
        }

        public int Delete(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _businessRepository.Delete(sqlQuery, param, commandType);
        }

        public Business GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _businessRepository.GetEntity(sqlQuery, param, commandType);
        }

        public IEnumerable<Business> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _businessRepository.GetAllEntities(sqlQuery, param, commandType);
        }
    }
}
