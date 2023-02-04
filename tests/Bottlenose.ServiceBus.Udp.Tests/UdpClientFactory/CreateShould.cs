// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Bottlenose.ServiceBus.Udp.Tests.UdpClientFactory;

using UdpClientFactory = Bottlenose.ServiceBus.Udp.UdpClientFactory;

public class CreateShould
{
    [Fact]
    public void CreateClient()
    {
        // ARRANGE

        var services = new ServiceCollection();

        services.AddLogging();

        var sut = ActivatorUtilities.CreateInstance<UdpClientFactory>(services.BuildServiceProvider());


        // ACT

        var client = sut.Create();

        // ASSERT

        Assert.NotNull(client);

    }


    [Fact]
    public void CreateClients()
    {
        // ARRANGE

        var services = new ServiceCollection();

        services.AddLogging();

        var sut = ActivatorUtilities.CreateInstance<UdpClientFactory>(services.BuildServiceProvider());


        // ACT

        var client1 = sut.Create();

        var client2 = sut.Create();

        // ASSERT

        Assert.NotNull(client1);

    }
}


