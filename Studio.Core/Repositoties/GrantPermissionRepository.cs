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
    public interface IGrantPermissionRepository : IRepository<GrantPermission>
    {
        
    }
    public class GrantPermissionRepository : BaseRepository<GrantPermission>,IGrantPermissionRepository
    {
        public GrantPermissionRepository(IConnectionFactory connectionFactory, IUnitOfWork unitOfWork) : base(connectionFactory, unitOfWork)
        {
        }
    }
}
