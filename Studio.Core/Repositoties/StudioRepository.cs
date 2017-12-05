using Studio.Core.BaseRepository;
using Studio.Core.Infrastructure;

namespace Studio.Core.Repositoties
{
    public interface IStudioRepository : IRepository<Entities.Studio>
    {
        
    }
    public class StudioRepository : BaseRepository<Entities.Studio>,IStudioRepository
    {
        public StudioRepository(IConnectionFactory connectionFactory, IUnitOfWork unitOfWork) : base(connectionFactory, unitOfWork)
        {
        }
    }
}
