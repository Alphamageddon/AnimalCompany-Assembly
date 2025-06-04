namespace Photon.Realtime;

public class LoadBalancingPeer : PhotonPeer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ParameterDictionary> <>9__4_0; //Field offset: 0x8
		public static Action<ParameterDictionary> <>9__4_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal ParameterDictionary <.ctor>b__4_0() { }

		internal void <.ctor>b__4_1(ParameterDictionary x) { }

	}

	private readonly Pool<ParameterDictionary> paramDictionaryPool; //Field offset: 0x110

	[Obsolete("Use RegionHandler.PingImplementation directly.")]
	protected private static Type PingImplementation
	{
		private get { } //Length: 72
		private set { } //Length: 76
	}

	public LoadBalancingPeer(ConnectionProtocol protocolType) { }

	public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType) { }

	[Conditional("SUPPORTED_UNITY")]
	private void ConfigUnitySockets() { }

	protected private static Type get_PingImplementation() { }

	public override bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics) { }

	public override bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol) { }

	public override bool OpChangeGroups(Byte[] groupsToRemove, Byte[] groupsToAdd) { }

	public override bool OpCreateRoom(EnterRoomParams opParams) { }

	public override bool OpFindFriends(String[] friendsToFind, FindFriendsOptions options = null) { }

	public override bool OpGetGameList(TypedLobby lobby, string queryData) { }

	public override bool OpGetRegions(string appId) { }

	public override bool OpJoinLobby(TypedLobby lobby = null) { }

	public override bool OpJoinRandomOrCreateRoom(OpJoinRandomRoomParams opJoinRandomRoomParams, EnterRoomParams createRoomParams) { }

	public override bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams) { }

	public override bool OpJoinRoom(EnterRoomParams opParams) { }

	public override bool OpLeaveLobby() { }

	public override bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false) { }

	public override bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions) { }

	public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties) { }

	public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties) { }

	protected private bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webflags = null) { }

	protected private bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webflags = null) { }

	protected bool OpSetPropertyOfRoom(byte propCode, object value) { }

	public override bool OpSettings(bool receiveLobbyStats) { }

	private void RoomOptionsToOpParameters(Dictionary<Byte, Object> op, RoomOptions roomOptions, bool usePropertiesKey = false) { }

	protected private static void set_PingImplementation(Type value) { }

}

