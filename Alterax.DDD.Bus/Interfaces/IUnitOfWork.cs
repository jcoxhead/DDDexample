namespace Alterax.DDD.Bus.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}