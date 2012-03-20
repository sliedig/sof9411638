using System;
using NServiceBus;

namespace EventBEndpoint
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server {}
}