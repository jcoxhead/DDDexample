namespace Alterax.DDD.Events.Client
{
    using System;
    using Alterax.DDD.Events;

    [Serializable]
    public class ClientPhoneNumberChangedEvent : DomainEvent
    {
        public string PhoneNumber { get; private set; }

        public ClientPhoneNumberChangedEvent(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
    }
}