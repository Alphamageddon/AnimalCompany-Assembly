namespace Fusion.Photon.Realtime;

internal class FusionRelayClient : LoadBalancingClient, IInRoomCallbacks, IMatchmakingCallbacks, ILobbyCallbacks
{
	private const string FUSION_PLUGIN_NAME = "FusionPlugin"; //Field offset: 0x0
	private const string SERVER_HOST_CN = "ns.photonengine.cn"; //Field offset: 0x0
	private const string REGION_CN_ID = "cn"; //Field offset: 0x0
	private ConnectionHandler _connectionHandler; //Field offset: 0x188
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action OnRoomChanged; //Field offset: 0x190
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UseDefaultPorts>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Int32, Int32, Object> OnEventCallback; //Field offset: 0x1A0
	private readonly RaiseEventOptions _raiseEventOptions; //Field offset: 0x1A8
	private readonly SendOptions _optionsUnreliable; //Field offset: 0x1B0
	private readonly SendOptions _optionsReliable; //Field offset: 0x1B8
	private FusionAppSettings Config; //Field offset: 0x1C0

	public event Action<Int32, Int32, Object> OnEventCallback
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public event Action OnRoomChanged
	{
		[CompilerGenerated]
		 add { } //Length: 160
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	public int DisconnectTimeout
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public bool IsEncryptionEnabled
	{
		 get { } //Length: 16
	}

	public bool IsReadyAndInRoom
	{
		 get { } //Length: 56
	}

	public bool UseDefaultPorts
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public FusionRelayClient(FusionAppSettings config) { }

	[CompilerGenerated]
	public void add_OnEventCallback(Action<Int32, Int32, Object> value) { }

	[CompilerGenerated]
	public void add_OnRoomChanged(Action value) { }

	public EnterRoomParams BuildEnterRoomParams(TypedLobby typedLobby, string roomName, int maxPlayers, Dictionary<String, SessionProperty> customProperties = null, bool isOpen = true, bool isVisible = true, bool useDefaultEmptyRoomTtl = true, bool extendedTtl = false) { }

	public OpJoinRandomRoomParams BuildJoinParams(TypedLobby typedLobby, Dictionary<String, SessionProperty> customProperties = null, MatchmakingMode matchmakingMode = 0) { }

	private static void BuildSessionCustomPropertyHolders(Dictionary<String, SessionProperty> customProperties, out Hashtable sessionCustomProperties, out String[] publicSessionProperties) { }

	public virtual bool ConnectUsingSettings(AppSettings appSettings) { }

	public void ExtractData(object dataObj, Byte[] buffer, ref int bufferLength) { }

	public int get_DisconnectTimeout() { }

	public bool get_IsEncryptionEnabled() { }

	public bool get_IsReadyAndInRoom() { }

	[CompilerGenerated]
	public bool get_UseDefaultPorts() { }

	private static Type LoadPhotonEncryptorType() { }

	public override void OnCreatedRoom() { }

	public override void OnCreateRoomFailed(short returnCode, string message) { }

	private void OnEventHandler(EventData evt) { }

	public override void OnFriendListUpdate(List<FriendInfo> friendList) { }

	public override void OnJoinedLobby() { }

	public override void OnJoinedRoom() { }

	public override void OnJoinRandomFailed(short returnCode, string message) { }

	public override void OnJoinRoomFailed(short returnCode, string message) { }

	public override void OnLeftLobby() { }

	public override void OnLeftRoom() { }

	public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }

	public override void OnMasterClientSwitched(Player newMasterClient) { }

	public override void OnPlayerEnteredRoom(Player newPlayer) { }

	public override void OnPlayerLeftRoom(Player otherPlayer) { }

	public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps) { }

	public override void OnRoomListUpdate(List<RoomInfo> roomList) { }

	public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) { }

	[CompilerGenerated]
	public void remove_OnEventCallback(Action<Int32, Int32, Object> value) { }

	[CompilerGenerated]
	public void remove_OnRoomChanged(Action value) { }

	public void Reset() { }

	public bool SendEvent(int target, byte eventCode, Byte* buffer, int bufferLength, bool reliable) { }

	public void set_DisconnectTimeout(int value) { }

	[CompilerGenerated]
	public void set_UseDefaultPorts(bool value) { }

	public void StartFallbackSendAck() { }

	public void StopFallbackSendAck() { }

	public void Update() { }

	public bool UpdateRoomIsOpen(bool value) { }

	public bool UpdateRoomIsVisible(bool value) { }

	public bool UpdateRoomProperties(Dictionary<String, SessionProperty> customProperties) { }

}

