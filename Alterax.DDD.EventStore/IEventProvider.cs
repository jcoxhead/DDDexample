﻿namespace Alterax.DDD.EventStore
{
    using System;
    using System.Collections.Generic;

    public interface IEventProvider<TDomainEvent> where TDomainEvent : IDomainEvent
    {
        void Clear();
        void LoadFromHistory(IEnumerable<TDomainEvent> domainEvents);
        void UpdateVersion(int version);
        Guid Id { get; }
        int Version { get; }
        IEnumerable<TDomainEvent> GetChanges();
    }
}