namespace AnimalCompany;

public class NetSessionState : StateObject
{
	[CompilerGenerated]
	private StatePrimitive<Boolean> <isConnected>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<String> <roomCode>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private StatePrimitive<Int32> <playerCount>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private StatePrimitive<Int32> <localPlayerID>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private NetSessionPropertiesState <properties>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private StatePrimitiveSet<String> <playerUserIDs>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private StatePrimitiveSet<String> <mutedPlayerUserIDs>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private StateDictionary<Int32, NetSessionPlayerState> <players>k__BackingField; //Field offset: 0x80

	public private StatePrimitive<Boolean> isConnected
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Int32> localPlayerID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitiveSet<String> mutedPlayerUserIDs
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Int32> playerCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StateDictionary<Int32, NetSessionPlayerState> players
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitiveSet<String> playerUserIDs
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private NetSessionPropertiesState properties
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
	private void <PostInitialize>b__32_0(StateChangedEventArgs args) { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_isConnected() { }

	[CompilerGenerated]
	public StatePrimitive<Int32> get_localPlayerID() { }

	[CompilerGenerated]
	public StatePrimitiveSet<String> get_mutedPlayerUserIDs() { }

	[CompilerGenerated]
	public StatePrimitive<Int32> get_playerCount() { }

	[CompilerGenerated]
	public StateDictionary<Int32, NetSessionPlayerState> get_players() { }

	[CompilerGenerated]
	public StatePrimitiveSet<String> get_playerUserIDs() { }

	[CompilerGenerated]
	public NetSessionPropertiesState get_properties() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_roomCode() { }

	protected virtual void PostInitialize() { }

	[CompilerGenerated]
	private void set_isConnected(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_localPlayerID(StatePrimitive<Int32> value) { }

	[CompilerGenerated]
	private void set_mutedPlayerUserIDs(StatePrimitiveSet<String> value) { }

	[CompilerGenerated]
	private void set_playerCount(StatePrimitive<Int32> value) { }

	[CompilerGenerated]
	private void set_players(StateDictionary<Int32, NetSessionPlayerState> value) { }

	[CompilerGenerated]
	private void set_playerUserIDs(StatePrimitiveSet<String> value) { }

	[CompilerGenerated]
	private void set_properties(NetSessionPropertiesState value) { }

	[CompilerGenerated]
	private void set_roomCode(StatePrimitive<String> value) { }

}

