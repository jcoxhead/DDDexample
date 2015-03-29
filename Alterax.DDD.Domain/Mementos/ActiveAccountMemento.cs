namespace Alterax.DDD.Domain.Mementos
{
    using System;
    using System.Collections.Generic;
    using Alterax.DDD.Domain.Account;
    using Alterax.DDD.EventStore.Storage.Memento.Memento;

    [Serializable]
    public class ActiveAccountMemento : IMemento
    {
        internal Guid Id { get; private set; }
        internal int Version { get; private set; }
        internal Guid ClientId { get; private set; }
        internal string AccountName { get; private set; }
        internal string AccountNumber { get; set; }
        internal decimal Balance { get; private set; }
        internal bool Closed { get; private set; }
        internal List<KeyValuePair<string, string>> Ledgers { get; private set; }

        public ActiveAccountMemento(Guid id, int version, Guid clientId, string accountName, string accountNumber, decimal balance, List<Ledger> ledgers, bool closed)
        {
            Id = id;
            Version = version;
            ClientId = clientId;
            AccountName = accountName;
            AccountNumber = accountNumber;
            Balance = balance;
            Closed = closed;
            Ledgers = new List<KeyValuePair<string, string>>();
            ledgers.ForEach(x => Ledgers.Add(new KeyValuePair<string, string>(x.GetType().Name, string.Format("{0}|{1}", ((decimal)x.Amount), x.Account.Number))));
        }
    }
}