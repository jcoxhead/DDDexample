namespace Alterax.DDD.Domain.Account
{
    using System;

    public class ClosedAccountException : Exception
    {
        public ClosedAccountException(string message) : base(message) { }
    }
}