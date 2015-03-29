namespace Alterax.DDD.Domain.Client
{
    using System;

    public class BankCardIsDisabledException : Exception
    {
        public BankCardIsDisabledException(string message) : base(message) { }
    }
}