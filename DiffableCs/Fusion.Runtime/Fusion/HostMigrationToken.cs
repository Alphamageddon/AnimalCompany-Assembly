namespace Fusion;

public sealed class HostMigrationToken
{
	[CompilerGenerated]
	private GameMode <GameMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private CloudCommunicator <CloudCommunicator>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Snapshot <HostSnapshot>k__BackingField; //Field offset: 0x20

	internal CloudCommunicator CloudCommunicator
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private GameMode GameMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private Snapshot HostSnapshot
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	internal Nullable<NetworkId> ResumeId
	{
		internal get { } //Length: 108
	}

	internal Byte[] ResumeState
	{
		internal get { } //Length: 24
	}

	internal Nullable<Tick> ResumeTick
	{
		internal get { } //Length: 200
	}

	internal HostMigrationToken(Snapshot hostSnapshot, CloudCommunicator cloudCommunicator, GameMode gameMode) { }

	[CompilerGenerated]
	internal CloudCommunicator get_CloudCommunicator() { }

	[CompilerGenerated]
	public GameMode get_GameMode() { }

	[CompilerGenerated]
	private Snapshot get_HostSnapshot() { }

	internal Nullable<NetworkId> get_ResumeId() { }

	internal Byte[] get_ResumeState() { }

	internal Nullable<Tick> get_ResumeTick() { }

	[CompilerGenerated]
	private void set_CloudCommunicator(CloudCommunicator value) { }

	[CompilerGenerated]
	private void set_GameMode(GameMode value) { }

}

