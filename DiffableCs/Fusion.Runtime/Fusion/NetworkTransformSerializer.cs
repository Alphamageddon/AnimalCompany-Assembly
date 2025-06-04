namespace Fusion;

internal class NetworkTransformSerializer : NetworkBufferSerializer
{
	private const int POSITION_ACCURACY = 1024; //Field offset: 0x0
	private const int POSITION_BLOCK_SIZE = 4; //Field offset: 0x0
	private const int JUMP_OFFSET = 6; //Field offset: 0x0
	public static NetworkTransformSerializer Instance; //Field offset: 0x0

	private static NetworkTransformSerializer() { }

	public NetworkTransformSerializer() { }

	public virtual int Read(RecvContext rc, NetworkObjectMeta meta, NetworkBufferSerializerInfo info, Int32* ptr, int word) { }

	public virtual int Skip(RecvContext rc, int word) { }

	public virtual int Write(SendContext sc, NetworkObjectMeta meta, NetworkBufferSerializerInfo info, Int32* ptr, int word, int prev) { }

}

