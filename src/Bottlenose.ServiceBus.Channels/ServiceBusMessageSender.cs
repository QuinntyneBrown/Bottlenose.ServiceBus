using Microsoft.Extensions.Logging;
using System.Threading.Channels;

namespace Bottlenose.ServiceBus.Channels;

public class ServiceBusMessageSender: IServiceBusMessageSender
{
    private readonly ILogger<ServiceBusMessageSender> _logger;
    private readonly Channel<IServiceBusMessage> _channel;

    public ServiceBusMessageSender(
        ILogger<ServiceBusMessageSender> logger,
        Channel<IServiceBusMessage> channel
        ){
        _channel = channel ?? throw new ArgumentNullException(nameof(channel));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void Send<T>(T message)
       where T : class, IServiceBusMessage
    {
        _logger.LogInformation("Send");

        _channel.Writer.TryWrite(message);
    }
}

