namespace AnimalCompany;

public class NetConnectionStatus : StateObject
{
	[CompilerGenerated]
	private StatePrimitive<States> <state>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<String> <message>k__BackingField; //Field offset: 0x50

	public private StatePrimitive<String> message
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<States> state
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public NetConnectionStatus() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_message() { }

	[CompilerGenerated]
	public StatePrimitive<States> get_state() { }

	[CompilerGenerated]
	private void set_message(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_state(StatePrimitive<States> value) { }

}

