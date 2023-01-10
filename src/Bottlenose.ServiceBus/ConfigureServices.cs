using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bottlenose.ServiceBus;

public static class ConfigureServices { 
    public static void AddServiceBusServices(this IServiceCollection services)
    {
        services.AddSingleton<IServiceBusMessageListener, ServiceBusMessageListener>();
    }
}
