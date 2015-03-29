namespace Alterax.DDD.EventStore.Storage
{
    using System;
    using EventStore;
    using Memento.Memento;

    public interface IEventStoreUnitOfWork<TDomainEvent> : IUnitOfWork where TDomainEvent : IDomainEvent
    {
        TAggregate GetById<TAggregate>(Guid id) where TAggregate : class, IOrginator, IEventProvider<TDomainEvent>, new();
        void Add<TAggregate>(TAggregate aggregateRoot) where TAggregate : class, IOrginator, IEventProvider<TDomainEvent>, new();
        void RegisterForTracking<TAggregate>(TAggregate aggregateRoot) where TAggregate : class, IOrginator, IEventProvider<TDomainEvent>, new();
    }
}