namespace Alterax.DDD.Domain.Mementos
{
    using System;
    using System.Collections.Generic;
    using Alterax.DDD.EventStore.Storage.Memento.Memento;

    [Serializable]
    public class ClientMemento : IMemento
    {
        internal Guid Id { get; private set; }
        internal int Version { get; private set; }
        internal string ClientName { get; private set; }
        internal string Street { get; private set; }
        internal string StreetNumber { get; private set; }
        internal string PostalCode { get; private set; }
        internal string City { get; private set; }
        internal string PhoneNumber { get; private set; }
        internal List<Guid> Accounts { get; private set; }
        internal List<IMemento> BankCardMementos { get; private set; }

        public ClientMemento(Guid id, int version, string clientName, string street, string streetNumber, string postalCode, string city, string phoneNumber, List<Guid> accounts, List<IMemento> bankCardMementos)
        {
            Id = id;
            Version = version;
            ClientName = clientName;
            Street = street;
            StreetNumber = streetNumber;
            PostalCode = postalCode;
            City = city;
            PhoneNumber = phoneNumber;
            Accounts = accounts;
            BankCardMementos = bankCardMementos;
        }
    }
}