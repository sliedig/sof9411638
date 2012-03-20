using System;
using NServiceBus;

namespace EventAEndpoint
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server {}
}