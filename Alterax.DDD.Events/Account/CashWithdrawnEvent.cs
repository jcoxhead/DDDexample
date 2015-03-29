namespace Alterax.DDD.Events.Account
{
    using System;
    using Alterax.DDD.Events;

    [Serializable]
    public class CashWithdrawnEvent : DomainEvent
    {
        public decimal Balance { get; private set; }
        public decimal Amount { get; private set; }

        public CashWithdrawnEvent(decimal balance, decimal amount)
        {
            Balance = balance;
            Amount = amount;
        }
    }
}