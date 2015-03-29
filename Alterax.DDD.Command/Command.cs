namespace Alterax.DDD.Command
{
    using System;

    [Serializable]
    public class Command : ICommand
    {
        public Guid Id { get; private set; }

        public Command(Guid id)
        {
            Id = id;
        }
    }
}