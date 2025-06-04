namespace Fusion;

internal class CloudServicesMetadata
{
	public static readonly TypedLobby LobbyClientServer; //Field offset: 0x0
	public static readonly TypedLobby LobbyShared; //Field offset: 0x8
	[CompilerGenerated]
	private NetworkRunnerInitializeArgs <RunnerInitializeArgs>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private NATPunchStage <CurrentPunchStage>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private JoinProcessStage <CurrentJoinStage>k__BackingField; //Field offset: 0x10C
	[CompilerGenerated]
	private ProtocolMessageVersion <CurrentProtocolMessageVersion>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private ReflexiveInfo <RemoteReflexiveInfo>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private Byte[] <UniqueId>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private int <PlayerRef>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private EncryptionToken <EncryptionToken>k__BackingField; //Field offset: 0x130
	public ScheduledRequests ScheduledRequests; //Field offset: 0x138
	public Disconnect LastDisconnectMsg; //Field offset: 0x140
	public Dictionary<Int64, ReflexiveInfo> UniqueIdToReflexiveInfoTable; //Field offset: 0x148
	private StunResult _localStunResult; //Field offset: 0x150

	public JoinProcessStage CurrentJoinStage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ProtocolMessageVersion CurrentProtocolMessageVersion
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public NATPunchStage CurrentPunchStage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public EncryptionToken EncryptionToken
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StunResult LocalReflexiveInfo
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int PlayerRef
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ReflexiveInfo RemoteReflexiveInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public NetworkRunnerInitializeArgs RunnerInitializeArgs
	{
		[CompilerGenerated]
		 get { } //Length: 16
		[CompilerGenerated]
		 set { } //Length: 24
	}

	public Byte[] UniqueId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static CloudServicesMetadata() { }

	public CloudServicesMetadata() { }

	[CompilerGenerated]
	public JoinProcessStage get_CurrentJoinStage() { }

	[CompilerGenerated]
	public ProtocolMessageVersion get_CurrentProtocolMessageVersion() { }

	[CompilerGenerated]
	public NATPunchStage get_CurrentPunchStage() { }

	[CompilerGenerated]
	public EncryptionToken get_EncryptionToken() { }

	public StunResult get_LocalReflexiveInfo() { }

	[CompilerGenerated]
	public int get_PlayerRef() { }

	[CompilerGenerated]
	public ReflexiveInfo get_RemoteReflexiveInfo() { }

	[CompilerGenerated]
	public NetworkRunnerInitializeArgs get_RunnerInitializeArgs() { }

	[CompilerGenerated]
	public Byte[] get_UniqueId() { }

	[CompilerGenerated]
	public void set_CurrentJoinStage(JoinProcessStage value) { }

	[CompilerGenerated]
	public void set_CurrentProtocolMessageVersion(ProtocolMessageVersion value) { }

	[CompilerGenerated]
	public void set_CurrentPunchStage(NATPunchStage value) { }

	[CompilerGenerated]
	public void set_EncryptionToken(EncryptionToken value) { }

	public void set_LocalReflexiveInfo(StunResult value) { }

	[CompilerGenerated]
	public void set_PlayerRef(int value) { }

	[CompilerGenerated]
	public void set_RemoteReflexiveInfo(ReflexiveInfo value) { }

	[CompilerGenerated]
	public void set_RunnerInitializeArgs(NetworkRunnerInitializeArgs value) { }

	[CompilerGenerated]
	public void set_UniqueId(Byte[] value) { }

}

