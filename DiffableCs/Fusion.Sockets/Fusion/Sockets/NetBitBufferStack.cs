namespace Fusion.Sockets;

internal struct NetBitBufferStack
{
	private int _capacity; //Field offset: 0x0
	public NetBitBuffer** Stack; //Field offset: 0x8
	public int Count; //Field offset: 0x10

	public static NetBitBufferStack Create(int capacity) { }

	public static void Free(NetBitBufferStack stack) { }

	public void PushFromHead(NetBitBuffer* head) { }

	public bool TryPop(NetBitBuffer** result) { }

}

