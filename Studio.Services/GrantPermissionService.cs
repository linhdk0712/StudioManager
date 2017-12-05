using Dapper;
using Studio.Core.Repositoties;
using Studio.Entities;
using Studio.Services.BaseService;
using System.Collections.Generic;
using System.Data;

namespace Studio.Services
{
    public interface IGrantPermissionService : IBaseService<GrantPermission>
    {
    }

    public class GrantPermissionService : IGrantPermissionService
    {
        private readonly IGrantPermissionRepository _grantPermissionRepository;

        public GrantPermissionService(IGrantPermissionRepository grantPermissionRepository)
        {
            _grantPermissionRepository = grantPermissionRepository;
        }

        public int Create(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _grantPermissionRepository.Create(sqlQuery, param, commandType);
        }

        public int Update(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _grantPermissionRepository.Update(sqlQuery, param, commandType);
        }

        public int Delete(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _grantPermissionRepository.Delete(sqlQuery, param, commandType);
        }

        public GrantPermission GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _grantPermissionRepository.GetEntity(sqlQuery, param, commandType);
        }

        public IEnumerable<GrantPermission> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _grantPermissionRepository.GetAllEntities(sqlQuery, param, commandType);
        }
    }
}