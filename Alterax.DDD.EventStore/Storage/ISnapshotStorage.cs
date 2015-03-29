using System;

namespace Fohjin.DDD.EventStore.Storage
{
    using Alterax.DDD.EventStore;
    using Alterax.DDD.EventStore.Storage;

    public interface ISnapShotStorage<TDomainEvent> where TDomainEvent : IDomainEvent
    {
        ISnapShot GetSnapShot(Guid entityId);
        void SaveShapShot(IEventProvider<TDomainEvent> entity);
    }
}