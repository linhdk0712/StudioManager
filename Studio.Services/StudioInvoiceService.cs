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
    public interface IStudioInvoiceService : IBaseService<StudioInvoice>
    {
        
    }
    public class StudioInvoiceService : IStudioInvoiceService
    {
        private readonly IStudioInvoiceRepository _studioInvoiceRepository;
        public StudioInvoiceService(IStudioInvoiceRepository studioInvoiceRepository)
        {
            _studioInvoiceRepository = studioInvoiceRepository;
        }
        public int Create(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioInvoiceRepository.Create(sqlQuery, param, commandType);
        }

        public int Update(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioInvoiceRepository.Update(sqlQuery, param, commandType);
        }

        public int Delete(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioInvoiceRepository.Delete(sqlQuery, param, commandType);
        }

        public StudioInvoice GetEntity(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioInvoiceRepository.GetEntity(sqlQuery, param, commandType);
        }

        public IEnumerable<StudioInvoice> GetAllEntities(string sqlQuery, DynamicParameters param, CommandType commandType)
        {
            return _studioInvoiceRepository.GetAllEntities(sqlQuery, param, commandType);
        }
    }
}
