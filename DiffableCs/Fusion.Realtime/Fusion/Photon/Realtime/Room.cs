namespace Fusion.Photon.Realtime;

internal class Room : RoomInfo
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LoadBalancingClient <LoadBalancingClient>k__BackingField; //Field offset: 0x60
	private bool isOffline; //Field offset: 0x68
	private Dictionary<Int32, Player> players; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <BroadcastPropertiesChangeToAll>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <SuppressRoomEvents>k__BackingField; //Field offset: 0x79
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <SuppressPlayerInfo>k__BackingField; //Field offset: 0x7A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <PublishUserId>k__BackingField; //Field offset: 0x7B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <DeleteNullProperties>k__BackingField; //Field offset: 0x7C

	public bool AutoCleanUp
	{
		 get { } //Length: 8
	}

	public private bool BroadcastPropertiesChangeToAll
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private bool DeleteNullProperties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public int EmptyRoomTtl
	{
		 get { } //Length: 8
		 set { } //Length: 148
	}

	public String[] ExpectedUsers
	{
		 get { } //Length: 8
	}

	public private bool IsOffline
	{
		 get { } //Length: 8
		private set { } //Length: 12
	}

	public bool IsOpen
	{
		 get { } //Length: 8
		 set { } //Length: 216
	}

	public bool IsVisible
	{
		 get { } //Length: 8
		 set { } //Length: 216
	}

	public LoadBalancingClient LoadBalancingClient
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int MasterClientId
	{
		 get { } //Length: 8
	}

	public int MaxPlayers
	{
		 get { } //Length: 8
		 set { } //Length: 292
	}

	public internal string Name
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public int PlayerCount
	{
		 get { } //Length: 84
	}

	public private Dictionary<Int32, Player> Players
	{
		 get { } //Length: 8
		private set { } //Length: 8
	}

	public int PlayerTtl
	{
		 get { } //Length: 8
		 set { } //Length: 148
	}

	public private String[] PropertiesListedInLobby
	{
		 get { } //Length: 8
		private set { } //Length: 8
	}

	public private bool PublishUserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private bool SuppressPlayerInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private bool SuppressRoomEvents
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Room(string roomName, RoomOptions options, bool isOffline = false) { }

	public override bool AddPlayer(Player player) { }

	public bool ClearExpectedUsers() { }

	public bool get_AutoCleanUp() { }

	[CompilerGenerated]
	public bool get_BroadcastPropertiesChangeToAll() { }

	[CompilerGenerated]
	public bool get_DeleteNullProperties() { }

	public int get_EmptyRoomTtl() { }

	public String[] get_ExpectedUsers() { }

	public bool get_IsOffline() { }

	public bool get_IsOpen() { }

	public bool get_IsVisible() { }

	[CompilerGenerated]
	public LoadBalancingClient get_LoadBalancingClient() { }

	public int get_MasterClientId() { }

	public int get_MaxPlayers() { }

	public string get_Name() { }

	public int get_PlayerCount() { }

	public Dictionary<Int32, Player> get_Players() { }

	public int get_PlayerTtl() { }

	public String[] get_PropertiesListedInLobby() { }

	[CompilerGenerated]
	public bool get_PublishUserId() { }

	[CompilerGenerated]
	public bool get_SuppressPlayerInfo() { }

	[CompilerGenerated]
	public bool get_SuppressRoomEvents() { }

	public override Player GetPlayer(int id, bool findMaster = false) { }

	protected private virtual void InternalCacheProperties(Hashtable propertiesToCache) { }

	internal void InternalCacheRoomFlags(int roomFlags) { }

	protected private override void RemovePlayer(int id) { }

	protected private override void RemovePlayer(Player player) { }

	[CompilerGenerated]
	private void set_BroadcastPropertiesChangeToAll(bool value) { }

	[CompilerGenerated]
	private void set_DeleteNullProperties(bool value) { }

	public void set_EmptyRoomTtl(int value) { }

	private void set_IsOffline(bool value) { }

	public void set_IsOpen(bool value) { }

	public void set_IsVisible(bool value) { }

	[CompilerGenerated]
	public void set_LoadBalancingClient(LoadBalancingClient value) { }

	public void set_MaxPlayers(int value) { }

	internal void set_Name(string value) { }

	private void set_Players(Dictionary<Int32, Player> value) { }

	public void set_PlayerTtl(int value) { }

	private void set_PropertiesListedInLobby(String[] value) { }

	[CompilerGenerated]
	private void set_PublishUserId(bool value) { }

	[CompilerGenerated]
	private void set_SuppressPlayerInfo(bool value) { }

	[CompilerGenerated]
	private void set_SuppressRoomEvents(bool value) { }

	public override bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null) { }

	public bool SetExpectedUsers(String[] newExpectedUsers) { }

	private bool SetExpectedUsers(String[] newExpectedUsers, String[] oldExpectedUsers) { }

	public bool SetMasterClient(Player masterClientPlayer) { }

	public bool SetPropertiesListedInLobby(String[] lobbyProps) { }

	public override Player StorePlayer(Player player) { }

	public virtual string ToString() { }

	public string ToStringFull() { }

}

