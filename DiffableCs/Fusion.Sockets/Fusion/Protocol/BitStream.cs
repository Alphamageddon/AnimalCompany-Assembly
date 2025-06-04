namespace Fusion.Protocol;

public class BitStream
{
	internal sealed class ArrayElementSerializer : MulticastDelegate
	{

		public ArrayElementSerializer`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref T element, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref T element, IAsyncResult result) { }

		public override void Invoke(ref T element) { }

	}

	private int _ptr; //Field offset: 0x10
	private int _size; //Field offset: 0x14
	private Byte[] _data; //Field offset: 0x18
	private bool _write; //Field offset: 0x20

	public int BytesRequired
	{
		 get { } //Length: 92
	}

	public int Capacity
	{
		 get { } //Length: 28
	}

	public Byte[] Data
	{
		 get { } //Length: 8
	}

	public bool Done
	{
		 get { } //Length: 16
	}

	public bool IsEvenBytes
	{
		 get { } //Length: 16
	}

	public bool Overflowing
	{
		 get { } //Length: 16
	}

	public int Position
	{
		 get { } //Length: 8
		 set { } //Length: 120
	}

	public bool Reading
	{
		 get { } //Length: 16
		 set { } //Length: 16
	}

	public int Size
	{
		 get { } //Length: 8
		 set { } //Length: 124
	}

	public bool Writing
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public BitStream(Byte[] arr) { }

	public BitStream(int size) { }

	public BitStream() { }

	public BitStream(Byte[] arr, int size) { }

	public bool CanRead(int bits) { }

	public bool CanRead() { }

	public bool CanWrite() { }

	public bool CanWrite(int bits) { }

	public bool Condition(bool condition) { }

	public void CopyFromArray(Byte[] array) { }

	public void Expand() { }

	public int get_BytesRequired() { }

	public int get_Capacity() { }

	public Byte[] get_Data() { }

	public bool get_Done() { }

	public bool get_IsEvenBytes() { }

	public bool get_Overflowing() { }

	public int get_Position() { }

	public bool get_Reading() { }

	public int get_Size() { }

	public bool get_Writing() { }

	private byte InternalReadByte(int bits) { }

	private void InternalWriteByte(byte value, int bits) { }

	public bool ReadBool() { }

	public bool ReadBoolean() { }

	public byte ReadByte() { }

	public byte ReadByte(int bits) { }

	public void ReadByteArray(Byte[] to, int offset, int count) { }

	public void ReadByteArray(Byte[] to, int count) { }

	public void ReadByteArray(Byte[] to) { }

	public Byte[] ReadByteArray(int size) { }

	public Byte[] ReadByteArrayLengthPrefixed() { }

	public char ReadChar() { }

	public double ReadDouble() { }

	public float ReadFloat() { }

	public Guid ReadGuid() { }

	public int ReadInt() { }

	public int ReadInt(int bits) { }

	public int ReadInt_Shifted(int bits, int shift) { }

	public long ReadLong() { }

	public long ReadLong(int bits) { }

	public sbyte ReadSByte() { }

	public short ReadShort(int bits) { }

	public short ReadShort() { }

	public string ReadString(Encoding encoding) { }

	public string ReadString() { }

	public uint ReadUInt() { }

	public uint ReadUInt(int bits) { }

	public ulong ReadULong(int bits) { }

	public ulong ReadULong() { }

	public ushort ReadUShort() { }

	public ushort ReadUShort(int bits) { }

	public void Reset(int byteSize) { }

	public void Reset() { }

	public void ResetFast(int byteSize) { }

	public int RoundToByte() { }

	public void Serialize(ref Byte[] array, ref int length, int fixedSize) { }

	public void Serialize(ref Byte[] array, ref int length) { }

	public void Serialize(ref Byte[] value) { }

	public void Serialize(ref Int32[] value) { }

	public void Serialize(ref int value, int bits) { }

	public void Serialize(ref int value) { }

	public void Serialize(ref ulong value, int bits) { }

	public void Serialize(ref uint value, int bits) { }

	public void Serialize(ref uint value) { }

	public void Serialize(ref byte value) { }

	public void Serialize(ref ulong value) { }

	public void Serialize(ref long value) { }

	public void Serialize(ref double value) { }

	public void Serialize(ref string value) { }

	public void Serialize(ref Byte[] value, int fixedSize) { }

	public void Serialize(ref bool value) { }

	public void Serialize(ref float value) { }

	public void Serialize(Int32* v, int bits) { }

	public void Serialize(Byte* v) { }

	public void Serialize(SByte* v) { }

	public void Serialize(Int16* v) { }

	public void Serialize(UInt16* v) { }

	public void Serialize(Int32* v) { }

	public void Serialize(UInt32* v, int bits) { }

	public void Serialize(UInt32* v) { }

	public void Serialize(Int64* v) { }

	public void Serialize(UInt64* v) { }

	public void SerializeArray(ref T[] array, ArrayElementSerializer<T> serializer) { }

	public void SerializeArrayLength(ref T[] array) { }

	public void SerializeBuffer(Byte* buffer, int length) { }

	public void SerializeBuffer(SByte* buffer, int length) { }

	public void SerializeBuffer(Int16* buffer, int length) { }

	public void SerializeBuffer(UInt16* buffer, int length) { }

	public void SerializeBuffer(Int32* buffer, int length) { }

	public void SerializeBuffer(UInt32* buffer, int length) { }

	public void SerializeBuffer(Int64* buffer, int length) { }

	public void SerializeBuffer(UInt64* buffer, int length) { }

	public void set_Position(int value) { }

	public void set_Reading(bool value) { }

	public void set_Size(int value) { }

	public void set_Writing(bool value) { }

	public void SetBuffer(Byte[] arr) { }

	public void SetBuffer(Byte[] arr, int size) { }

	public Byte[] ToArray() { }

	public bool WriteBool(bool value) { }

	public bool WriteBoolean(bool value) { }

	public void WriteByte(byte value, int bits) { }

	public void WriteByte(byte value) { }

	public void WriteByteArray(Byte[] from, int offset, int count) { }

	public void WriteByteArray(Byte[] from, int count) { }

	public void WriteByteArray(Byte[] from) { }

	public void WriteByteArrayLengthPrefixed(Byte[] array, int maxLength) { }

	public void WriteByteArrayLengthPrefixed(Byte[] array) { }

	public static void WriteByteAt(Byte[] data, int ptr, int bits, byte value) { }

	public void WriteChar(char value) { }

	public void WriteDouble(double value) { }

	public void WriteFloat(float value) { }

	public void WriteGuid(Guid guid) { }

	public void WriteInt(int value, int bits) { }

	public void WriteInt(int value) { }

	public void WriteInt_Shifted(int value, int bits, int shift) { }

	public void WriteLong(long value) { }

	public void WriteLong(long value, int bits) { }

	public void WriteSByte(sbyte value) { }

	public void WriteShort(short value) { }

	public void WriteShort(short value, int bits) { }

	public void WriteString(string value, Encoding encoding) { }

	public void WriteString(string value) { }

	public void WriteUInt(uint value) { }

	public void WriteUInt(uint value, int bits) { }

	public void WriteULong(ulong value) { }

	public void WriteULong(ulong value, int bits) { }

	public void WriteUShort(ushort value) { }

	public void WriteUShort(ushort value, int bits) { }

}

