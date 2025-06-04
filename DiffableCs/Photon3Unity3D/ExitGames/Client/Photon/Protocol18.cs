namespace ExitGames.Client.Photon;

public class Protocol18 : IProtocol
{
	internal enum GpType
	{
		Unknown = 0,
		Boolean = 2,
		Byte = 3,
		Short = 4,
		Float = 5,
		Double = 6,
		String = 7,
		Null = 8,
		CompressedInt = 9,
		CompressedLong = 10,
		Int1 = 11,
		Int1_ = 12,
		Int2 = 13,
		Int2_ = 14,
		L1 = 15,
		L1_ = 16,
		L2 = 17,
		L2_ = 18,
		Custom = 19,
		CustomTypeSlim = 128,
		Dictionary = 20,
		Hashtable = 21,
		ObjectArray = 23,
		OperationRequest = 24,
		OperationResponse = 25,
		EventData = 26,
		BooleanFalse = 27,
		BooleanTrue = 28,
		ShortZero = 29,
		IntZero = 30,
		LongZero = 31,
		FloatZero = 32,
		DoubleZero = 33,
		ByteZero = 34,
		Array = 64,
		BooleanArray = 66,
		ByteArray = 67,
		ShortArray = 68,
		DoubleArray = 70,
		FloatArray = 69,
		StringArray = 71,
		HashtableArray = 85,
		DictionaryArray = 84,
		CustomTypeArray = 83,
		CompressedIntArray = 73,
		CompressedLongArray = 74,
	}

	private static readonly Byte[] boolMasks; //Field offset: 0x0
	private readonly Byte[] versionBytes; //Field offset: 0x18
	private readonly Double[] memDoubleBlock; //Field offset: 0x20
	private readonly Single[] memFloatBlock; //Field offset: 0x28
	private readonly Byte[] memCustomTypeBodyLengthSerialized; //Field offset: 0x30
	private readonly Byte[] memCompressedUInt32; //Field offset: 0x38
	private Byte[] memCompressedUInt64; //Field offset: 0x40

	public virtual string ProtocolType
	{
		 get { } //Length: 64
	}

	public virtual Byte[] VersionBytes
	{
		 get { } //Length: 8
	}

	private static Protocol18() { }

	public Protocol18() { }

	private int DecodeZigZag32(uint value) { }

	private long DecodeZigZag64(ulong value) { }

	public virtual object Deserialize(StreamBuffer din, byte type, DeserializationFlags flags = 0) { }

	public virtual byte DeserializeByte(StreamBuffer din) { }

	public virtual DisconnectMessage DeserializeDisconnectMessage(StreamBuffer stream) { }

