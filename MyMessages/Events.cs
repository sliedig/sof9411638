using System;
using NServiceBus;

namespace MyMessages
{
    public class EventA : IEvent
    {
        public Guid DataId { get; set; }
    }

    public class EventB : IEvent
    {
        public Guid DataId { get; set; }
    }
}
