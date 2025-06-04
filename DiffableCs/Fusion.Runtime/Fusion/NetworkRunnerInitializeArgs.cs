namespace Fusion;

internal struct NetworkRunnerInitializeArgs
{
	public Nullable<NetworkSceneInfo> Scene; //Field offset: 0x0
	public Nullable<NetAddress> Address; //Field offset: 0x38
	public Nullable<NetAddress> PublicAddress; //Field offset: 0x58
	public Nullable<Int32> PlayerCount; //Field offset: 0x78
	public Nullable<SimulationModes> SimulationMode; //Field offset: 0x80
	public Nullable<Int32> InputWordCount; //Field offset: 0x88
	public Nullable<Int32> SceneInfoWordCount; //Field offset: 0x90
	public NetworkProjectConfig Config; //Field offset: 0x98
	public Action<NetworkRunner> OnGameStarted; //Field offset: 0xA0
	public INetworkObjectProvider ObjectProvider; //Field offset: 0xA8
	public INetworkSceneManager SceneManager; //Field offset: 0xB0
	public INetworkRunnerUpdater Updater; //Field offset: 0xB8
	public INetworkObjectInitializer ObjectInitializer; //Field offset: 0xC0
	public Type[] CustomCallbackInterfaces; //Field offset: 0xC8
	public Byte[] ConnectionToken; //Field offset: 0xD0
	public Nullable<NetworkId> ResumeId; //Field offset: 0xD8
	public Nullable<Tick> ResumeTick; //Field offset: 0xE0
	public Byte[] ResumeState; //Field offset: 0xE8
	public Action<NetworkRunner> HostMigrationResume; //Field offset: 0xF0

	public bool IsSinglePlayer
	{
		 get { } //Length: 100
	}

	public bool get_IsSinglePlayer() { }

}

