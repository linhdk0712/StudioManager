using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio.Core.BaseRepository;
using Studio.Core.Infrastructure;
using Studio.Entities;

namespace Studio.Core.Repositoties
{
    public interface IStudioInvoiceRepository : IRepository<StudioInvoice>
    {
        
    }
    public class StudioInvoiceRepository : BaseRepository<StudioInvoice>,IStudioInvoiceRepository
    {
        public StudioInvoiceRepository(IConnectionFactory connectionFactory, IUnitOfWork unitOfWork) : base(connectionFactory, unitOfWork)
        {
        }
    }
}
