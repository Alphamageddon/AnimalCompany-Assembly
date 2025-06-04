namespace Fusion;

internal abstract class NetworkBufferSerializer
{
	protected const int DATA_BLOCK_SIZE = 6; //Field offset: 0x0
	protected const int OFFSET_BLOCK_SIZE = 4; //Field offset: 0x0

	protected NetworkBufferSerializer() { }

	public abstract int Read(RecvContext rc, NetworkObjectMeta meta, NetworkBufferSerializerInfo info, Int32* ptr, int word) { }

	public abstract int Skip(RecvContext rc, int word) { }

	public abstract int Write(SendContext sc, NetworkObjectMeta meta, NetworkBufferSerializerInfo info, Int32* ptr, int word, int prev) { }

}

