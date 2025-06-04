namespace Fusion.Sockets;

public struct NetConfig
{
	public int ConnectionSendBuffers; //Field offset: 0x0
	public int ConnectionGroups; //Field offset: 0x4
	public int MaxConnections; //Field offset: 0x8
	public int SocketSendBuffer; //Field offset: 0xC
	public int SocketRecvBuffer; //Field offset: 0x10
	public int PacketSize; //Field offset: 0x14
	public int ConnectAttempts; //Field offset: 0x18
	public double ConnectInterval; //Field offset: 0x20
	public double OperationExpireTime; //Field offset: 0x28
	public double ConnectionDefaultRtt; //Field offset: 0x30
	public double ConnectionTimeout; //Field offset: 0x38
	public double ConnectionPingInterval; //Field offset: 0x40
	public double ConnectionShutdownTime; //Field offset: 0x48
	public NetAddress Address; //Field offset: 0x50
	public NetConfigNotify Notify; //Field offset: 0x68
	public NetConfigSimulation Simulation; //Field offset: 0x80

	public int ConnectionsPerGroup
	{
		 get { } //Length: 24
	}

	public static NetConfig Defaults
	{
		 get { } //Length: 120
	}

	public int PacketSizeInBits
	{
		 get { } //Length: 12
	}

	public int get_ConnectionsPerGroup() { }

	public static NetConfig get_Defaults() { }

	public int get_PacketSizeInBits() { }

}

