namespace Alterax.DDD.Domain.Client
{
    public class ClientName
    {
        public string Name { get; private set; }

        public ClientName(string name)
        {
            Name = name;
        }
    }
}