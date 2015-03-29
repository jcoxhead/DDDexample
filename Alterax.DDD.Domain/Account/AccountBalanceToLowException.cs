namespace Alterax.DDD.Domain.Account
{
    using System;

    public class AccountBalanceToLowException : Exception
    {
        public AccountBalanceToLowException(string message) : base(message) { }
    }
}