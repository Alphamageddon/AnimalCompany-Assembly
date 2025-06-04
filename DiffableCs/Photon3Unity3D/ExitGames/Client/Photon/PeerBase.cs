namespace ExitGames.Client.Photon;

public abstract class PeerBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass108_0
	{
		public PeerBase <>4__this; //Field offset: 0x10
		public DebugLevel level; //Field offset: 0x18
		public string debugReturn; //Field offset: 0x20

		public <>c__DisplayClass108_0() { }

		internal void <EnqueueDebugReturn>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass109_0
	{
		public PeerBase <>4__this; //Field offset: 0x10
		public StatusCode statusValue; //Field offset: 0x18

		public <>c__DisplayClass109_0() { }

		internal void <EnqueueStatusCallback>b__0() { }

	}

	private static class GpBinaryV3Parameters
	{
		public const byte CustomObject = 0; //Field offset: 0x0
		public const byte ExtraPlatformParams = 1; //Field offset: 0x0

	}

	public sealed class MyAction : MulticastDelegate
	{

		public MyAction(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal static short peerCount; //Field offset: 0x0
	protected private static Queue<StreamBuffer> MessageBufferPool; //Field offset: 0x8
	internal PhotonPeer photonPeer; //Field offset: 0x10
	public IProtocol SerializationProtocol; //Field offset: 0x18
	internal ConnectionProtocol usedTransportProtocol; //Field offset: 0x20
	internal IPhotonSocket PhotonSocket; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <ServerAddress>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <ProxyServerAddress>k__BackingField; //Field offset: 0x38
	internal ConnectionStateValue peerConnectionState; //Field offset: 0x40
	internal int ByteCountLastOperation; //Field offset: 0x44
	internal int ByteCountCurrentDispatch; //Field offset: 0x48
	internal NCommand CommandInCurrentDispatch; //Field offset: 0x50
	internal int packetLossByCrc; //Field offset: 0x58
	internal int packetLossByChallenge; //Field offset: 0x5C
	internal readonly Queue<MyAction> ActionQueue; //Field offset: 0x60
	internal short peerID; //Field offset: 0x68
	internal int serverTimeOffset; //Field offset: 0x6C
	internal bool serverTimeOffsetIsAvailable; //Field offset: 0x70
	internal int roundTripTime; //Field offset: 0x74
	internal int roundTripTimeVariance; //Field offset: 0x78
	internal int lastRoundTripTime; //Field offset: 0x7C
	internal int lowestRoundTripTime; //Field offset: 0x80
	internal int highestRoundTripTimeVariance; //Field offset: 0x84
	internal int timestampOfLastReceive; //Field offset: 0x88
	internal long bytesOut; //Field offset: 0x90
	internal long bytesIn; //Field offset: 0x98
	internal object PhotonToken; //Field offset: 0xA0
	internal object CustomInitData; //Field offset: 0xA8
	public string AppId; //Field offset: 0xB0
	internal EventData reusableEventData; //Field offset: 0xB8
	private Stopwatch watch; //Field offset: 0xC0
	internal int timeoutInt; //Field offset: 0xC8
	internal int timeLastAckReceive; //Field offset: 0xCC
	internal int longestSentCall; //Field offset: 0xD0
	internal int timeLastSendAck; //Field offset: 0xD4
	internal int timeLastSendOutgoing; //Field offset: 0xD8
	internal bool ApplicationIsInitialized; //Field offset: 0xDC
	internal bool isEncryptionAvailable; //Field offset: 0xDD
	internal int outgoingCommandsInStream; //Field offset: 0xE0
	internal Byte[] messageHeader; //Field offset: 0xE8
	internal ICryptoProvider CryptoProvider; //Field offset: 0xF0
	private readonly Random lagRandomizer; //Field offset: 0xF8
	internal readonly LinkedList<SimulationItem> NetSimListOutgoing; //Field offset: 0x100
	internal readonly LinkedList<SimulationItem> NetSimListIncoming; //Field offset: 0x108
	private readonly NetworkSimulationSet networkSimulationSettings; //Field offset: 0x110
	internal int TrafficPackageHeaderSize; //Field offset: 0x118

	internal long BytesIn
	{
		internal get { } //Length: 8
	}

	internal long BytesOut
	{
		internal get { } //Length: 8
	}

	internal byte ChannelCount
	{
		internal get { } //Length: 28
	}

	public DebugLevel debugOut
	{
		 get { } //Length: 28
	}

	internal int DisconnectTimeout
	{
		internal get { } //Length: 28
	}

	protected private bool IsIpv6
	{
		private get { } //Length: 32
	}

	internal IPhotonPeerListener Listener
	{
		internal get { } //Length: 28
	}

	internal int mtu
	{
		internal get { } //Length: 28
	}

	public NetworkSimulationSet NetworkSimulationSettings
	{
		 get { } //Length: 8
	}

	internal static int outgoingStreamBufferSize
	{
		internal get { } //Length: 88
	}

	public override string PeerID
	{
		 get { } //Length: 32
	}

	public internal string ProxyServerAddress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal abstract int QueuedIncomingCommandsCount
	{
		internal get { } //Length: 0
	}

	internal abstract int QueuedOutgoingCommandsCount
	{
		internal get { } //Length: 0
	}

	internal override int SentReliableCommandsCount
	{
		internal get { } //Length: 8
	}

	public internal string ServerAddress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal int timeInt
	{
		internal get { } //Length: 32
	}

	internal int timePingInterval
	{
		internal get { } //Length: 28
	}

	internal bool TrafficStatsEnabled
	{
		internal get { } //Length: 28
	}

	internal TrafficStatsGameLevel TrafficStatsGameLevel
	{
		internal get { } //Length: 28
	}

	internal TrafficStats TrafficStatsIncoming
	{
		internal get { } //Length: 28
	}

	internal TrafficStats TrafficStatsOutgoing
	{
		internal get { } //Length: 28
	}

	private static PeerBase() { }

	protected PeerBase() { }

	internal abstract bool Connect(string serverAddress, string proxyServerAddress, string appID, object photonToken) { }

	internal void DeriveSharedKey(OperationResponse operationResponse) { }

	internal override bool DeserializeMessageAndCallback(StreamBuffer stream) { }

	internal abstract void Disconnect() { }

	internal abstract bool DispatchIncomingCommands() { }

	internal void EnqueueActionForDispatch(MyAction action) { }

	internal void EnqueueDebugReturn(DebugLevel level, string debugReturn) { }

	internal abstract bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams) { }

	internal void EnqueueStatusCallback(StatusCode statusValue) { }

	internal bool ExchangeKeysForEncryption(object lockObject) { }

	internal abstract void FetchServerTimestamp() { }

	internal long get_BytesIn() { }

	internal long get_BytesOut() { }

	internal byte get_ChannelCount() { }

	public DebugLevel get_debugOut() { }

	internal int get_DisconnectTimeout() { }

	protected private bool get_IsIpv6() { }

	internal IPhotonPeerListener get_Listener() { }

	internal int get_mtu() { }

	public NetworkSimulationSet get_NetworkSimulationSettings() { }

	internal static int get_outgoingStreamBufferSize() { }

	public override string get_PeerID() { }

	[CompilerGenerated]
	public string get_ProxyServerAddress() { }

	internal abstract int get_QueuedIncomingCommandsCount() { }

	internal abstract int get_QueuedOutgoingCommandsCount() { }

	internal override int get_SentReliableCommandsCount() { }

	[CompilerGenerated]
	public string get_ServerAddress() { }

	internal int get_timeInt() { }

	internal int get_timePingInterval() { }

	internal bool get_TrafficStatsEnabled() { }

	internal TrafficStatsGameLevel get_TrafficStatsGameLevel() { }

	internal TrafficStats get_TrafficStatsIncoming() { }

	internal TrafficStats get_TrafficStatsOutgoing() { }

	private string GetHttpKeyValueString(Dictionary<String, String> dic) { }

	internal void InitCallback() { }

	internal override void InitEncryption(Byte[] secret) { }

	internal abstract bool IsTransportEncrypted() { }

	public static StreamBuffer MessageBufferPoolGet() { }

	public static void MessageBufferPoolPut(StreamBuffer buff) { }

	protected private void NetworkSimRun() { }

	public abstract void OnConnect() { }

	internal string PrepareWebSocketUrl(string serverAddress, string appId, object photonToken) { }

	internal abstract void ReceiveIncomingCommands(Byte[] inBuff, int dataLength) { }

	internal void ReceiveNetworkSimulated(Byte[] dataReceived) { }

	internal override void Reset() { }

	internal override bool SendAcksOnly() { }

	internal void SendNetworkSimulated(Byte[] dataToSend) { }

	internal abstract bool SendOutgoingCommands() { }

	internal StreamBuffer SerializeMessageToMessage(object message, bool encrypt) { }

	internal StreamBuffer SerializeOperationToMessage(byte opCode, ParameterDictionary parameters, EgMessageType messageType, bool encrypt) { }

	internal StreamBuffer SerializeOperationToMessage(byte opCode, Dictionary<Byte, Object> parameters, EgMessageType messageType, bool encrypt) { }

	[CompilerGenerated]
	internal void set_ProxyServerAddress(string value) { }

	[CompilerGenerated]
	internal void set_ServerAddress(string value) { }

	internal abstract void StopConnection() { }

	internal void UpdateRoundTripTimeAndVariance(int lastRoundtripTime) { }

	internal Byte[] WriteInitRequest() { }

	private Byte[] WriteInitV3() { }

}

