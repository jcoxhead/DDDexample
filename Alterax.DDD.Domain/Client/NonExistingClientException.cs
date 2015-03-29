namespace Alterax.DDD.Domain.Client
{
    using System;

    public class NonExistingClientException : Exception
    {
        public NonExistingClientException(string message) : base(message) {}
    }
}