namespace Alterax.DDD.Domain.Mementos
{
    using System;
    using System.Collections.Generic;
    using Alterax.DDD.Domain.Account;
    using Alterax.DDD.EventStore.Storage.Memento.Memento;

    [Serializable]
    public class ClosedAccountMemento : IMemento
    {
        internal Guid Id { get; private set; }
        internal int Version { get; private set; }
        internal Guid OriginalAccountId { get; private set; }
        internal Guid ClientId { get; private set; }
        internal string AccountName { get; private set; }
        internal string AccountNumber { get; private set; }
        internal List<KeyValuePair<string, string>> Ledgers { get; private set; }

        public ClosedAccountMemento(Guid id, int version, Guid originalAccountId, Guid clientId, string accountName, string accountNumber, List<Ledger> ledgers)
        {
            Id = id;
            Version = version;
            OriginalAccountId = originalAccountId;
            ClientId = clientId;
            AccountName = accountName;
            AccountNumber = accountNumber;
            Ledgers = new List<KeyValuePair<string, string>>();
            ledgers.ForEach(x => Ledgers.Add(new KeyValuePair<string, string>(x.GetType().Name, string.Format("{0}|{1}", ((decimal)x.Amount), x.Account.Number))));
        }
    }
}