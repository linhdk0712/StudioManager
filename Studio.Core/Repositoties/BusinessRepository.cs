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
    public interface IBusinessRepository : IRepository<Business>
    {
        
    }
    public class BusinessRepository : BaseRepository<Business>,IBusinessRepository
    {
        public BusinessRepository(IConnectionFactory connectionFactory, IUnitOfWork unitOfWork) : base(connectionFactory, unitOfWork)
        {
        }
    }
}
