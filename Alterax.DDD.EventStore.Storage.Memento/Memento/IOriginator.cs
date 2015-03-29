namespace Alterax.DDD.EventStore.Storage.Memento.Memento
{
    public interface IOrginator
    {
        IMemento CreateMemento();
        void SetMemento(IMemento memento);
    }
}