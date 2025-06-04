namespace Fusion;

public struct RpcHeader
{
	public const int SIZE = 8; //Field offset: 0x0
	public NetworkId Object; //Field offset: 0x0
	public ushort Behaviour; //Field offset: 0x4
	public ushort Method; //Field offset: 0x6

	public static RpcHeader Create(NetworkId id, int behaviour, int method) { }

	public static RpcHeader Create(int staticRpcKey) { }

	public static RpcHeader Read(Byte* data, out int size) { }

	public static int ReadSize(Byte* data) { }

	public virtual string ToString() { }

	public static int Write(RpcHeader header, Byte* data) { }

}