	public virtual EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = 0) { }

	public virtual OperationRequest DeserializeOperationRequest(StreamBuffer din, DeserializationFlags flags = 0) { }

	public virtual OperationResponse DeserializeOperationResponse(StreamBuffer stream, DeserializationFlags flags = 0) { }

	public virtual short DeserializeShort(StreamBuffer din) { }

	private uint EncodeZigZag32(int value) { }

	private ulong EncodeZigZag64(long value) { }

	public virtual string get_ProtocolType() { }

	public virtual Byte[] get_VersionBytes() { }

	private static Type GetAllowedDictionaryKeyTypes(GpType gpType) { }

	private static Type GetClrArrayType(GpType gpType) { }

	private GpType GetCodeOfType(Type type) { }

	private GpType GetCodeOfTypeCode(TypeCode type) { }

	private Type GetDictArrayType(StreamBuffer stream) { }

	private object Read(StreamBuffer stream, byte gpType, DeserializationFlags flags = 0, ParameterDictionary parameters = null) { }

	private object Read(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters) { }

	private Array ReadArrayInArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters) { }

	internal bool ReadBoolean(StreamBuffer stream) { }

	private Boolean[] ReadBooleanArray(StreamBuffer stream) { }

	internal byte ReadByte(StreamBuffer stream) { }

	internal Byte[] ReadByteArray(StreamBuffer stream) { }

	internal int ReadCompressedInt32(StreamBuffer stream) { }

	internal Int32[] ReadCompressedInt32Array(StreamBuffer stream) { }

	internal long ReadCompressedInt64(StreamBuffer stream) { }

	internal Int64[] ReadCompressedInt64Array(StreamBuffer stream) { }

	private uint ReadCompressedUInt32(StreamBuffer stream) { }

	private ulong ReadCompressedUInt64(StreamBuffer stream) { }

	public object ReadCustomType(StreamBuffer stream, byte gpType = 0) { }

	private object ReadCustomTypeArray(StreamBuffer stream) { }

	private IDictionary ReadDictionary(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters) { }

	private IDictionary[] ReadDictionaryArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters) { }

	private bool ReadDictionaryElements(StreamBuffer stream, GpType keyReadType, GpType valueReadType, IDictionary dictionary, DeserializationFlags flags, ParameterDictionary parameters) { }

	private Type ReadDictionaryType(StreamBuffer stream, out GpType keyReadType, out GpType valueReadType) { }

	private Type ReadDictionaryType(StreamBuffer stream) { }

	internal double ReadDouble(StreamBuffer stream) { }

	private Double[] ReadDoubleArray(StreamBuffer stream) { }

	public Hashtable ReadHashtable(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters) { }

	private Hashtable[] ReadHashtableArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters) { }

	internal int ReadInt1(StreamBuffer stream, bool signNegative) { }

	internal short ReadInt16(StreamBuffer stream) { }

	internal Int16[] ReadInt16Array(StreamBuffer stream) { }

	internal int ReadInt2(StreamBuffer stream, bool signNegative) { }

	internal int ReadInt32(StreamBuffer stream) { }

	internal long ReadInt64(StreamBuffer stream) { }

	public Int32[] ReadIntArray(StreamBuffer stream) { }

	internal ByteArraySlice ReadNonAllocByteArray(StreamBuffer stream) { }

	private Object[] ReadObjectArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters) { }

	private ParameterDictionary ReadParameterDictionary(StreamBuffer stream, ParameterDictionary target = null, DeserializationFlags flags = 0) { }

	[Obsolete("Use ParameterDictionary instead.")]
	private Dictionary<Byte, Object> ReadParameterTable(StreamBuffer stream, Dictionary<Byte, Object> target = null, DeserializationFlags flags = 0) { }

	internal float ReadSingle(StreamBuffer stream) { }

	private Single[] ReadSingleArray(StreamBuffer stream) { }

	internal string ReadString(StreamBuffer stream) { }

	internal String[] ReadStringArray(StreamBuffer stream) { }

	internal ushort ReadUShort(StreamBuffer stream) { }

	private StructWrapper[] ReadWrapperArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters) { }

	public virtual void Serialize(StreamBuffer dout, object serObject, bool setType) { }

	public virtual void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType) { }

	private void SerializeOperationRequest(StreamBuffer stream, OperationRequest operation, bool setType) { }

	[Obsolete("Use ParameterDictionary instead.")]
	public virtual void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<Byte, Object> parameters, bool setType) { }

	public virtual void SerializeOperationRequest(StreamBuffer stream, byte operationCode, ParameterDictionary parameters, bool setType) { }

	public virtual void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType) { }

	public virtual void SerializeShort(StreamBuffer dout, short serObject, bool setType) { }

	public virtual void SerializeString(StreamBuffer dout, string serObject, bool setType) { }

	internal void Write(StreamBuffer stream, object value, bool writeType) { }

	private void Write(StreamBuffer stream, object value, GpType gpType, bool writeType) { }

	private bool WriteArrayHeader(StreamBuffer stream, Type type) { }

	private void WriteArrayInArray(StreamBuffer stream, object value, bool writeType) { }

	private void WriteArraySegmentByte(StreamBuffer stream, ArraySegment<Byte> seg, bool writeType) { }

	private bool WriteArrayType(StreamBuffer stream, Type type, out GpType writeType) { }

	internal void WriteBoolArray(StreamBuffer stream, Boolean[] value, bool writeType) { }

	internal void WriteBoolean(StreamBuffer stream, bool value, bool writeType) { }

	internal void WriteByte(StreamBuffer stream, byte value, bool writeType) { }

	internal void WriteByteArray(StreamBuffer stream, Byte[] value, bool writeType) { }

	private void WriteByteArraySlice(StreamBuffer stream, ByteArraySlice buffer, bool writeType) { }

	private void WriteCompressedInt32(StreamBuffer stream, int value, bool writeType) { }

	private void WriteCompressedInt64(StreamBuffer stream, long value, bool writeType) { }

	private void WriteCompressedUInt32(StreamBuffer stream, uint value) { }

	private int WriteCompressedUInt32(Byte[] buffer, uint value) { }

	private void WriteCompressedUInt64(StreamBuffer stream, ulong value) { }

	private void WriteCustomType(StreamBuffer stream, object value, bool writeType) { }

	private void WriteCustomTypeArray(StreamBuffer stream, object value, bool writeType) { }

	private void WriteCustomTypeBody(CustomType customType, StreamBuffer stream, object value) { }

	private void WriteDictionary(StreamBuffer stream, object dict, bool setType) { }

	private void WriteDictionaryArray(StreamBuffer stream, IDictionary[] dictArray, bool writeType) { }

	private void WriteDictionaryElements(StreamBuffer stream, IDictionary dictionary, GpType keyWriteType, GpType valueWriteType) { }

	private void WriteDictionaryHeader(StreamBuffer stream, Type type, out GpType keyWriteType, out GpType valueWriteType) { }

	internal void WriteDouble(StreamBuffer stream, double value, bool writeType) { }

	internal void WriteDoubleArray(StreamBuffer stream, Double[] values, bool setType) { }

	private void WriteHashtable(StreamBuffer stream, object value, bool writeType) { }

	private void WriteHashtableArray(StreamBuffer stream, object value, bool writeType) { }

	internal void WriteInt16(StreamBuffer stream, short value, bool writeType) { }

	internal void WriteInt16Array(StreamBuffer stream, Int16[] value, bool writeType) { }

	internal void WriteInt32ArrayCompressed(StreamBuffer stream, Int32[] value, bool writeType) { }

	private void WriteInt64ArrayCompressed(StreamBuffer stream, Int64[] values, bool setType) { }

	private void WriteIntLength(StreamBuffer stream, int value) { }

	private void WriteObjectArray(StreamBuffer stream, object array, bool writeType) { }

	private void WriteObjectArray(StreamBuffer stream, IList array, bool writeType) { }

	private void WriteParameterTable(StreamBuffer stream, ParameterDictionary parameters) { }

	private void WriteParameterTable(StreamBuffer stream, Dictionary<Byte, Object> parameters) { }

	internal void WriteSingle(StreamBuffer stream, float value, bool writeType) { }

	internal void WriteSingleArray(StreamBuffer stream, Single[] values, bool setType) { }

	internal void WriteString(StreamBuffer stream, string value, bool writeType) { }

	internal void WriteStringArray(StreamBuffer stream, object value0, bool writeType) { }

	internal void WriteUShort(StreamBuffer stream, ushort value) { }

	private void WriteVarInt32(StreamBuffer stream, int value, bool writeType) { }

}

