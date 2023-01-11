using Bottlenose.ServiceBus.Internals;
using Microsoft.Extensions.Logging;
using System.Threading.Channels;

namespace Bottlenose.ServiceBus.Channels;

public class ServiceBusMessageListener: Observable<IServiceBusMessage>, IServiceBusMessageListener
{
    private readonly ILogger<ServiceBusMessageListener> _logger;
    private readonly Channel<IServiceBusMessage> _channel = Channel.CreateUnbounded<IServiceBusMessage>();
                                                                                                                                                                                           
    public ServiceBusMessageListener(
        ILogger<ServiceBusMessageListener> logger,
        Channel<IServiceBusMessage> channel)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _channel = channel ?? throw new ArgumentNullException(nameof(channel));
    }

    public async Task StartAsync(CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("ServiceBusMessageListener started");

        while(!cancellationToken.IsCancellationRequested)
        {
            var message = await _channel.Reader.ReadAsync(cancellationToken);

            _logger.LogInformation("ServiceBusMessage received");

            Broadcast(message);

            await Task.Delay(0);
        }
    }

}

