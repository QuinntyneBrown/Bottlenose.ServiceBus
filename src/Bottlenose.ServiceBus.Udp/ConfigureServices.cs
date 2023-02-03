// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Bottlenose.ServiceBus;
using Bottlenose.ServiceBus.Udp;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices { 

    public static void AddUdpServiceBusServices(this IServiceCollection services)
    {
        services.AddSingleton<IServiceBusMessageListener, ServiceBusMessageListener>();
    }
}
