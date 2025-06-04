namespace Fusion.Sockets;

public struct NetBitBufferNull : INetBitWriteStream
{
	private int _offsetBits; //Field offset: 0x0

	public override int OffsetBits
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override int get_OffsetBits() { }

	public void PadToByteBoundary() { }

	public void set_OffsetBits(int value) { }

	public override bool WriteBoolean(bool b) { }

	public void WriteByte(byte value, int bits = 8) { }

	public override void WriteBytesAligned(Void* buffer, int length) { }

	public override void WriteInt32(int value, int bits = 32) { }

	public override void WriteInt32VarLength(int value) { }

	public override void WriteInt32VarLength(int value, int blockSize) { }

	public void WriteUInt32VarLength(uint value, int blockSize) { }

	public void WriteUInt32VarLength(uint value) { }

	public override void WriteUInt64VarLength(ulong value, int blockSize) { }

}

