// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Bottlenose.ServiceBus;

public class MessageTypeNotSupported: Exception {
	public MessageTypeNotSupported(Type messageType)
		:base($"Message type not supported: {messageType.Name}")
	{ }
}

