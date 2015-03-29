namespace Alterax.DDD.Domain.Mementos
{
    using System;
    using Alterax.DDD.EventStore.Storage.Memento.Memento;

    [Serializable]
    public class BankCardMemento : IMemento
    {
        internal Guid Id { get; private set; }
        internal Guid AccountId { get; private set; }
        internal bool Disabled { get; private set; }

        public BankCardMemento(Guid id, Guid accountId, bool disabled)
        {
            Id = id;
            AccountId = accountId;
            Disabled = disabled;
        }
    }
}