namespace AnimalCompany;

public class NetSessionState : StateObject
{
	[CompilerGenerated]
	private StatePrimitive<Boolean> <isConnected>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<String> <roomCode>k__BackingField; //Field offset: 0x50

	public private StatePrimitive<Boolean> isConnected
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> roomCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public NetSessionState() { }

	[CompilerGenerated]
	private void <PostInitialize>b__8_0(StateChangedEventArgs args) { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_isConnected() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_roomCode() { }

	protected virtual void PostInitialize() { }

	[CompilerGenerated]
	private void set_isConnected(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_roomCode(StatePrimitive<String> value) { }

}

