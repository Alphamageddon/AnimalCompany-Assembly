namespace Fusion;

public struct StartGameArgs
{
	public GameMode GameMode; //Field offset: 0x0
	public string SessionName; //Field offset: 0x8
	public Func<String> SessionNameGenerator; //Field offset: 0x10
	public Nullable<NetAddress> Address; //Field offset: 0x18
	public Nullable<NetAddress> CustomPublicAddress; //Field offset: 0x38
	public INetworkObjectProvider ObjectProvider; //Field offset: 0x58
	public INetworkSceneManager SceneManager; //Field offset: 0x60
	public INetworkRunnerUpdater Updater; //Field offset: 0x68
	public INetworkObjectInitializer ObjectInitializer; //Field offset: 0x70
	public NetworkProjectConfig Config; //Field offset: 0x78
	public Nullable<Int32> PlayerCount; //Field offset: 0x80
	public Nullable<NetworkSceneInfo> Scene; //Field offset: 0x88
	public Action<NetworkRunner> OnGameStarted; //Field offset: 0xC0
	public bool DisableNATPunchthrough; //Field offset: 0xC8
	public Type[] CustomCallbackInterfaces; //Field offset: 0xD0
	public Byte[] ConnectionToken; //Field offset: 0xD8
	public Dictionary<String, SessionProperty> SessionProperties; //Field offset: 0xE0
	public Nullable<Boolean> IsOpen; //Field offset: 0xE8
	public Nullable<Boolean> IsVisible; //Field offset: 0xEA
	public Nullable<MatchmakingMode> MatchmakingMode; //Field offset: 0xEC
	public Nullable<Boolean> UseDefaultPhotonCloudPorts; //Field offset: 0xEE
	public string CustomLobbyName; //Field offset: 0xF0
	public string CustomSTUNServer; //Field offset: 0xF8
	public AuthenticationValues AuthValues; //Field offset: 0x100
	public FusionAppSettings CustomPhotonAppSettings; //Field offset: 0x108
	public Nullable<Boolean> EnableClientSessionCreation; //Field offset: 0x110
	public HostMigrationToken HostMigrationToken; //Field offset: 0x118
	public Action<NetworkRunner> HostMigrationResume; //Field offset: 0x120
	public CancellationToken StartGameCancellationToken; //Field offset: 0x128
	public Nullable<Boolean> UseCachedRegions; //Field offset: 0x130

	public virtual string ToString() { }

}

