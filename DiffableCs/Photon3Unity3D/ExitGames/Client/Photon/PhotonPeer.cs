namespace ExitGames.Client.Photon;

public class PhotonPeer
{
	[Obsolete("Where dynamic linking is available, this library will attempt to load it and fallback to a managed implementation. This value is always true.")]
	public const bool NativeDatagramEncrypt = True; //Field offset: 0x0
	public const bool NoSocket = False; //Field offset: 0x0
	public const bool DebugBuild = True; //Field offset: 0x0
	public const int NativeEncryptorApiVersion = 2; //Field offset: 0x0
	public static bool NoNativeCallbacks; //Field offset: 0x0
	private static string clientVersion; //Field offset: 0x8
	[Obsolete("A Native Socket implementation is no longer part of this DLL but delivered in a separate add-on. This value always returns false.")]
	public static readonly bool NativeSocketLibAvailable; //Field offset: 0x10
	[Obsolete("Native Payload Encryption is no longer part of this DLL but delivered in a separate add-on. This value always returns false.")]
	public static readonly bool NativePayloadEncryptionLibAvailable; //Field offset: 0x11
	[Obsolete("Native Datagram Encryption is no longer part of this DLL but delivered in a separate add-on. This value always returns false.")]
	public static readonly bool NativeDatagramEncryptionLibAvailable; //Field offset: 0x12
	public static int OutgoingStreamBufferSize; //Field offset: 0x14
	public static bool AsyncKeyExchange; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <CommandBufferSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LimitOfUnreliableCommands>k__BackingField; //Field offset: 0x14
	[Obsolete("Check QueuedOutgoingCommands and QueuedIncomingCommands on demand instead.")]
	public int WarningSize; //Field offset: 0x18
	[Obsolete("Use the ITrafficRecorder to capture all traffic instead.")]
	public int CommandLogSize; //Field offset: 0x1C
	public TargetFrameworks TargetFramework; //Field offset: 0x20
	public bool RemoveAppIdFromWebSocketPath; //Field offset: 0x24
	protected private byte ClientSdkId; //Field offset: 0x25
	internal bool UseInitV3; //Field offset: 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private SerializationProtocol <SerializationProtocolType>k__BackingField; //Field offset: 0x28
	public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Type <SocketImplementation>k__BackingField; //Field offset: 0x38
	public DebugLevel DebugOut; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IPhotonPeerListener <Listener>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<DisconnectMessage> OnDisconnectMessage; //Field offset: 0x50
	private bool reuseEventInstance; //Field offset: 0x58
	private bool useByteArraySlicePoolForEvents; //Field offset: 0x59
	private bool wrapIncomingStructs; //Field offset: 0x5A
	public bool SendInCreationOrder; //Field offset: 0x5B
	public int SendWindowSize; //Field offset: 0x5C
	public ITrafficRecorder TrafficRecorder; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <EnableServerTracing>k__BackingField; //Field offset: 0x68
	private byte quickResendAttempts; //Field offset: 0x69
	public byte ChannelCount; //Field offset: 0x6A
	public bool EnableEncryptedFlag; //Field offset: 0x6B
	private bool crcEnabled; //Field offset: 0x6C
	public int SentCountAllowance; //Field offset: 0x70
	public int InitialResendTimeMax; //Field offset: 0x74
	public int TimePingInterval; //Field offset: 0x78
	public bool PingUsedAsInit; //Field offset: 0x7C
	private int disconnectTimeout; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ConnectionProtocol <TransportProtocol>k__BackingField; //Field offset: 0x84
	private int mtu; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsSendingOnlyAcks>k__BackingField; //Field offset: 0x8C
	internal bool RandomizeSequenceNumbers; //Field offset: 0x8D
	internal Byte[] RandomizedSequenceNumbers; //Field offset: 0x90
	internal bool GcmDatagramEncryption; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TrafficStats <TrafficStatsIncoming>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TrafficStats <TrafficStatsOutgoing>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TrafficStatsGameLevel <TrafficStatsGameLevel>k__BackingField; //Field offset: 0xB0
	private Stopwatch trafficStatsStopwatch; //Field offset: 0xB8
	private bool trafficStatsEnabled; //Field offset: 0xC0
	internal PeerBase peerBase; //Field offset: 0xC8
	private readonly object SendOutgoingLockObject; //Field offset: 0xD0
	private readonly object DispatchLockObject; //Field offset: 0xD8
	private readonly object EnqueueLock; //Field offset: 0xE0
	private Type payloadEncryptorType; //Field offset: 0xE8
	protected private Byte[] PayloadEncryptionSecret; //Field offset: 0xF0
	private Type encryptorType; //Field offset: 0xF8
	protected private IPhotonEncryptor Encryptor; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <CountDiscarded>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <DeltaUnreliableNumber>k__BackingField; //Field offset: 0x10C

