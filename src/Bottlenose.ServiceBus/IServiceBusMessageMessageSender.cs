namespace Bottlenose.ServiceBus;

public interface IServiceBusMessageSender
{
    void Send<T>(T message)
       where T : class, IServiceBusMessage;
}

