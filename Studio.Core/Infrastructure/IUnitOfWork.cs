namespace Studio.Core.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
