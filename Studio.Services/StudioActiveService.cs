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
    public interface IStudioActiveService : IBaseService<StudioActive>
    {
        
    }
    public class StudioActiveService : IStudioActiveService
    {
        private readonly IStudioActiveRepository _studioActiveRepository;
        public StudioActiveService(IStudioActiveRepository studioActiveRepository)
        {
            _studioActiveRepository = studioActiveRepository;
        }
        public int Create(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioActiveRepository.Create(sqlQuery, param, commandType);
        }

        public int Update(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioActiveRepository.Update(sqlQuery, param, commandType);
        }

        public int Delete(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioActiveRepository.Delete(sqlQuery, param, commandType);
        }

        public StudioActive GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioActiveRepository.GetEntity(sqlQuery, param, commandType);
        }

        public IEnumerable<StudioActive> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioActiveRepository.GetAllEntities(sqlQuery, param, commandType);
        }
    }
}
