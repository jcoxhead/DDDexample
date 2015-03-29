namespace Alterax.DDD.EventStore
{
    using System;
    using Storage.Memento.Memento;

    public interface IDomainRepository<TDomainEvent> where TDomainEvent : IDomainEvent
    {
        TAggregate GetById<TAggregate>(Guid id)
            where TAggregate : class, IOrginator, IEventProvider<TDomainEvent>, new();

        void Add<TAggregate>(TAggregate aggregateRoot)
            where TAggregate : class, IOrginator, IEventProvider<TDomainEvent>, new();
    }
}