namespace ExitGames.Client.Photon;

public class Protocol16 : IProtocol
{
	internal enum GpType
	{
		Unknown = 0,
		Array = 121,
		Boolean = 111,
		Byte = 98,
		ByteArray = 120,
		ObjectArray = 122,
		Short = 107,
		Float = 102,
		Dictionary = 68,
		Double = 100,
		Hashtable = 104,
		Integer = 105,
		IntegerArray = 110,
		Long = 108,
		String = 115,
		StringArray = 97,
		Custom = 99,
		Null = 42,
		EventData = 101,
		OperationRequest = 113,
		OperationResponse = 112,
	}

	private static readonly Single[] memFloatBlock; //Field offset: 0x0
	private static readonly Byte[] memFloatBlockBytes; //Field offset: 0x8
	private readonly Byte[] versionBytes; //Field offset: 0x18
	private readonly Byte[] memShort; //Field offset: 0x20
	private readonly Int64[] memLongBlock; //Field offset: 0x28
	private readonly Byte[] memLongBlockBytes; //Field offset: 0x30
	private readonly Double[] memDoubleBlock; //Field offset: 0x38
	private readonly Byte[] memDoubleBlockBytes; //Field offset: 0x40
	private readonly Byte[] memInteger; //Field offset: 0x48
	private readonly Byte[] memLong; //Field offset: 0x50
	private readonly Byte[] memFloat; //Field offset: 0x58
	private readonly Byte[] memDouble; //Field offset: 0x60

	public virtual string ProtocolType
	{
		 get { } //Length: 64
	}

	public virtual Byte[] VersionBytes
	{
		 get { } //Length: 8
	}

	private static Protocol16() { }

	public Protocol16() { }

	private Array CreateArrayByType(byte arrayType, short length) { }

	public virtual object Deserialize(StreamBuffer din, byte type, DeserializationFlags flags = 0) { }

	private Array DeserializeArray(StreamBuffer din) { }

	private bool DeserializeBoolean(StreamBuffer din) { }

	public virtual byte DeserializeByte(StreamBuffer din) { }

	private Byte[] DeserializeByteArray(StreamBuffer din, int size = -1) { }

	private object DeserializeCustom(StreamBuffer din, byte customTypeCode, DeserializationFlags flags = 0) { }

	private IDictionary DeserializeDictionary(StreamBuffer din) { }

	private bool DeserializeDictionaryArray(StreamBuffer din, short size, out Array arrayResult) { }

	private Type DeserializeDictionaryType(StreamBuffer reader, out byte keyTypeCode, out byte valTypeCode) { }

	public virtual DisconnectMessage DeserializeDisconnectMessage(StreamBuffer stream) { }

	private double DeserializeDouble(StreamBuffer din) { }

	public virtual EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = 0) { }

	private float DeserializeFloat(StreamBuffer din) { }

	private Hashtable DeserializeHashTable(StreamBuffer din) { }

	private Int32[] DeserializeIntArray(StreamBuffer din, int size = -1) { }

	private int DeserializeInteger(StreamBuffer din) { }

	private long DeserializeLong(StreamBuffer din) { }

	private Object[] DeserializeObjectArray(StreamBuffer din) { }

	public virtual OperationRequest DeserializeOperationRequest(StreamBuffer din, DeserializationFlags flags) { }

	public virtual OperationResponse DeserializeOperationResponse(StreamBuffer stream, DeserializationFlags flags = 0) { }

	private ParameterDictionary DeserializeParameterDictionary(StreamBuffer stream, ParameterDictionary target = null, DeserializationFlags flags = 0) { }

	private Dictionary<Byte, Object> DeserializeParameterTable(StreamBuffer stream, Dictionary<Byte, Object> target = null) { }

	public virtual short DeserializeShort(StreamBuffer din) { }

	private string DeserializeString(StreamBuffer din) { }

	private String[] DeserializeStringArray(StreamBuffer din) { }

	public virtual string get_ProtocolType() { }

	public virtual Byte[] get_VersionBytes() { }

	private GpType GetCodeOfType(Type type) { }

	private Type GetTypeOfCode(byte typeCode) { }

	public virtual void Serialize(StreamBuffer dout, object serObject, bool setType) { }

	private void SerializeArray(StreamBuffer dout, Array serObject, bool setType) { }

	private void SerializeBoolean(StreamBuffer dout, bool serObject, bool setType) { }

	private void SerializeByte(StreamBuffer dout, byte serObject, bool setType) { }

	private void SerializeByteArray(StreamBuffer dout, Byte[] serObject, bool setType) { }

	private void SerializeByteArraySegment(StreamBuffer dout, Byte[] serObject, int offset, int count, bool setType) { }

	private bool SerializeCustom(StreamBuffer dout, object serObject) { }

	private void SerializeDictionary(StreamBuffer dout, IDictionary serObject, bool setType) { }

	private void SerializeDictionaryElements(StreamBuffer writer, object dict, bool setKeyType, bool setValueType) { }

	private void SerializeDictionaryHeader(StreamBuffer writer, object dict, out bool setKeyType, out bool setValueType) { }

	private void SerializeDictionaryHeader(StreamBuffer writer, Type dictType) { }

	private void SerializeDouble(StreamBuffer dout, double serObject, bool setType) { }

	public virtual void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType) { }

	private void SerializeFloat(StreamBuffer dout, float serObject, bool setType) { }

	private void SerializeHashTable(StreamBuffer dout, Hashtable serObject, bool setType) { }

	private void SerializeIntArrayOptimized(StreamBuffer inWriter, Int32[] serObject, bool setType) { }

	private void SerializeInteger(StreamBuffer dout, int serObject, bool setType) { }

	public void SerializeLengthAsShort(StreamBuffer dout, int serObject, string type) { }

	private void SerializeLong(StreamBuffer dout, long serObject, bool setType) { }

	private void SerializeObjectArray(StreamBuffer dout, IList objects, bool setType) { }

	public virtual void SerializeOperationRequest(StreamBuffer stream, byte operationCode, ParameterDictionary parameters, bool setType) { }

	[Obsolete("Use ParameterDictionary instead.")]
	public virtual void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<Byte, Object> parameters, bool setType) { }

	public void SerializeOperationRequest(StreamBuffer stream, OperationRequest operation, bool setType) { }

	public virtual void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType) { }

	[Obsolete("Use ParameterDictionary instead of Dictionary<byte, object>.")]
	private void SerializeParameterTable(StreamBuffer stream, Dictionary<Byte, Object> parameters) { }

	private void SerializeParameterTable(StreamBuffer stream, ParameterDictionary parameters) { }

	public virtual void SerializeShort(StreamBuffer dout, short serObject, bool setType) { }

	public virtual void SerializeString(StreamBuffer stream, string value, bool setType) { }

	private void SerializeStringArray(StreamBuffer dout, String[] serObject, bool setType) { }

}

