// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Xunit;
using Bottlenose.ServiceBus.Internals;
using Moq;

namespace Bottlenose.ServiceBus.Tests.Observable;

public class BroadcastShould
{
    [Fact]
    public void CallOnNextForSubscribers_GivenASubscriber()
    {
        // ARRANGE
        var mockObserver = new Mock<IObserver<string>>();

        var sut = new Observable<string>();

        sut.Subscribe(mockObserver.Object);

        // ACT

        sut.Broadcast("Hello");

        // ASSERT

        mockObserver.Verify(x => x.OnNext(It.IsAny<string>()), Times.Once());

        

    }

}


