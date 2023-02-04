// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Bottlenose.ServiceBus.Internals;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Sockets;

namespace Bottlenose.ServiceBus.Udp;

public class ServiceBusMessageListener: Observable<IServiceBusMessage>, IServiceBusMessageListener
{
    private readonly ILogger<ServiceBusMessageListener> _logger;
    private readonly UdpClient _client;
    
    public ServiceBusMessageListener(
        ILogger<ServiceBusMessageListener> logger,
        IUdpClientFactory udpClientFactory
        ){


        _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        _client = udpClientFactory.Create();
    }

    public async Task StartAsync(CancellationToken cancellationToken = default)
    {
        while(!cancellationToken.IsCancellationRequested)
        {
            var packet = await _client.ReceiveAsync(cancellationToken);

            Broadcast(new ServiceBusMessage());
        }        
    }
}


