// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Sockets;

namespace Bottlenose.ServiceBus.Udp;

public class UdpClientFactory : IUdpClientFactory
{
    private readonly ILogger<UdpClientFactory> _logger;

    public UdpClientFactory(ILogger<UdpClientFactory> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public UdpClient Create()
    {
        UdpClient? udpClient = default;

        int i = 1;

        while(udpClient?.Client == null)
        {
            try
            {
                var localIpAddress = $"127.0.0.{i}";

                udpClient = new UdpClient(localIpAddress, 5540);

                udpClient.JoinMulticastGroup(IPAddress.Parse("244.0.0.0"), IPAddress.Parse(localIpAddress));


            }
            catch(SocketException ex)
            {
                var r = ex;
                i++;
            }
        }

        return udpClient;

    }

}


