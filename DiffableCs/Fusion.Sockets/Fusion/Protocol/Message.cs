namespace Fusion.Protocol;

internal abstract class Message : IMessage
{
	private const int CustomDataLenght = 1024; //Field offset: 0x0
	public ProtocolMessageVersion ProtocolVersion; //Field offset: 0x10
	public Version FusionSerializationVersion; //Field offset: 0x18
	private string _customData; //Field offset: 0x20

	public string CustomData
	{
		 get { } //Length: 8
		 set { } //Length: 256
	}

	public override bool IsValid
	{
		 get { } //Length: 128
	}

	public Message(ProtocolMessageVersion protocolMessage = 10, Version serializationVersion = null) { }

	public bool CheckCompability(ProtocolMessageVersion pluginProtocolVersion, Version pluginVersion, Version sessionSerializationVersion) { }

	public override Message Clone() { }

	public string get_CustomData() { }

	public override bool get_IsValid() { }

	public void Serialize(BitStream stream) { }

	protected override void SerializeProtected(BitStream stream) { }

	public void set_CustomData(string value) { }

	public virtual string ToString() { }

}

