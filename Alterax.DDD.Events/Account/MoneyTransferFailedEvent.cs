namespace Alterax.DDD.Events.Account
{
    using System;
    using Alterax.DDD.Events;

    [Serializable]
    public class MoneyTransferFailedEvent : DomainEvent 
    {
        public decimal Balance { get; private set; }
        public decimal Amount { get; private set; }
        public string TargetAccount { get; private set; }

        public MoneyTransferFailedEvent(decimal balance, decimal amount, string targetAccount)
        {
            Balance = balance;
            Amount = amount;
            TargetAccount = targetAccount;
        }
    }
}