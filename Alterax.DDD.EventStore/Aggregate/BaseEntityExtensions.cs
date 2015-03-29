namespace Alterax.DDD.EventStore.Aggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Alterax.DDD.EventStore;

    public static class TryGetByIdExtension
    {
        public static bool TryGetValueById<TEventProvider, TDomainEvent>(this IEnumerable<TEventProvider> list, Guid Id, out IEntityEventProvider<TDomainEvent> baseEntity)
            where TEventProvider : IEntityEventProvider<TDomainEvent>
            where TDomainEvent : IDomainEvent
        {
            baseEntity = list.Where(x => x.Id == Id).FirstOrDefault();
            return baseEntity != null;
        }
    }
}