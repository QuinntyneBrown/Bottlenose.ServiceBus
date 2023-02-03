using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Bottlenose.ServiceBus.Udp;

public interface IUdpClientFactory
{
     UdpClient Create(IPAddress ip, int port);

}

