namespace Photon.Realtime;

public class LoadBalancingClient : IPhotonPeerListener
{
	private class CallbackTargetChange
	{
		public readonly object Target; //Field offset: 0x10
		public readonly bool AddTarget; //Field offset: 0x18

		public CallbackTargetChange(object target, bool addTarget) { }

	}

	private class EncryptionDataParameters
	{
		public const byte Mode = 0; //Field offset: 0x0
		public const byte Secret1 = 1; //Field offset: 0x0
		public const byte Secret2 = 2; //Field offset: 0x0

		public EncryptionDataParameters() { }

	}

	private const int FriendRequestListMax = 512; //Field offset: 0x0
	private static readonly Dictionary<ConnectionProtocol, Int32> ProtocolToNameServerPort; //Field offset: 0x0
	[CompilerGenerated]
	private LoadBalancingPeer <LoadBalancingPeer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <AppVersion>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <AppId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ClientAppType <ClientType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private AuthenticationValues <AuthValues>k__BackingField; //Field offset: 0x30
	public AuthModeOption AuthMode; //Field offset: 0x38
	public EncryptionMode EncryptionMode; //Field offset: 0x3C
	[CompilerGenerated]
	private Nullable<ConnectionProtocol> <ExpectedProtocol>k__BackingField; //Field offset: 0x40
	private object tokenCache; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsUsingNameServer>k__BackingField; //Field offset: 0x50
	public string NameServerHost; //Field offset: 0x58
	[CompilerGenerated]
	private bool <UseAlternativeUdpPorts>k__BackingField; //Field offset: 0x60
	public PhotonPortDefinition ServerPortOverrides; //Field offset: 0x62
	[CompilerGenerated]
	private bool <EnableProtocolFallback>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private string <MasterServerAddress>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private string <GameServerAddress>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private ServerConnection <Server>k__BackingField; //Field offset: 0x80
	public string ProxyServerAddress; //Field offset: 0x88
	private ClientState state; //Field offset: 0x90
	[CompilerGenerated]
	private Action<ClientState, ClientState> StateChanged; //Field offset: 0x98
	[CompilerGenerated]
	private Action<EventData> EventReceived; //Field offset: 0xA0
	[CompilerGenerated]
	private Action<OperationResponse> OpResponseReceived; //Field offset: 0xA8
	public ConnectionCallbacksContainer ConnectionCallbackTargets; //Field offset: 0xB0
	public MatchMakingCallbacksContainer MatchMakingCallbackTargets; //Field offset: 0xB8
	internal InRoomCallbacksContainer InRoomCallbackTargets; //Field offset: 0xC0
	internal LobbyCallbacksContainer LobbyCallbackTargets; //Field offset: 0xC8
	internal WebRpcCallbacksContainer WebRpcCallbackTargets; //Field offset: 0xD0
	internal ErrorInfoCallbacksContainer ErrorInfoCallbackTargets; //Field offset: 0xD8
	[CompilerGenerated]
	private DisconnectCause <DisconnectedCause>k__BackingField; //Field offset: 0xE0
	public SystemConnectionSummary SystemConnectionSummary; //Field offset: 0xE8
	[CompilerGenerated]
	private TypedLobby <CurrentLobby>k__BackingField; //Field offset: 0xF0
	public bool EnableLobbyStatistics; //Field offset: 0xF8
	private readonly List<TypedLobbyInfo> lobbyStatistics; //Field offset: 0x100
	[CompilerGenerated]
	private Player <LocalPlayer>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private Room <CurrentRoom>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private int <PlayersOnMasterCount>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private int <PlayersInRoomsCount>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private int <RoomsCount>k__BackingField; //Field offset: 0x120
	private JoinType lastJoinType; //Field offset: 0x124
	private EnterRoomParams enterRoomParamsCache; //Field offset: 0x128
	private OperationResponse failedRoomEntryOperation; //Field offset: 0x130
	private String[] friendListRequested; //Field offset: 0x138
	[CompilerGenerated]
	private string <CloudRegion>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private string <CurrentCluster>k__BackingField; //Field offset: 0x148
	public RegionHandler RegionHandler; //Field offset: 0x150
	private string bestRegionSummaryFromStorage; //Field offset: 0x158
	public string SummaryToCache; //Field offset: 0x160
	private bool connectToBestRegion; //Field offset: 0x168
	private readonly Queue<CallbackTargetChange> callbackTargetChanges; //Field offset: 0x170
	private readonly HashSet<Object> callbackTargets; //Field offset: 0x178
	public int NameServerPortInAppSettings; //Field offset: 0x180

	public event Action<EventData> EventReceived
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<OperationResponse> OpResponseReceived
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<ClientState, ClientState> StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public string AppId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string AppVersion
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public AuthenticationValues AuthValues
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ClientAppType ClientType
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private string CloudRegion
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string CurrentCluster
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public internal TypedLobby CurrentLobby
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public Room CurrentRoom
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string CurrentServerAddress
	{
		 get { } //Length: 28
	}

