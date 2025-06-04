namespace ExitGames.Client.Photon;

public abstract class IProtocol
{
	internal enum DeserializationFlags
	{
		None = 0,
		AllowPooledByteArray = 1,
		WrapIncomingStructs = 2,
	}

	public readonly ByteArraySlicePool ByteArraySlicePool; //Field offset: 0x10

	public abstract string ProtocolType
	{
		 get { } //Length: 0
	}

	public abstract Byte[] VersionBytes
	{
		 get { } //Length: 0
	}

	protected IProtocol() { }

	public object Deserialize(Byte[] serializedData) { }

	public object Deserialize(StreamBuffer stream) { }

	public abstract object Deserialize(StreamBuffer din, byte type, DeserializationFlags flags = 0) { }

	public abstract byte DeserializeByte(StreamBuffer din) { }

	public abstract DisconnectMessage DeserializeDisconnectMessage(StreamBuffer stream) { }

	public abstract EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = 0) { }

	public object DeserializeMessage(StreamBuffer stream) { }

	public abstract OperationRequest DeserializeOperationRequest(StreamBuffer din, DeserializationFlags flags = 0) { }

	public abstract OperationResponse DeserializeOperationResponse(StreamBuffer stream, DeserializationFlags flags = 0) { }

	public abstract short DeserializeShort(StreamBuffer din) { }

	public abstract string get_ProtocolType() { }

	public abstract Byte[] get_VersionBytes() { }

	public Byte[] Serialize(object obj) { }

	public abstract void Serialize(StreamBuffer dout, object serObject, bool setType) { }

	public abstract void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType) { }

	internal void SerializeMessage(StreamBuffer ms, object msg) { }

	public abstract void SerializeOperationRequest(StreamBuffer stream, byte operationCode, ParameterDictionary parameters, bool setType) { }

	[Obsolete("Use ParameterDictionary instead.")]
	public abstract void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<Byte, Object> parameters, bool setType) { }

	public abstract void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType) { }

	public abstract void SerializeShort(StreamBuffer dout, short serObject, bool setType) { }

	public abstract void SerializeString(StreamBuffer dout, string serObject, bool setType) { }

}

