using Dapper;
using Studio.Core.Repositoties;
using Studio.Services.BaseService;
using System.Collections.Generic;
using System.Data;

namespace Studio.Services
{
    public interface IStudioService : IBaseService<Entities.Studio>
    {
    }

    public class StudioService : IStudioService
    {
        private readonly IStudioRepository _studioRepository;

        public StudioService(IStudioRepository studioRepository)
        {
            _studioRepository = studioRepository;
        }

        //TODO : Thêm mới bản ghi vào cơ sở dữ liệu
        public int Create(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioRepository.Create(sqlQuery, param, commandType);
        }

        //TODO : Cập nhật thông tin bản ghi
        public int Update(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioRepository.Update(sqlQuery, param, commandType);
        }

        //TODO : Xóa thông tin bản ghi
        public int Delete(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioRepository.Delete(sqlQuery, param, commandType);
        }

        //TODO: Truy vấn thông tin một bản ghi
        public Entities.Studio GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioRepository.GetEntity(sqlQuery, param, commandType);
        }

        //TODO: Truy vấn danh sách thông tin các bản ghi
        public IEnumerable<Entities.Studio> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioRepository.GetAllEntities(sqlQuery, param, commandType);
        }
    }
}