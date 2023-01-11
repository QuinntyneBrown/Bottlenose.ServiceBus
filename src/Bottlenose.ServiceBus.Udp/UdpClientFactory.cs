/*using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Sockets;

namespace Bottlenose.ServiceBus.Udp;

public class UdpClientFactory: IUdpClientFactory
{
    private readonly ILogger<UdpClientFactory> _logger;

    public UdpClientFactory(ILogger<UdpClientFactory> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public UdpClient Create(IPAddress ip, int port){
        UdpClient? udpClient = default;


    
    }

    private static int GetNextPort()
    {
        using(var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
        {
            socket.Bind(new IPEndPoint(IPAddress.Loopback,0));
            
            return ((IPEndPoint)socket.LocalEndPoint).Port;
        }
    }

}

*/