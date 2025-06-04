namespace Fusion.Sockets;

internal struct NetCommandRefused
{
	public const int SIZE_IN_BYTES = 3; //Field offset: 0x0
	public const int SIZE_IN_BITS = 24; //Field offset: 0x0
	public NetCommandHeader Header; //Field offset: 0x0
	public NetConnectFailedReason Reason; //Field offset: 0x2

	public static NetCommandRefused Create(NetConnectFailedReason reason) { }

}

