namespace Alterax.DDD.EventStore.Storage
{
    using System;
    using Memento.Memento;

    public interface ISnapShot
    {
        IMemento Memento { get; }
        Guid EventProviderId { get; }
        int Version { get; }
    }
}