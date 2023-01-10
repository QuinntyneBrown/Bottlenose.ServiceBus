using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Bottlenose.ServiceBus;

public interface IServiceBusMessageListener
{
     Task DoWorkAsync();

}

