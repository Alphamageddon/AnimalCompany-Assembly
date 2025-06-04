namespace Fusion.Sockets;

public struct ReliableBuffer
{
	public const int SEQ_BYTES = 4; //Field offset: 0x0
	private NetSequencer _sequencer; //Field offset: 0x0
	private ReliableList _receiveList; //Field offset: 0x18
	private ulong _receiveSequence; //Field offset: 0x30

	public int SequenceBits
	{
		 get { } //Length: 12
	}

	public static ReliableBuffer Create() { }

	public void Dispose() { }

	public int get_SequenceBits() { }

	public void LateFree(Void* root) { }

	public bool LateReceive(out Void* root, out ReliableId id, out Byte* data) { }

	public ulong NextSendSequence() { }

	public bool Receive(NetBitBuffer* buffer, out ReliableId rid) { }

}

