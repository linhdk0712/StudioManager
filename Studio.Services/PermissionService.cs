using Dapper;
using Studio.Core.Repositoties;
using Studio.Entities;
using Studio.Services.BaseService;
using System.Collections.Generic;
using System.Data;

namespace Studio.Services
{
    public interface IPermissionService : IBaseService<Permission>
    {
    }

    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        public int Create(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _permissionRepository.Create(sqlQuery, param, commandType);
        }

        public int Update(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _permissionRepository.Update(sqlQuery, param, commandType);
        }

        public int Delete(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _permissionRepository.Delete(sqlQuery, param, commandType);
        }

        public Permission GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _permissionRepository.GetEntity(sqlQuery, param, commandType);
        }

        public IEnumerable<Permission> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _permissionRepository.GetAllEntities(sqlQuery, param, commandType);
        }
    }
}