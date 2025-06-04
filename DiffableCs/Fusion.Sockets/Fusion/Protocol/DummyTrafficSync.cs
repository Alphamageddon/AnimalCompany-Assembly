namespace Fusion.Protocol;

internal class DummyTrafficSync : Message
{
	private const int DummySendIntervalMax = 5000; //Field offset: 0x0
	private const int DummySendIntervalMin = 100; //Field offset: 0x0
	private const int DummySizeMax = 128; //Field offset: 0x0
	private const int DummySizeMin = 2; //Field offset: 0x0
	[CompilerGenerated]
	private int <SendInterval>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <Size>k__BackingField; //Field offset: 0x2C

	public virtual bool IsValid
	{
		 get { } //Length: 68
	}

	public private int SendInterval
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int Size
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public DummyTrafficSync() { }

	public DummyTrafficSync(int sendInterval, int size, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	public virtual bool get_IsValid() { }

	[CompilerGenerated]
	public int get_SendInterval() { }

	[CompilerGenerated]
	public int get_Size() { }

	protected virtual void SerializeProtected(BitStream stream) { }

	[CompilerGenerated]
	private void set_SendInterval(int value) { }

	[CompilerGenerated]
	private void set_Size(int value) { }

	public virtual string ToString() { }

}

