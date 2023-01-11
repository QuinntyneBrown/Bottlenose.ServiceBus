using Bottlenose.ServiceBus;
using Bottlenose.ServiceBus.Udp;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices { 

    public static void AddUdpServiceBusServices(this IServiceCollection services)
    {
        services.AddSingleton<IServiceBusMessageListener, ServiceBusMessageListener>();
    }
}
