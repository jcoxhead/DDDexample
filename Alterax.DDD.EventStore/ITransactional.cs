namespace Alterax.DDD.EventStore
{
    public interface ITransactional
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}