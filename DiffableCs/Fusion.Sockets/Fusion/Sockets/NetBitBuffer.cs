namespace Fusion.Sockets;

public struct NetBitBuffer : INetBitWriteStream, ILogDumpable
{
	internal struct Offset
	{
		private int _offset; //Field offset: 0x0

		public Offset(NetBitBuffer* buffer) { }

		public int GetLength(NetBitBuffer* buffer) { }

	}

	private const int BITCOUNT = 64; //Field offset: 0x0
	private const int USEDMASK = 63; //Field offset: 0x0
	private const int INDEXSHIFT = 6; //Field offset: 0x0
	private const int BYTESHIFT = 3; //Field offset: 0x0
	private const ulong MAXVALUE = 18446744073709551615; //Field offset: 0x0
	public NetAddress Address; //Field offset: 0x0
	internal NetBitBuffer* Prev; //Field offset: 0x18
	internal NetBitBuffer* Next; //Field offset: 0x20
	internal NetBitBufferBlock* _block; //Field offset: 0x28
	internal NetBitBuffer* _allocNext; //Field offset: 0x30
	private int _group; //Field offset: 0x38
	private UInt64* _data; //Field offset: 0x40
	private UInt64* _dataBlockOriginal; //Field offset: 0x48
	private int _offsetBits; //Field offset: 0x50
	private int _lengthBits; //Field offset: 0x54
	private int _lengthBytes; //Field offset: 0x58

	public int BytesRemaining
	{
		 get { } //Length: 104
	}

	public internal UInt64* Data
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public bool Done
	{
		 get { } //Length: 16
	}

	public bool DoneOrOverflow
	{
		 get { } //Length: 16
	}

	internal short Group
	{
		internal get { } //Length: 12
		internal set { } //Length: 16
	}

	public bool IsOnEvenByte
	{
		 get { } //Length: 16
	}

	public int LengthBits
	{
		 get { } //Length: 8
	}

	public internal int LengthBytes
	{
		 get { } //Length: 8
		internal set { } //Length: 12
	}

	public bool MoreToRead
	{
		 get { } //Length: 16
	}

	public internal override int OffsetBits
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public int OffsetBitsUnsafe
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int OffsetBytes
	{
		 get { } //Length: 24
	}

	public bool Overflow
	{
		 get { } //Length: 16
	}

	internal bool OverflowOrLessThanOneByteRemaining
	{
		internal get { } //Length: 20
	}

	internal NetPacketType PacketType
	{
		internal get { } //Length: 12
		internal set { } //Length: 12
	}

	internal int Advance(int bits, bool writing) { }

	public static NetBitBuffer* Allocate(int group, int size) { }

	public bool CanRead(int bits) { }

	public bool CanWrite(int bits) { }

	public bool CheckBitCount(int count) { }

	public void Clear() { }

	private override void Fusion.ILogDumpable.Dump(StringBuilder builder) { }

	public int get_BytesRemaining() { }

	public UInt64* get_Data() { }

	public bool get_Done() { }

	public bool get_DoneOrOverflow() { }

	internal short get_Group() { }

	public bool get_IsOnEvenByte() { }

	public int get_LengthBits() { }

	public int get_LengthBytes() { }

	public bool get_MoreToRead() { }

	public override int get_OffsetBits() { }

	public int get_OffsetBitsUnsafe() { }

	public int get_OffsetBytes() { }

	public bool get_Overflow() { }

	internal bool get_OverflowOrLessThanOneByteRemaining() { }

	internal NetPacketType get_PacketType() { }

	public Byte* GetDataPointer() { }

	public static Offset GetOffset(NetBitBuffer* buffer) { }

	public void PadToByteBoundary() { }

	public Byte* PadToByteBoundaryAndGetPtr() { }

	private ulong Peek(int bits) { }

	public bool PeekBoolean() { }

	private ulong Read(int bits) { }

	public bool ReadBoolean() { }

	public byte ReadByte(int bits = 8) { }

	public void ReadBytesAligned(Void* buffer, int length) { }

	public void ReadBytesAligned(Byte[] buffer, int length) { }

	public double ReadDouble() { }

	public short ReadInt16(int bits = 16) { }

	public int ReadInt32(int bits = 32) { }

	public int ReadInt32VarLength(int blockSize) { }

	public int ReadInt32VarLength() { }

	public long ReadInt64(int bits = 64) { }

	public long ReadInt64VarLength(int blockSize) { }

	public float ReadSingle() { }

	public string ReadString(Encoding encoding) { }

	public string ReadString() { }

	public ushort ReadUInt16(int bits = 16) { }

	public uint ReadUInt32(int bits = 32) { }

	public uint ReadUInt32VarLength() { }

	public uint ReadUInt32VarLength(int blockSize) { }

	public ulong ReadUInt64(int bits = 64) { }

	public ulong ReadUInt64VarLength(int blockSize) { }

	public static void Release(NetBitBuffer* buffer) { }

	public static void ReleaseRef(ref NetBitBuffer* buffer) { }

	public void ReplaceDataFromBlockWithTemp(int tempSize) { }

	public void SeekToByteBoundary() { }

	internal void set_Data(UInt64* value) { }

	internal void set_Group(short value) { }

	internal void set_LengthBytes(int value) { }

	internal void set_OffsetBits(int value) { }

	public void set_OffsetBitsUnsafe(int value) { }

	internal void set_PacketType(NetPacketType value) { }

	public void SetBufferLengthBytes(UInt64* buffer, int lenghtInBytes) { }

	public void Write(ulong value, int bits) { }

	public override bool WriteBoolean(bool value) { }

	public void WriteByte(byte value, int bits = 8) { }

	public override void WriteBytesAligned(Void* buffer, int length) { }

	public void WriteBytesAligned(Byte[] buffer, int length) { }

	public void WriteDouble(double value) { }

	public void WriteInt16(short value, int bits = 16) { }

	public override void WriteInt32(int value, int bits = 32) { }

	public void WriteInt32AtOffset(int value, int offset, int bits) { }

	public override void WriteInt32VarLength(int value) { }

	public override void WriteInt32VarLength(int value, int blockSize) { }

	public void WriteInt64(long value, int bits = 64) { }

	public void WriteInt64VarLength(long value, int blockSize) { }

	public void WriteSingle(float value) { }

	public void WriteSlow(ulong value, int bits) { }

	public void WriteString(string value, Encoding encoding) { }

	public void WriteString(string value) { }

	public void WriteUInt16(ushort value, int bits = 16) { }

	public void WriteUInt32(uint value, int bits = 32) { }

	public void WriteUInt32VarLength(uint value, int blockSize) { }

	public void WriteUInt32VarLength(uint value) { }

	public void WriteUInt64(ulong value, int bits = 64) { }

	public void WriteUInt64AtOffset(ulong value, int offset, int bits) { }

	public override void WriteUInt64VarLength(ulong value, int blockSize) { }

}

