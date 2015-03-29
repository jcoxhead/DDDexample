namespace Alterax.DDD.Domain.Account
{
    using System;

    public class NonExitsingAccountException : Exception
    {
        public NonExitsingAccountException(string message) : base(message) {}
    }
}