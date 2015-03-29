namespace Alterax.DDD.EventStore
{
    using System;

    public interface IDomainEvent
    {
        Guid Id { get; }
        Guid AggregateId { get; set; }
        int Version { get; set; }
    }
}