	public DisconnectCause DisconnectedCause
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool EnableProtocolFallback
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Nullable<ConnectionProtocol> ExpectedProtocol
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private string GameServerAddress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool InLobby
	{
		 get { } //Length: 16
	}

	public bool InRoom
	{
		 get { } //Length: 36
	}

	public bool IsConnected
	{
		 get { } //Length: 44
	}

	public bool IsConnectedAndReady
	{
		 get { } //Length: 52
	}

	public bool IsFetchingFriendList
	{
		 get { } //Length: 16
	}

	public bool IsUsingNameServer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public private LoadBalancingPeer LoadBalancingPeer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public internal Player LocalPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public string MasterServerAddress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string NameServerAddress
	{
		 get { } //Length: 4
	}

	public string NickName
	{
		 get { } //Length: 28
		 set { } //Length: 16
	}

	public internal int PlayersInRoomsCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int PlayersOnMasterCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int RoomsCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public SerializationProtocol SerializationProtocol
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public private ServerConnection Server
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public ClientState State
	{
		 get { } //Length: 8
		 set { } //Length: 52
	}

	private object TokenForInit
	{
		private get { } //Length: 32
	}

	[Obsolete("Set port overrides in ServerPortOverrides. Not used anymore!")]
	public bool UseAlternativeUdpPorts
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public string UserId
	{
		 get { } //Length: 24
		 set { } //Length: 112
	}

	private static LoadBalancingClient() { }

	public LoadBalancingClient(ConnectionProtocol protocol = 0) { }

