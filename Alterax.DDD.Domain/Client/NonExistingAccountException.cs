namespace Alterax.DDD.Domain.Client
{
    using System;

    public class NonExistingAccountException : Exception
    {
        public NonExistingAccountException(string message) : base(message) { }
    }
}