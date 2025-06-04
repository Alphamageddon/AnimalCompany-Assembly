namespace Fusion.Sockets;

internal struct NetBitBufferList
{
	public int Count; //Field offset: 0x0
	public NetBitBuffer* Head; //Field offset: 0x8
	public NetBitBuffer* Tail; //Field offset: 0x10

	public void AddFirst(NetBitBuffer* item) { }

	public void AddLast(NetBitBuffer* item) { }

	private bool IsInList(NetBitBuffer* item) { }

	public void Remove(NetBitBuffer* item) { }

	public NetBitBuffer* RemoveHead() { }

}

