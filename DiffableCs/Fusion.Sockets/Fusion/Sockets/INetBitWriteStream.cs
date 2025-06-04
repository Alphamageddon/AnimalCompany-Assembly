namespace Fusion.Sockets;

public interface INetBitWriteStream
{

	public int OffsetBits
	{
		 get { } //Length: 0
	}

	public int get_OffsetBits() { }

	public bool WriteBoolean(bool b) { }

	public void WriteBytesAligned(Void* buffer, int length) { }

	public void WriteInt32(int value, int bits = 32) { }

	public void WriteInt32VarLength(int value) { }

	public void WriteInt32VarLength(int value, int blockSize) { }

	public void WriteUInt64VarLength(ulong value, int blockSize) { }

}

