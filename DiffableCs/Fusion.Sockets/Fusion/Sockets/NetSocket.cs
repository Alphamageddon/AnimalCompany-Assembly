namespace Fusion.Sockets;

public struct NetSocket
{
	public long Handle; //Field offset: 0x0
	public Socket NativeSocket; //Field offset: 0x0

	public bool IsCreated
	{
		 get { } //Length: 8
	}

	public bool get_IsCreated() { }

}

