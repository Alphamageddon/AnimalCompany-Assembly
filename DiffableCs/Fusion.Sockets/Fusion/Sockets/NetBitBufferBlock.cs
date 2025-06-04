namespace Fusion.Sockets;

internal struct NetBitBufferBlock
{
	private int _packetSize; //Field offset: 0x0
	private IntPtr _freeHead; //Field offset: 0x8
	private NetBitBufferBlock* _self; //Field offset: 0x10
	private NetBitBuffer* _allocatedHead; //Field offset: 0x18

	public static NetBitBufferBlock* Create(int packetSize) { }

	public static void Dispose(NetBitBufferBlock* block) { }

	public void Release(NetBitBuffer* ptr) { }

	public NetBitBuffer* TryAcquire() { }

	public bool TryAcquire(out NetBitBuffer* ptr) { }

}

