using Bottlenose.ServiceBus.Internals;
using System.Net.Sockets;

namespace Bottlenose.ServiceBus.Udp;

public class UdpListenerBase: Observable<UdpPacket> {
    protected readonly UdpClient _inner;

	public UdpListenerBase(UdpClient inner)
	{
		_inner = inner ?? throw new ArgumentNullException(nameof(inner));
	}

	public async Task Start(CancellationToken cancellationToken)
	{
		await Task.Factory.StartNew(async () =>
		{
			while (!cancellationToken.IsCancellationRequested)
			{
				var result = await _inner.ReceiveAsync(cancellationToken);

				Broadcast(new UdpPacket()
				{
					ReceivedOn = DateTime.UtcNow,
					Data = result.Buffer,
					SourceIpAddress = $"{result.RemoteEndPoint.Address}"
				});

			}
		}, TaskCreationOptions.LongRunning);
	}
}
