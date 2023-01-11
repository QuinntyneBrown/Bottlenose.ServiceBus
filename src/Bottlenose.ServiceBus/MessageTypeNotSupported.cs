namespace Bottlenose.ServiceBus;

public class MessageTypeNotSupported: Exception {
	public MessageTypeNotSupported(Type messageType)
		:base($"Message type not supported: {messageType.Name}")
	{ }
}
