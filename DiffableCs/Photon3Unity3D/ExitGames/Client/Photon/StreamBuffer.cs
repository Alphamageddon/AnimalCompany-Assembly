namespace ExitGames.Client.Photon;

public class StreamBuffer
{
	private const int DefaultInitialSize = 0; //Field offset: 0x0
	private int pos; //Field offset: 0x10
	private int len; //Field offset: 0x14
	private Byte[] buf; //Field offset: 0x18

	public int Available
	{
		 get { } //Length: 16
	}

	public bool CanRead
	{
		 get { } //Length: 8
	}

	public bool CanSeek
	{
		 get { } //Length: 8
	}

	public bool CanWrite
	{
		 get { } //Length: 8
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public int Position
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public StreamBuffer(int size = 0) { }

	public StreamBuffer(Byte[] buf) { }

	private bool CheckSize(int size) { }

	public void Compact() { }

	public void Flush() { }

	public int get_Available() { }

	public bool get_CanRead() { }

	public bool get_CanSeek() { }

	public bool get_CanWrite() { }

	public int get_Length() { }

	public int get_Position() { }

	public Byte[] GetBuffer() { }

	public Byte[] GetBufferAndAdvance(int length, out int offset) { }

	public int Read(Byte[] buffer, int dstOffset, int count) { }

	public byte ReadByte() { }

	public long Seek(long offset, SeekOrigin origin) { }

	public void set_Position(int value) { }

	public void SetCapacityMinimum(int neededSize) { }

	public void SetLength(long value) { }

	public Byte[] ToArray() { }

	public Byte[] ToArrayFromPos() { }

	public void Write(Byte[] buffer, int srcOffset, int count) { }

	public void WriteByte(byte value) { }

	public void WriteBytes(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7) { }

	public void WriteBytes(byte v0, byte v1) { }

	public void WriteBytes(byte v0, byte v1, byte v2) { }

	public void WriteBytes(byte v0, byte v1, byte v2, byte v3) { }

}

