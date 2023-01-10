using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Bottlenose.ServiceBus;

public class ServiceBusMessageListener: IServiceBusMessageListener
{
    private readonly ILogger<ServiceBusMessageListener> _logger;

    public ServiceBusMessageListener(ILogger<ServiceBusMessageListener> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task DoWorkAsync(){ }

}

