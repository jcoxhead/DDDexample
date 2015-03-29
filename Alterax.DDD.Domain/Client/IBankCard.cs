namespace Alterax.DDD.Domain.Client
{
    public interface IBankCard
    {
        void BankCardIsReportedStolen();
        void ClientCancelsBankCard();
    }
}