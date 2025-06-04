namespace Fusion.Sockets;

internal struct NetSendEnvelopeRingBuffer
{
	private NetSendEnvelope* _items; //Field offset: 0x0
	private int _itemsCapacity; //Field offset: 0x8
	public int Head; //Field offset: 0xC
	public int Tail; //Field offset: 0x10
	public int Count; //Field offset: 0x14

	public bool IsEmpty
	{
		 get { } //Length: 16
	}

	public bool IsFull
	{
		 get { } //Length: 20
	}

	public static NetSendEnvelopeRingBuffer Create(int capacity) { }

	public void Dispose() { }

	public bool get_IsEmpty() { }

	public bool get_IsFull() { }

	public NetSendEnvelope Peek() { }

	public void Pop() { }

	public void Push(NetSendEnvelope envelope) { }

	public void Reset() { }

	public bool TryPush(NetSendEnvelope envelope) { }

}

