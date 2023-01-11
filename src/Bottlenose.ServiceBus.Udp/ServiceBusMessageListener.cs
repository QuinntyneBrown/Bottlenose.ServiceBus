using Bottlenose.ServiceBus.Internals;
using Microsoft.Extensions.Logging;

namespace Bottlenose.ServiceBus.Udp;

public class ServiceBusMessageListener: Observable<IServiceBusMessage>, IServiceBusMessageListener
{
    private readonly ILogger<ServiceBusMessageListener> _logger;

    public ServiceBusMessageListener(ILogger<ServiceBusMessageListener> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Task StartAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

