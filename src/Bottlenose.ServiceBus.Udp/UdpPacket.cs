namespace Bottlenose.ServiceBus.Udp;

public class UdpPacket {
    public DateTime ReceivedOn { get; set; }
    public string SourceIpAddress { get; set; }
    public byte[] Data { get; set; }
}