	public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = 0) { }

	[CompilerGenerated]
	public void add_EventReceived(Action<EventData> value) { }

	[CompilerGenerated]
	public void add_OpResponseReceived(Action<OperationResponse> value) { }

	[CompilerGenerated]
	public void add_StateChanged(Action<ClientState, ClientState> value) { }

	public void AddCallbackTarget(object target) { }

	private bool CallAuthenticate() { }

	private void CallbackRoomEnterFailed(OperationResponse operationResponse) { }

	public void ChangeLocalID(int newID) { }

	[Conditional("UNITY_WEBGL")]
	private void CheckConnectSetupWebGl() { }

	private bool CheckIfClientIsReadyToCallOperation(byte opCode) { }

	private bool CheckIfOpAllowedOnServer(byte opCode, ServerConnection serverConnection) { }

	private bool CheckIfOpCanBeSent(byte opCode, ServerConnection serverConnection, string opName) { }

	[Obsolete("Use ConnectToMasterServer() instead.")]
	public bool Connect() { }

	private bool Connect(string serverAddress, string proxyServerAddress, ServerConnection serverType) { }

	public override bool ConnectToMasterServer() { }

	public bool ConnectToNameServer() { }

	public bool ConnectToRegionMaster(string region) { }

	public override bool ConnectUsingSettings(AppSettings appSettings) { }

	protected private override Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties) { }

	protected private override Room CreateRoom(string roomName, RoomOptions opt) { }

	public override void DebugReturn(DebugLevel level, string message) { }

	public void Disconnect(DisconnectCause cause = 17) { }

	private void DisconnectToReconnect() { }

	private void GameEnteredOnGameServer(OperationResponse operationResponse) { }

	[CompilerGenerated]
	public string get_AppId() { }

	[CompilerGenerated]
	public string get_AppVersion() { }

	[CompilerGenerated]
	public AuthenticationValues get_AuthValues() { }

	[CompilerGenerated]
	public ClientAppType get_ClientType() { }

	[CompilerGenerated]
	public string get_CloudRegion() { }

	[CompilerGenerated]
	public string get_CurrentCluster() { }

	[CompilerGenerated]
	public TypedLobby get_CurrentLobby() { }

	[CompilerGenerated]
	public Room get_CurrentRoom() { }

	public string get_CurrentServerAddress() { }

	[CompilerGenerated]
	public DisconnectCause get_DisconnectedCause() { }

	[CompilerGenerated]
	public bool get_EnableProtocolFallback() { }

	[CompilerGenerated]
	public Nullable<ConnectionProtocol> get_ExpectedProtocol() { }

	[CompilerGenerated]
	public string get_GameServerAddress() { }

	public bool get_InLobby() { }

	public bool get_InRoom() { }

	public bool get_IsConnected() { }

	public bool get_IsConnectedAndReady() { }

	public bool get_IsFetchingFriendList() { }

	[CompilerGenerated]
	public bool get_IsUsingNameServer() { }

	[CompilerGenerated]
	public LoadBalancingPeer get_LoadBalancingPeer() { }

	[CompilerGenerated]
	public Player get_LocalPlayer() { }

	[CompilerGenerated]
	public string get_MasterServerAddress() { }

	public string get_NameServerAddress() { }

	public string get_NickName() { }

	[CompilerGenerated]
	public int get_PlayersInRoomsCount() { }

	[CompilerGenerated]
	public int get_PlayersOnMasterCount() { }

	[CompilerGenerated]
	public int get_RoomsCount() { }

	public SerializationProtocol get_SerializationProtocol() { }

	[CompilerGenerated]
	public ServerConnection get_Server() { }

	public ClientState get_State() { }

	private object get_TokenForInit() { }

	[CompilerGenerated]
	public bool get_UseAlternativeUdpPorts() { }

	public string get_UserId() { }

	private string GetNameServerAddress() { }

	private void OnDisconnectMessageReceived(DisconnectMessage obj) { }

	public override void OnEvent(EventData photonEvent) { }

	public override void OnMessage(object message) { }

	public override void OnOperationResponse(OperationResponse operationResponse) { }

	private void OnRegionPingCompleted(RegionHandler regionHandler) { }

	public override void OnStatusChanged(StatusCode statusCode) { }

	public override bool OpChangeGroups(Byte[] groupsToRemove, Byte[] groupsToAdd) { }

	public bool OpCreateRoom(EnterRoomParams enterRoomParams) { }

	public bool OpFindFriends(String[] friendsToFind, FindFriendsOptions options = null) { }

	public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter) { }

	private bool OpGetRegions() { }

	public bool OpJoinLobby(TypedLobby lobby) { }

	public bool OpJoinOrCreateRoom(EnterRoomParams enterRoomParams) { }

	public bool OpJoinRandomOrCreateRoom(OpJoinRandomRoomParams opJoinRandomRoomParams, EnterRoomParams createRoomParams) { }

	public bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams = null) { }

	public bool OpJoinRoom(EnterRoomParams enterRoomParams) { }

	public bool OpLeaveLobby() { }

	public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false) { }

	public override bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions) { }

	public bool OpRejoinRoom(string roomName) { }

	public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null) { }

	public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null) { }

	protected private bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webFlags = null) { }

	protected private bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webFlags = null) { }

	protected private bool OpSetPropertyOfRoom(byte propCode, object value) { }

	public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false) { }

	private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr) { }

	private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr) { }

	public bool ReconnectAndRejoin() { }

	public bool ReconnectToMaster() { }

	[CompilerGenerated]
	public void remove_EventReceived(Action<EventData> value) { }

	[CompilerGenerated]
	public void remove_OpResponseReceived(Action<OperationResponse> value) { }

	[CompilerGenerated]
	public void remove_StateChanged(Action<ClientState, ClientState> value) { }

	public void RemoveCallbackTarget(object target) { }

	protected private static string ReplacePortWithAlternative(string address, ushort replacementPort) { }

	public void Service() { }

	[CompilerGenerated]
	public void set_AppId(string value) { }

	[CompilerGenerated]
	public void set_AppVersion(string value) { }

	[CompilerGenerated]
	public void set_AuthValues(AuthenticationValues value) { }

	[CompilerGenerated]
	public void set_ClientType(ClientAppType value) { }

	[CompilerGenerated]
	private void set_CloudRegion(string value) { }

	[CompilerGenerated]
	private void set_CurrentCluster(string value) { }

	[CompilerGenerated]
	internal void set_CurrentLobby(TypedLobby value) { }

	[CompilerGenerated]
	public void set_CurrentRoom(Room value) { }

	[CompilerGenerated]
	protected void set_DisconnectedCause(DisconnectCause value) { }

	[CompilerGenerated]
	public void set_EnableProtocolFallback(bool value) { }

	[CompilerGenerated]
	public void set_ExpectedProtocol(Nullable<ConnectionProtocol> value) { }

	[CompilerGenerated]
	protected private void set_GameServerAddress(string value) { }

	[CompilerGenerated]
	public void set_IsUsingNameServer(bool value) { }

	[CompilerGenerated]
	private void set_LoadBalancingPeer(LoadBalancingPeer value) { }

	[CompilerGenerated]
	internal void set_LocalPlayer(Player value) { }

	[CompilerGenerated]
	public void set_MasterServerAddress(string value) { }

	public void set_NickName(string value) { }

	[CompilerGenerated]
	internal void set_PlayersInRoomsCount(int value) { }

	[CompilerGenerated]
	internal void set_PlayersOnMasterCount(int value) { }

	[CompilerGenerated]
	internal void set_RoomsCount(int value) { }

	public void set_SerializationProtocol(SerializationProtocol value) { }

	[CompilerGenerated]
	private void set_Server(ServerConnection value) { }

	public void set_State(ClientState value) { }

	[CompilerGenerated]
	public void set_UseAlternativeUdpPorts(bool value) { }

	public void set_UserId(string value) { }

	private void SetupEncryption(Dictionary<Byte, Object> encryptionData) { }

	public void SimulateConnectionLoss(bool simulateTimeout) { }

	private void UpdateCallbackTarget(CallbackTargetChange change, List<T> container) { }

	protected private void UpdateCallbackTargets() { }

	private void UpdatedActorList(Int32[] actorsInGame) { }

}

