namespace Alterax.DDD.Domain.Client
{
    using System;

    public class NonExistingBankCardException : Exception
    {
        public NonExistingBankCardException(string message) : base(message) {}
    }
}