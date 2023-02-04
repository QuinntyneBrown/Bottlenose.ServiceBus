// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Xunit;
using Bottlenose.ServiceBus.Internals;
using Moq;

namespace Bottlenose.ServiceBus.Tests.Observable;

public class SubscribeShould
{
    [Fact]
    public void DoSomething_GivenSomething()
    {
        // ARRANGE

        var mockSubsciber = new Mock<IObserver<string>>();

        var sut = new Observable<string>();

        // ACT

        sut.Subscribe(mockSubsciber.Object);

        // ASSERT


        
    }

}


