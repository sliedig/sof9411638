using System;
using MyMessages;
using NServiceBus;

namespace EventAEndpoint
{
    public class RequestDataMessageHandler : IHandleMessages<EventA>
    {
        public void Handle(EventA message)
        {
            Console.WriteLine("Handling EventA: {0}", message.DataId);
        }
    }
}
