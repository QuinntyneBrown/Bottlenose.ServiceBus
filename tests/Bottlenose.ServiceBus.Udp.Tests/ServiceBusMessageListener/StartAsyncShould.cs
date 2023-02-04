// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Xunit;
using Bottlenose.ServiceBus.Udp;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;

namespace Bottlenose.ServiceBus.Udp.Tests.ServiceBusMessageListener;

using ServiceBusMessageListener = Bottlenose.ServiceBus.Udp.ServiceBusMessageListener;

public class StartAsyncShould
{
    [Fact]
    public async Task CallOnNextOnSubscibers_GivenUdpMessageSent()
    {
        var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

        // ARRANGE

        var services = new ServiceCollection();

        var mockSubscriber = new Mock<IObserver<IServiceBusMessage>>();


        services.AddLogging();

        var container = services.BuildServiceProvider();

        var sut = ActivatorUtilities.CreateInstance<ServiceBusMessageListener>(container);

        sut.Subscribe(mockSubscriber.Object);



        // ACT

        _ = new TaskFactory().StartNew(() => sut.StartAsync(), TaskCreationOptions.LongRunning);

        // ASSERT

        await tcs.Task;
    }

}


