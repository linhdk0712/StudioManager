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
    public interface IStudioUserService : IBaseService<StudioUser>
    {
        
    }
    public class StudioUserService : IStudioUserService
    {
        private readonly IStudioUserRepository _studioUserRepository;
        public StudioUserService(IStudioUserRepository studioUserRepository)
        {
            _studioUserRepository = studioUserRepository;
        }
        public int Create(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioUserRepository.Create(sqlQuery, param, commandType);
        }

        public int Update(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioUserRepository.Update(sqlQuery, param, commandType);
        }

        public int Delete(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioUserRepository.Delete(sqlQuery, param, commandType);
        }

        public StudioUser GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioUserRepository.GetEntity(sqlQuery, param, commandType);
        }

        public IEnumerable<StudioUser> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioUserRepository.GetAllEntities(sqlQuery, param, commandType);
        }
    }
}
