using System;
using MyMessages;
using NServiceBus;

namespace EventBEndpoint
{
    public class RequestDataMessageHandler : IHandleMessages<EventB>
    {
        public IBus Bus { get; set; }

        public void Handle(EventB message)
        {
            Console.WriteLine("Handling EventB: {0}", message.DataId);
        }
    }
}
