using System;
using MyMessages;
using NServiceBus;

namespace EventAEventBEndpoint
{
    public class RequestDataMessageHandler : IHandleMessages<EventA>, IHandleMessages<EventB>
    {

        #region Implementation of IMessageHandler<EventA>

        public void Handle(EventA message)
        {
            Console.WriteLine("Handling EventA: {0}", message.DataId);
        }

        #endregion

        #region Implementation of IMessageHandler<EventB>

        public void Handle(EventB message)
        {
            Console.WriteLine("Handling EventB: {0}", message.DataId);
        }

        #endregion
    }
}
