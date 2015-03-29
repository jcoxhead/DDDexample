namespace Alterax.DDD.Events.Account
{
    using System;
    using Alterax.DDD.Events;

    [Serializable]
    public class MoneyTransferSendEvent : DomainEvent 
    {
        public decimal Balance { get; private set; }
        public decimal Amount { get; private set; }
        public string SourceAccount { get; private set; }
        public string TargetAccount { get; private set; }

        public MoneyTransferSendEvent(decimal balance, decimal amount, string sourceAccount, string targetAccount)
        {
            Balance = balance;
            Amount = amount;
            SourceAccount = sourceAccount;
            TargetAccount = targetAccount;
        }
    }
}