namespace AnimalCompany;

public class NetSessionPlayerState : StateObject, IStateDictionaryKeyedObject<Int32>
{
	[CompilerGenerated]
	private int <playerID>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<String> <userID>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private StatePrimitive<Single> <voice>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private StatePrimitive<Boolean> <blockedLocalPlayer>k__BackingField; //Field offset: 0x60

	public private StatePrimitive<Boolean> blockedLocalPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int playerID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> userID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Single> voice
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public NetSessionPlayerState() { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_blockedLocalPlayer() { }

	[CompilerGenerated]
	public int get_playerID() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_userID() { }

	[CompilerGenerated]
	public StatePrimitive<Single> get_voice() { }

	public override void OnKeyAssigned(int key) { }

	[CompilerGenerated]
	private void set_blockedLocalPlayer(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_playerID(int value) { }

	[CompilerGenerated]
	private void set_userID(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_voice(StatePrimitive<Single> value) { }

}

