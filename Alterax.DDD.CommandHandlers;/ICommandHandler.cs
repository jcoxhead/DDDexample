﻿namespace Alterax.DDD.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : class
    {
        void Execute(TCommand command);
    }
}