using Bottlenose.ServiceBus;
using Bottlenose.ServiceBus.Channels;
using System.Threading.Channels;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static void AddServiceBusChannelsServices(this IServiceCollection services)
    {
        services.AddSingleton<IServiceBusMessageListener, ServiceBusMessageListener>();
        services.AddSingleton<IServiceBusMessageSender, ServiceBusMessageSender>();
        services.AddSingleton(Channel.CreateUnbounded<IServiceBusMessage>());
    }
}