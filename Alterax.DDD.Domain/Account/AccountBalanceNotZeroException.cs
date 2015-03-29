namespace Alterax.DDD.Domain.Account
{
    using System;

    public class AccountBalanceNotZeroException : Exception
    {
        public AccountBalanceNotZeroException(string message) : base(message) { }
    }
}