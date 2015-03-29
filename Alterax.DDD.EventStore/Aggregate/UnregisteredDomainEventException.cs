namespace Alterax.DDD.EventStore.Aggregate
{
    using System;

    public class UnregisteredDomainEventException : Exception
    {
        public UnregisteredDomainEventException(string message) : base(message) { }
    }
}