namespace Alterax.DDD.Domain.Client
{
    using System;
    using Alterax.DDD.EventStore;
    using Alterax.DDD.EventStore.Aggregate;
    using Alterax.DDD.EventStore.Storage.Memento.Memento;
    using Events.Client;
    using Mementos;

    public class BankCard : BaseEntity<IDomainEvent>, IOrginator, IBankCard
    {
        private Guid _accountId;
        private bool _disabled;

        public BankCard()
        {
            registerEvents();
        }

        public BankCard(Guid bankCardId, Guid accountId) : this()
        {
            Id = bankCardId;
            _accountId = accountId;
        }

        public void BankCardIsReportedStolen()
        {
            IsDisabled();

            Apply(new BankCardWasReportedStolenEvent());
        }

        public void ClientCancelsBankCard()
        {
            IsDisabled();

            Apply(new BankCardWasCanceledByCLientEvent());
        }

        private void IsDisabled()
        {
            if (_disabled)
                throw new BankCardIsDisabledException("The bank card is disabled and no opperations can be executed on it");
        }

        IMemento IOrginator.CreateMemento()
        {
            return new BankCardMemento(Id, _accountId, _disabled);
        }

        void IOrginator.SetMemento(IMemento memento)
        {
            var bankCardMemento = (BankCardMemento)memento;
            Id = bankCardMemento.Id;
            _accountId = bankCardMemento.AccountId;
            _disabled = bankCardMemento.Disabled;
        }

        private void registerEvents()
        {
            RegisterEvent<BankCardWasReportedStolenEvent>(onBankCardWasReportedStolenEvent);
            RegisterEvent<BankCardWasCanceledByCLientEvent>(onBankCardWasCanceledByCLientEvent);
        }

        private void onBankCardWasReportedStolenEvent(BankCardWasReportedStolenEvent obj)
        {
            _disabled = true;
        }

        private void onBankCardWasCanceledByCLientEvent(BankCardWasCanceledByCLientEvent obj)
        {
            _disabled = true;
        }
    }
}