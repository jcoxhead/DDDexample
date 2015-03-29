namespace Alterax.DDD.EventStore
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}