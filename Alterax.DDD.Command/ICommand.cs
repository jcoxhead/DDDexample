namespace Alterax.DDD.Command
{
    using System;

    public interface ICommand
    {
        Guid Id { get; }
    }
}