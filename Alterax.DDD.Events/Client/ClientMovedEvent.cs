namespace Alterax.DDD.Events.Client
{
    using System;
    using Alterax.DDD.Events;

    [Serializable]
    public class ClientMovedEvent : DomainEvent
    {
        public string Street { get; private set; }
        public string StreetNumber { get; private set; }
        public string PostalCode { get; private set; }
        public string City { get; private set; }

        public ClientMovedEvent(string street, string streetNumber, string postalCode, string city)
        {
            Street = street;
            StreetNumber = streetNumber;
            PostalCode = postalCode;
            City = city;
        }
    }
}