namespace Fusion;

public class NetworkConfiguration
{
	[Flags]
	internal enum ReliableDataTransfers
	{
		ClientToServer = 1,
		ClientToClientWithServerProxy = 2,
	}

	[InlineHelp]
	[Unit(Units::Seconds (2))]
	public double ConnectionTimeout; //Field offset: 0x10
	[InlineHelp]
	[Unit(Units::Seconds (2))]
	public double ConnectionShutdownTime; //Field offset: 0x18
	[InlineHelp]
	public ReliableDataTransfers ReliableDataTransferModes; //Field offset: 0x20

	public int ConnectAttempts
	{
		 get { } //Length: 8
	}

	public double ConnectInterval
	{
		 get { } //Length: 8
	}

	public double ConnectionDefaultRtt
	{
		 get { } //Length: 12
	}

	public double ConnectionPingInterval
	{
		 get { } //Length: 8
	}

	public int SocketRecvBufferSize
	{
		 get { } //Length: 8
	}

	public int SocketSendBufferSize
	{
		 get { } //Length: 8
	}

	public NetworkConfiguration() { }

	public int get_ConnectAttempts() { }

	public double get_ConnectInterval() { }

	public double get_ConnectionDefaultRtt() { }

	public double get_ConnectionPingInterval() { }

	public int get_SocketRecvBufferSize() { }

	public int get_SocketSendBufferSize() { }

	public NetworkConfiguration Init() { }

	internal NetConfig ToNetConfig(NetAddress address) { }

}

