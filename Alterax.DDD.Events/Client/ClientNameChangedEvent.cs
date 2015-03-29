namespace Alterax.DDD.Events.Client
{
    using System;
    using Alterax.DDD.Events;

    [Serializable]
    public class ClientNameChangedEvent : DomainEvent
    {
        public string ClientName { get; private set; }

        public ClientNameChangedEvent(string cLientName)
        {
            ClientName = cLientName;
        }
    }
}