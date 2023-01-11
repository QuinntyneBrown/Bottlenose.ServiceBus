using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Bottlenose.ServiceBus.Udp;

public interface IUdpClientFactory
{
     Task Create();

}

