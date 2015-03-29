namespace Alterax.DDD.Events.Client
{
    using System;
    using Alterax.DDD.Events;

    [Serializable]
    public class AccountToClientAssignedEvent : DomainEvent
    {
        public Guid AccountId { get; private set; }

        public AccountToClientAssignedEvent(Guid accountId)
        {
            AccountId = accountId;
        }
    }
}