namespace Alterax.DDD.Events.Account
{
    using System;
    using Alterax.DDD.Events;

    [Serializable]
    public class AccountNameChangedEvent : DomainEvent 
    {
        public string AccountName { get; private set; }

        public AccountNameChangedEvent(string accountName)
        {
            AccountName = accountName;
        }
    }
}