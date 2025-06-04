namespace Fusion.Protocol;

internal class ProtocolSerializer
{
	private readonly BitStream _writeStream; //Field offset: 0x10
	private readonly BitStream _readStream; //Field offset: 0x18
	private readonly Dictionary<Type, Byte> _typeToId; //Field offset: 0x20
	private readonly Dictionary<Byte, Message> _idToType; //Field offset: 0x28

	public ProtocolSerializer() { }

	public bool ConvertToBuffer(Message message, out BitStream buffer) { }

	public bool ConvertToMessages(Byte[] data, List<Message> messages) { }

	private bool PackNext(Message msg, BitStream stream) { }

	private bool ReadNext(BitStream stream, out Message msg) { }

	private void RegisterProtocolMsg(byte id, Message message) { }

}

