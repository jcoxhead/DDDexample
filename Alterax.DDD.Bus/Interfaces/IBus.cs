namespace Alterax.DDD.Bus.Interfaces
{
    using System.Collections.Generic;

    public interface IBus : IUnitOfWork
    {
        void Publish(object message);
        void Publish(IEnumerable<object> messages);
    }
}