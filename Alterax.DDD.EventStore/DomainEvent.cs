namespace Alterax.DDD.EventStore
{
    using System;

    [Serializable]
    public class DomainEvent : IDomainEvent
    {
        public Guid Id { get; private set; }
        public Guid AggregateId { get; set; }
        int IDomainEvent.Version { get; set; }

        public DomainEvent()
        {
            Id = Guid.NewGuid();
        }
    }
}