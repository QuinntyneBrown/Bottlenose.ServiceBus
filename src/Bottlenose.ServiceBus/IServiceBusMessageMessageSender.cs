// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Bottlenose.ServiceBus;

public interface IServiceBusMessageSender
{
    void Send<T>(T message)
       where T : class, IServiceBusMessage;
}


