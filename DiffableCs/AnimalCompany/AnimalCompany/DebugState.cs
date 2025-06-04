namespace AnimalCompany;

public class DebugState : StateObject
{
	public const string PLAYER_PREFS_LOCAL_LOG_LEVEL = "DebugLocalLogLevel"; //Field offset: 0x0
	public const string PLAYER_PREFS_REMOTE_LOG_LEVEL = "DebugRemoteLogLevel"; //Field offset: 0x0
	[CompilerGenerated]
	private StatePrimitive<LogLevel> <logLevel>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<LogChannel> <logChannelFlags>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private StatePrimitive<LogLevel> <remoteLogLevel>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private StatePrimitive<LogChannel> <remoteLogChannelFlags>k__BackingField; //Field offset: 0x60

	public private StatePrimitive<LogChannel> logChannelFlags
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<LogLevel> logLevel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<LogChannel> remoteLogChannelFlags
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<LogLevel> remoteLogLevel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public DebugState() { }

	[CompilerGenerated]
	public StatePrimitive<LogChannel> get_logChannelFlags() { }

	[CompilerGenerated]
	public StatePrimitive<LogLevel> get_logLevel() { }

	[CompilerGenerated]
	public StatePrimitive<LogChannel> get_remoteLogChannelFlags() { }

	[CompilerGenerated]
	public StatePrimitive<LogLevel> get_remoteLogLevel() { }

	[CompilerGenerated]
	private void set_logChannelFlags(StatePrimitive<LogChannel> value) { }

	[CompilerGenerated]
	private void set_logLevel(StatePrimitive<LogLevel> value) { }

	[CompilerGenerated]
	private void set_remoteLogChannelFlags(StatePrimitive<LogChannel> value) { }

	[CompilerGenerated]
	private void set_remoteLogLevel(StatePrimitive<LogLevel> value) { }

}