	public event Action<DisconnectMessage> OnDisconnectMessage
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public ByteArraySlicePool ByteArraySlicePool
	{
		 get { } //Length: 36
	}

	public int ByteCountCurrentDispatch
	{
		 get { } //Length: 28
	}

	public int ByteCountLastOperation
	{
		 get { } //Length: 28
	}

	public long BytesIn
	{
		 get { } //Length: 28
	}

	public long BytesOut
	{
		 get { } //Length: 28
	}

	protected private byte ClientSdkIdShifted
	{
		private get { } //Length: 12
	}

	[Obsolete("The static string Version should be preferred.")]
	public string ClientVersion
	{
		 get { } //Length: 704
	}

	[Obsolete("See remarks.")]
	public int CommandBufferSize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string CommandInfoCurrentDispatch
	{
		 get { } //Length: 116
	}

	public int ConnectionTime
	{
		 get { } //Length: 28
	}

	public int CountDiscarded
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool CrcEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 124
	}

	public int DeltaUnreliableNumber
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int DisconnectTimeout
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool EnableServerTracing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Type EncryptorType
	{
		 get { } //Length: 8
		 set { } //Length: 360
	}

	public bool IsEncryptionAvailable
	{
		 get { } //Length: 28
	}

	[Obsolete("Internally not used anymore. Call SendAcksOnly() instead.")]
	public bool IsSendingOnlyAcks
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override bool IsSimulationEnabled
	{
		 get { } //Length: 40
		 set { } //Length: 280
	}

	public int LastRoundTripTime
	{
		 get { } //Length: 28
	}

	public int LastSendAckTime
	{
		 get { } //Length: 28
	}

	public int LastSendOutgoingTime
	{
		 get { } //Length: 28
	}

	[Obsolete("See remarks.")]
	public int LimitOfUnreliableCommands
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IPhotonPeerListener Listener
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Obsolete("The PhotonPeer will no longer use this delegate. It uses a Stopwatch in all cases. You can access PhotonPeer.ConnectionTime.")]
	public IntegerMillisecondsDelegate LocalMsTimestampDelegate
	{
		 set { } //Length: 260
	}

	[Obsolete("Returns SupportClass.GetTickCount(). Should be replaced by a StopWatch or the per peer PhotonPeer.ClientTime.")]
	public int LocalTimeInMilliSeconds
	{
		 get { } //Length: 80
	}

	public int LongestSentCall
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public int MaximumTransferUnit
	{
		 get { } //Length: 8
		 set { } //Length: 196
	}

	public NetworkSimulationSet NetworkSimulationSettings
	{
		 get { } //Length: 28
	}

	public int PacketLossByChallenge
	{
		 get { } //Length: 28
	}

	public int PacketLossByCrc
	{
		 get { } //Length: 28
	}

	public Type PayloadEncryptorType
	{
		 get { } //Length: 8
		 set { } //Length: 360
	}

	public string PeerID
	{
		 get { } //Length: 32
	}

	public PeerStateValue PeerState
	{
		 get { } //Length: 48
	}

	public int QueuedIncomingCommands
	{
		 get { } //Length: 32
	}

	public int QueuedOutgoingCommands
	{
		 get { } //Length: 32
	}

	public byte QuickResendAttempts
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public int ResentReliableCommands
	{
		 get { } //Length: 144
	}

	public bool ReuseEventInstance
	{
		 get { } //Length: 8
		 set { } //Length: 224
	}

	public int RoundTripTime
	{
		 get { } //Length: 28
	}

	public int RoundTripTimeVariance
	{
		 get { } //Length: 28
	}

	public int SentReliableCommandsCount
	{
		 get { } //Length: 32
	}

	[Obsolete("Use SendWindowSize instead.")]
	public int SequenceDeltaLimitSends
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public SerializationProtocol SerializationProtocolType
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string ServerAddress
	{
		 get { } //Length: 28
	}

	public string ServerIpAddress
	{
		 get { } //Length: 64
	}

	public int ServerTimeInMilliSeconds
	{
		 get { } //Length: 56
	}

	public int SocketErrorCode
	{
		 get { } //Length: 32
	}

	public internal Type SocketImplementation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public int TimestampOfLastSocketReceive
	{
		 get { } //Length: 28
	}

	public long TrafficStatsElapsedMs
	{
		 get { } //Length: 20
	}

	public bool TrafficStatsEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 96
	}

	public internal TrafficStatsGameLevel TrafficStatsGameLevel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal TrafficStats TrafficStatsIncoming
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal TrafficStats TrafficStatsOutgoing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public ConnectionProtocol TransportProtocol
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool UseByteArraySlicePoolForEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public ConnectionProtocol UsedProtocol
	{
		 get { } //Length: 28
	}

	public static string Version
	{
		 get { } //Length: 704
	}

	public bool WrapIncomingStructs
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	private static PhotonPeer() { }

	public PhotonPeer(ConnectionProtocol protocolType) { }

	public PhotonPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType) { }

	[CompilerGenerated]
	private bool <EstablishEncryption>b__225_0() { }

	[CompilerGenerated]
	public void add_OnDisconnectMessage(Action<DisconnectMessage> value) { }

	[Obsolete("Use the ITrafficRecorder to capture all traffic instead.")]
	public string CommandLogToString() { }

	public override bool Connect(string serverAddress, string appId, object photonToken = null, object customInitData = null) { }

	public override bool Connect(string serverAddress, string proxyServerAddress, string appId, object photonToken, object customInitData = null) { }

	private void CreatePeerBase() { }

	public override void Disconnect() { }

	public override bool DispatchIncomingCommands() { }

	public bool EstablishEncryption() { }

	public override void FetchServerTimestamp() { }

	public ByteArraySlicePool get_ByteArraySlicePool() { }

	public int get_ByteCountCurrentDispatch() { }

	public int get_ByteCountLastOperation() { }

	public long get_BytesIn() { }

	public long get_BytesOut() { }

	protected private byte get_ClientSdkIdShifted() { }

	public string get_ClientVersion() { }

	[CompilerGenerated]
	public int get_CommandBufferSize() { }

	public string get_CommandInfoCurrentDispatch() { }

	public int get_ConnectionTime() { }

	[CompilerGenerated]
	public int get_CountDiscarded() { }

	public bool get_CrcEnabled() { }

	[CompilerGenerated]
	public int get_DeltaUnreliableNumber() { }

	public int get_DisconnectTimeout() { }

	[CompilerGenerated]
	public bool get_EnableServerTracing() { }

	public Type get_EncryptorType() { }

	public bool get_IsEncryptionAvailable() { }

	[CompilerGenerated]
	public bool get_IsSendingOnlyAcks() { }

	public override bool get_IsSimulationEnabled() { }

	public int get_LastRoundTripTime() { }

	public int get_LastSendAckTime() { }

	public int get_LastSendOutgoingTime() { }

	[CompilerGenerated]
	public int get_LimitOfUnreliableCommands() { }

	[CompilerGenerated]
	public IPhotonPeerListener get_Listener() { }

	public int get_LocalTimeInMilliSeconds() { }

	public int get_LongestSentCall() { }

	public int get_MaximumTransferUnit() { }

	public NetworkSimulationSet get_NetworkSimulationSettings() { }

	public int get_PacketLossByChallenge() { }

	public int get_PacketLossByCrc() { }

	public Type get_PayloadEncryptorType() { }

	public string get_PeerID() { }

	public PeerStateValue get_PeerState() { }

	public int get_QueuedIncomingCommands() { }

	public int get_QueuedOutgoingCommands() { }

	public byte get_QuickResendAttempts() { }

	public int get_ResentReliableCommands() { }

	public bool get_ReuseEventInstance() { }

	public int get_RoundTripTime() { }

	public int get_RoundTripTimeVariance() { }

	public int get_SentReliableCommandsCount() { }

	public int get_SequenceDeltaLimitSends() { }

	[CompilerGenerated]
	public SerializationProtocol get_SerializationProtocolType() { }

	public string get_ServerAddress() { }

	public string get_ServerIpAddress() { }

	public int get_ServerTimeInMilliSeconds() { }

	public int get_SocketErrorCode() { }

	[CompilerGenerated]
	public Type get_SocketImplementation() { }

	public int get_TimestampOfLastSocketReceive() { }

	public long get_TrafficStatsElapsedMs() { }

	public bool get_TrafficStatsEnabled() { }

	[CompilerGenerated]
	public TrafficStatsGameLevel get_TrafficStatsGameLevel() { }

	[CompilerGenerated]
	public TrafficStats get_TrafficStatsIncoming() { }

	[CompilerGenerated]
	public TrafficStats get_TrafficStatsOutgoing() { }

	[CompilerGenerated]
	public ConnectionProtocol get_TransportProtocol() { }

	public bool get_UseByteArraySlicePoolForEvents() { }

	public ConnectionProtocol get_UsedProtocol() { }

	public static string get_Version() { }

	public bool get_WrapIncomingStructs() { }

	public bool InitDatagramEncryption(Byte[] encryptionSecret, Byte[] hmacSecret, bool randomizedSequenceNumbers = false, bool chainingModeGCM = false) { }

	internal void InitializeTrafficStats() { }

	public void InitPayloadEncryption(Byte[] secret) { }

	public static int MessageBufferPoolSize() { }

	public static void MessageBufferPoolTrim(int countOfBuffers) { }

	internal void OnDisconnectMessageCall(DisconnectMessage dm) { }

	public static bool RegisterType(Type customType, byte code, SerializeStreamMethod serializeMethod, DeserializeStreamMethod constructor) { }

	public static bool RegisterType(Type customType, byte code, SerializeMethod serializeMethod, DeserializeMethod constructor) { }

	[CompilerGenerated]
	public void remove_OnDisconnectMessage(Action<DisconnectMessage> value) { }

	public override bool SendAcksOnly() { }

	public override bool SendOperation(byte operationCode, ParameterDictionary operationParameters, SendOptions sendOptions) { }

	public override bool SendOperation(byte operationCode, Dictionary<Byte, Object> operationParameters, SendOptions sendOptions) { }

	public override bool SendOutgoingCommands() { }

	public override void Service() { }

	[CompilerGenerated]
	public void set_CommandBufferSize(int value) { }

	[CompilerGenerated]
	public void set_CountDiscarded(int value) { }

	public void set_CrcEnabled(bool value) { }

	[CompilerGenerated]
	public void set_DeltaUnreliableNumber(int value) { }

	public void set_DisconnectTimeout(int value) { }

	[CompilerGenerated]
	public void set_EnableServerTracing(bool value) { }

	public void set_EncryptorType(Type value) { }

	[CompilerGenerated]
	public void set_IsSendingOnlyAcks(bool value) { }

	public override void set_IsSimulationEnabled(bool value) { }

	[CompilerGenerated]
	public void set_LimitOfUnreliableCommands(int value) { }

	[CompilerGenerated]
	protected void set_Listener(IPhotonPeerListener value) { }

	public void set_LocalMsTimestampDelegate(IntegerMillisecondsDelegate value) { }

	public void set_LongestSentCall(int value) { }

	public void set_MaximumTransferUnit(int value) { }

	public void set_PayloadEncryptorType(Type value) { }

	public void set_QuickResendAttempts(byte value) { }

	public void set_ReuseEventInstance(bool value) { }

	public void set_SequenceDeltaLimitSends(int value) { }

	[CompilerGenerated]
	public void set_SerializationProtocolType(SerializationProtocol value) { }

	[CompilerGenerated]
	internal void set_SocketImplementation(Type value) { }

	public void set_TrafficStatsEnabled(bool value) { }

	[CompilerGenerated]
	internal void set_TrafficStatsGameLevel(TrafficStatsGameLevel value) { }

	[CompilerGenerated]
	internal void set_TrafficStatsIncoming(TrafficStats value) { }

	[CompilerGenerated]
	internal void set_TrafficStatsOutgoing(TrafficStats value) { }

	[CompilerGenerated]
	public void set_TransportProtocol(ConnectionProtocol value) { }

	public void set_UseByteArraySlicePoolForEvents(bool value) { }

	public void set_WrapIncomingStructs(bool value) { }

	public override void StopThread() { }

	public void TrafficStatsReset() { }

	public string VitalStatsToString(bool all) { }

}

