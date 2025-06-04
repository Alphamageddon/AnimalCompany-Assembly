namespace Fusion;

public abstract class Simulation : ILogSourceProxy, INetPeerGroupCallbacks
{
	[CompilerGenerated]
	private struct <>c__DisplayClass241_0
	{
		public SimulationConnection connection; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass241_1
	{
		public bool handleWithoutSequence; //Field offset: 0x0
		public SimulationMessageEnvelope* head; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <get_ActivePlayers>d__138 : IEnumerable<PlayerRef>, IEnumerable, IEnumerator<PlayerRef>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PlayerRef <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public Simulation <>4__this; //Field offset: 0x20
		private Enumerator<Int32, SimulationConnection> <>7__wrap1; //Field offset: 0x28

		private override PlayerRef System.Collections.Generic.IEnumerator<Fusion.PlayerRef>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 92
		}

		[DebuggerHidden]
		public <get_ActivePlayers>d__138(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<PlayerRef> System.Collections.Generic.IEnumerable<Fusion.PlayerRef>.GetEnumerator() { }

		[DebuggerHidden]
		private override PlayerRef System.Collections.Generic.IEnumerator<Fusion.PlayerRef>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_Connections>d__154 : IEnumerable<SimulationConnection>, IEnumerable, IEnumerator<SimulationConnection>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private SimulationConnection <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Simulation <>4__this; //Field offset: 0x28
		private Enumerator<Int32, SimulationConnection> <>7__wrap1; //Field offset: 0x30

		private override SimulationConnection System.Collections.Generic.IEnumerator<Fusion.SimulationConnection>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <get_Connections>d__154(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<SimulationConnection> System.Collections.Generic.IEnumerable<Fusion.SimulationConnection>.GetEnumerator() { }

		[DebuggerHidden]
		private override SimulationConnection System.Collections.Generic.IEnumerator<Fusion.SimulationConnection>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct AreaOfInterest
	{
		internal const int SIZE_DEFAULT = 32; //Field offset: 0x0
		internal const int GRID_DEFAULT = 1024; //Field offset: 0x0
		internal const int MAX_SHARED_RADIUS = 300; //Field offset: 0x0
		internal static int X_SIZE; //Field offset: 0x0
		internal static int Y_SIZE; //Field offset: 0x4
		internal static int Z_SIZE; //Field offset: 0x8
		public static int CELL_SIZE; //Field offset: 0xC

		private static AreaOfInterest() { }

		[CompilerGenerated]
		internal static int <ClampCellCoords>g__Clamp|15_0(int v, int max) { }

		public static ValueTuple<Int32, Int32, Int32> ClampCellCoords(int x, int y, int z) { }

		public static int GetCellSize() { }

		public static ValueTuple<Int32, Int32, Int32> GetGridSize() { }

		public static void SphereToCells(Vector3 position, float radius, HashSet<Int32> cells) { }

		public static int ToCell(Vector3 position) { }

		public static int ToCell(int x, int y, int z) { }

		public static Vector3 ToCellCenter(int index) { }

		public static ValueTuple<Int32, Int32, Int32> ToCellCoords(Vector3 position) { }

		public static ValueTuple<Int32, Int32, Int32> ToCellCoords(int index) { }

	}

	private class AreaOfInterestCell
	{
		public int Key; //Field offset: 0x10
		public List Objects; //Field offset: 0x18
		public BitSet256 Connections; //Field offset: 0x30

		public bool Empty
		{
			 get { } //Length: 56
		}

		public AreaOfInterestCell() { }

		public bool get_Empty() { }

	}

	public class Client : Simulation
	{
		private NetConnection* _server; //Field offset: 0x1A8
		private bool _stateReceived; //Field offset: 0x1B0
		private Timeline _history; //Field offset: 0x1B8
		private Buffer _inputBuffer; //Field offset: 0x1C0
		private SimulationInput[] _inputArray; //Field offset: 0x1C8
		public Tick PreviousServerTick; //Field offset: 0x1D0
		private Nullable<Boolean> _previousWasMC; //Field offset: 0x1D4

		public virtual IEnumerable<PlayerRef> ActivePlayers
		{
			 get { } //Length: 640
		}

		public bool IsConnectedToServer
		{
			 get { } //Length: 16
		}

		public virtual Tick LatestServerTick
		{
			 get { } //Length: 124
		}

		public double LatestServerTime
		{
			 get { } //Length: 64
		}

		public virtual PlayerRef LocalPlayer
		{
			 get { } //Length: 172
		}

		public double RttToServer
		{
			 get { } //Length: 24
		}

		public NetAddress ServerAddress
		{
			 get { } //Length: 40
		}

		internal NetConnection* ServerConnection
		{
			internal get { } //Length: 8
		}

		private TimeSyncConfiguration TimeSyncConfig
		{
			private get { } //Length: 124
		}

		internal Client(SimulationArgs args) { }

		protected virtual void BeforeFirstTick() { }

		protected virtual int BeforeSimulation() { }

		protected virtual void BeforeUpdate() { }

		public void Connect(NetAddress address, Byte[] token = null, Byte[] uniqueId = null) { }

		public void Connect(string ip, ushort port, Byte[] token = null, Byte[] uniqueId = null) { }

		internal virtual PlayerRef Connection2Player(NetConnection* c) { }

		public virtual IEnumerable<PlayerRef> get_ActivePlayers() { }

		public bool get_IsConnectedToServer() { }

		public virtual Tick get_LatestServerTick() { }

		public double get_LatestServerTime() { }

		public virtual PlayerRef get_LocalPlayer() { }

		public double get_RttToServer() { }

		public NetAddress get_ServerAddress() { }

		internal NetConnection* get_ServerConnection() { }

		private TimeSyncConfiguration get_TimeSyncConfig() { }

		internal virtual SimulationInput GetInput(Tick tick, PlayerRef player) { }

		internal virtual double GetPlayerRtt(PlayerRef player) { }

		private ValueTuple<SimulationInput[], Int32> GetSortedInputs() { }

		protected virtual void NetworkConnected(NetConnection* connection) { }

		protected virtual void NetworkDisconnected(NetConnection* connection, NetDisconnectReason reason) { }

		protected virtual void NetworkReceiveDone() { }

		protected virtual void NoSimulation() { }

		private static string NullableToString(Nullable<T> value) { }

		internal virtual void OnNetworkShutdown() { }

		internal virtual int Player2Connection(PlayerRef player) { }

		internal virtual void RecvPacket() { }

		internal void ResetClientSimulationState() { }

		internal void ResetPredictedObjectsToLatestServerState() { }

		private void RunClientSidePredictionLoop(int ticks, SimulationStages stage) { }

		private void UpdateInterpolation() { }

		private void UpdateObjectInterpolationParams(double now) { }

		private void UpdateObjectTimelines() { }

		private void WriteInput() { }

		internal virtual void WritePackets() { }

	}

	public class History
	{
		public class Entry
		{
			public Entry Prev; //Field offset: 0x10
			public Entry Next; //Field offset: 0x18
			public Tick Tick; //Field offset: 0x20
			public double Time; //Field offset: 0x28

			public Entry() { }

		}

		private SimulationHistoryEntryList _entryList; //Field offset: 0x10

		public Entry Latest
		{
			 get { } //Length: 28
		}

		public Entry Oldest
		{
			 get { } //Length: 28
		}

		public History(int capacity) { }

		public Entry Add(Tick tick, double time) { }

		public Entry get_Latest() { }

		public Entry get_Oldest() { }

	}

	public interface ICallbacks
	{

		public bool CanReceivePlayerJoinLeaveCallbacks
		{
			 get { } //Length: 0
		}

		public bool IsSharedModeMasterClient
		{
			 get { } //Length: 0
		}

		public PlayerRef LocalPlayerRef
		{
			 get { } //Length: 0
		}

		public bool CreateRemotePrefab(NetworkObjectMeta header) { }

		public bool DestroyRemotePrefab(NetworkId id, bool exists) { }

		public void EndUpdateRemotePrefabs() { }

		public bool get_CanReceivePlayerJoinLeaveCallbacks() { }

		public bool get_IsSharedModeMasterClient() { }

		public PlayerRef get_LocalPlayerRef() { }

		public void ObjectChanged(NetworkId id, bool created) { }

		public void ObjectEnterAOI(PlayerRef player, NetworkId id) { }

		public void ObjectExitAOI(PlayerRef player, NetworkId id) { }

		public void ObjectInputAuthorityChanged(NetworkId id, bool gained) { }

		public void ObjectIsSimulatedChanged(NetworkId id, bool simulated) { }

		public void ObjectStateAuthorityChanged(NetworkId id, bool gained) { }

		public void OnAfterAllTicks(bool resimulation, int tickCount) { }

		public void OnAfterClientSidePredictionReset() { }

		public void OnAfterSimulation() { }

		public void OnAfterTick() { }

		public void OnBeforeAllTicks(bool resimulation, int tickCount) { }

		public void OnBeforeClientSidePredictionReset() { }

		public void OnBeforeCopyPreviousState() { }

		public void OnBeforeSimulation(int forwardTickCount) { }

		public void OnBeforeTick() { }

		public void OnClientStart() { }

		public void OnConnectedToServer() { }

		public void OnConnectionFailed(NetAddress remoteAddress, NetConnectFailedReason reason) { }

		public OnConnectionRequestReply OnConnectionRequest(NetAddress remoteAddress, Byte[] token) { }

		public void OnDisconnectedFromServer(NetDisconnectReason reason) { }

		public void OnInput(SimulationInput input) { }

		public void OnInputMissing(SimulationInput input) { }

		public void OnInternalConnectionAttempt(int attempt, int totalConnectionAttempts, out bool shouldChange, out NetAddress newAddress) { }

		public SimulationMessageResult OnMessage(SimulationMessage* message) { }

		public void OnReliableData(PlayerRef player, ReliableId id, bool local, Byte[] dataArray) { }

		public void OnServerStart() { }

		public void OnTick() { }

		public void PlayerJoined(PlayerRef player) { }

		public void PlayerLeft(PlayerRef player) { }

		public bool TryBeginUpdateRemotePrefabs() { }

	}

	public struct PlayerRefMapping
	{
		public int ActorId; //Field offset: 0x0
		public PlayerRef PlayerRef; //Field offset: 0x4

	}

	private struct PlayerSimulationData
	{
		public PlayerRef Player; //Field offset: 0x0
		public NetworkId Object; //Field offset: 0x4
		public int Actor; //Field offset: 0x8

	}

	public class RecvContext
	{
		private Simulation _simulation; //Field offset: 0x10
		public PlayerRef Player; //Field offset: 0x18
		public SimulationPacketHeader Header; //Field offset: 0x1C
		public NetBitBuffer* Buffer; //Field offset: 0x28
		public SimulationConnection Connection; //Field offset: 0x30

		public RecvContext(Simulation simulation) { }

		public void Done() { }

		public void Init(SimulationConnection connection, NetBitBuffer* buffer) { }

	}

	public class SendContext
	{
		private Simulation _simulation; //Field offset: 0x10
		public SimulationPacketHeader Header; //Field offset: 0x18
		public NetBitBuffer* Buffer; //Field offset: 0x20
		public SimulationPacketEnvelope* Envelope; //Field offset: 0x28
		public Tick Tick; //Field offset: 0x30
		public PlayerRef Player; //Field offset: 0x34
		public SimulationConnection Connection; //Field offset: 0x38
		public int ObjPrev; //Field offset: 0x40

		public bool IsWriting
		{
			 get { } //Length: 16
		}

		public SendContext(Simulation simulation) { }

		public bool get_IsWriting() { }

		public bool Init(SimulationConnection connection, Tick tick) { }

		private void Reset() { }

		public void Send() { }

	}

	public class Server : Simulation
	{
		private SimulationInput _inputReadTarget; //Field offset: 0x1A8
		[CompilerGenerated]
		private readonly Dictionary<NetworkId, NetworkObjectHeaderSnapshot> <NetworkObjectMap>k__BackingField; //Field offset: 0x1B0
		private NetBitBuffer* _hostMigrationWriteBuffer; //Field offset: 0x1B8

		public virtual Tick LatestServerTick
		{
			 get { } //Length: 8
		}

		public virtual PlayerRef LocalPlayer
		{
			 get { } //Length: 240
		}

		private Dictionary<NetworkId, NetworkObjectHeaderSnapshot> NetworkObjectMap
		{
			[CompilerGenerated]
			private get { } //Length: 8
		}

		internal Server(SimulationArgs args) { }

		protected virtual void AfterSimulation() { }

		protected virtual void BeforeFirstTick() { }

		protected virtual int BeforeSimulation() { }

		protected virtual void BeforeUpdate() { }

		internal void CreateInternalStateObjects(PlayerRef sceneInfoStateAuth) { }

		private SimulationRuntimeConfig CreateRuntimeConfiguration() { }

		internal void Disconnect(PlayerRef player, Byte[] token) { }

		internal void Disconnect(NetAddress address) { }

		internal void DisposeHostMigration() { }

		public virtual Tick get_LatestServerTick() { }

		public virtual PlayerRef get_LocalPlayer() { }

		[CompilerGenerated]
		private Dictionary<NetworkId, NetworkObjectHeaderSnapshot> get_NetworkObjectMap() { }

		internal virtual SimulationInput GetInput(Tick tick, PlayerRef player) { }

		internal virtual double GetPlayerRtt(PlayerRef player) { }

		internal ValueTuple<Dictionary`2<NetworkId, NetworkObjectHeaderPtr>, Dictionary`2<NetworkId, List`1<NetworkId>>> GetResumeObjectHeader() { }

		protected virtual void NetworkConnected(NetConnection* connection) { }

		protected virtual void NetworkDisconnected(NetConnection* connection, NetDisconnectReason reason) { }

		internal static void ProcessHostMigrationData(Byte[] data, Dictionary<NetworkId, NetworkObjectHeaderSnapshot> networkObjectMap, Allocator* allocator) { }

		private void ReadHostMigrationData(Byte[] data) { }

		private void ReadInput() { }

		private void ReadStateTick() { }

		internal virtual void RecvPacket() { }

		internal void SpawnRuntimeConfiguration() { }

		internal int WriteHostMigrationData(ref Byte[] target, int targetBytes) { }

		internal virtual void WritePackets() { }

	}

	public struct SimulationPacketHeader
	{
		public const int WIRE_SIZE_IN_BYTES = 8; //Field offset: 0x0
		public const int WIRE_SIZE_IN_BITS = 64; //Field offset: 0x0
		public byte SimulationMessages; //Field offset: 0x0
		public byte Cells; //Field offset: 0x1
		public byte Inputs; //Field offset: 0x1
		public byte ObjectUpdates; //Field offset: 0x2
		public byte ObjectDestroys; //Field offset: 0x3
		public int Tick; //Field offset: 0x4

		public bool Equals(SimulationPacketHeader other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

		public void Read(NetBitBuffer* buffer) { }

		public virtual string ToString() { }

		public void Write(NetBitBuffer* buffer) { }

	}

	public class StateReplicator
	{
		private enum WriteResult
		{
			Written = 0,
			NothingToSend = 1,
			PacketFull = 2,
		}

		internal const int DATA_BLOCK_SIZE = 6; //Field offset: 0x0
		internal const int OFFSET_BLOCK_SIZE = 4; //Field offset: 0x0
		protected const int HEADER_BLOCK_SIZE = 8; //Field offset: 0x0
		protected const int GLOBAL_BLOCK_SIZE = 8; //Field offset: 0x0
		private readonly Simulation _simulation; //Field offset: 0x10
		private readonly List<List> _aoiQuery; //Field offset: 0x18
		internal readonly Queue<NetworkId> _create; //Field offset: 0x20
		private readonly Queue<NetworkId> _createNested; //Field offset: 0x28
		private readonly Queue<NetworkId> _destroy; //Field offset: 0x30
		private readonly bool _notUsingAreaOfInterest; //Field offset: 0x38
		private readonly DataConsistency _dataConsistency; //Field offset: 0x3C
		private NetworkObjectMeta _runtimeConfig; //Field offset: 0x40
		private NetworkObjectMeta _sceneInfo; //Field offset: 0x48
		private NetworkObjectMeta _physicsInfo; //Field offset: 0x50

		public StateReplicator(Simulation simulation) { }

		internal override void AssertVerifyNothingIsPending() { }

		private static bool CheckNothingToSendTicks(NetworkObjectMeta meta, NetworkObjectConnectionData data) { }

		internal bool HasObjectInterest(PlayerRef player, NetworkId id) { }

		private bool IsLocalDestroyWaitingForConfirmation(NetworkId id) { }

		public void OnObjectDestroyed(NetworkId id, NetworkObjectDestroyFlags flags) { }

		public void OnObjectSpawnedLocal(NetworkId id) { }

		public void OnPacketDelivered(NetConnection* c, SimulationPacketEnvelope* envelope) { }

		public void OnPacketLost(NetConnection* c, SimulationPacketEnvelope* envelope) { }

		private bool ReadObjectDataIntoPtr(NetworkObjectMeta meta, Void* ptr, int word) { }

		private void ReadObjectDestroys() { }

		private void ReadObjectUpdates() { }

		public void RecvPacket() { }

		private WriteResult ScanAndWriteObject(NetworkObjectMeta meta, NetworkObjectConnectionData data) { }

		private bool ScanStructForChanges(NetworkObjectMeta meta) { }

		public void SendPacket() { }

		private void SkipObject(NetworkId id, NetworkBufferSerializerInfo[] serializers, bool unconfirmed) { }

		internal void UpdateChangedStructSet() { }

		public void UpdateRemotePrefabs() { }

		private void WriteLevelUsingScheduling(int level, ref NetworkObjectConnectionData sent) { }

		private WriteResult WriteObject(NetworkObjectMeta meta, NetworkObjectConnectionData data) { }

		private void WriteObjectDestroys() { }

		private void WriteStructs() { }

		private void WriteUsingAllObjects() { }

		private void WriteUsingScheduling() { }

		private static void WriteWord(NetBitBuffer* buffer, Int32* ptr, int word, int previous) { }

	}

	private enum TargetObjectVerificationResult
	{
		Ok = 0,
		TargetNotInterestedInObject = 1,
	}

	public struct TimeFeedback
	{
		private const int ACCURACY = 256; //Field offset: 0x0
		private const int BLOCK = 6; //Field offset: 0x0
		public float OffsetAvg; //Field offset: 0x0
		public float OffsetDev; //Field offset: 0x4
		public float RecvDeltaAvg; //Field offset: 0x8
		public float RecvDeltaDev; //Field offset: 0xC

		public TimeFeedback(SimulationConnection sc) { }

		public TimeFeedback(double offsetAvg, double offsetDev, double recvDeltaAvg, double recvDeltaDev) { }

		public void Read(NetBitBuffer* buffer) { }

		public void Write(NetBitBuffer* buffer) { }

	}

	private Dictionary<Int32, AreaOfInterestCell> _aoiCells; //Field offset: 0x10
	private Stack<AreaOfInterestCell> _aoiCellsPool; //Field offset: 0x18
	private Dictionary<Int32, HashSet`1<Int32>> _aoiConnections; //Field offset: 0x20
	private ulong _interpolateSequence; //Field offset: 0x28
	private bool _isShutdown; //Field offset: 0x30
	private bool _isWaitingForShutdown; //Field offset: 0x31
	internal NetworkRunner Runner; //Field offset: 0x38
	private ICallbacks _callbacks; //Field offset: 0x40
	private Tick _tick; //Field offset: 0x48
	private SimulationModes _mode; //Field offset: 0x4C
	private SimulationStages _stage; //Field offset: 0x50
	private SimulationConfig _config; //Field offset: 0x58
	private NetworkProjectConfig _projectConfig; //Field offset: 0x60
	internal ITimeProvider _time; //Field offset: 0x68
	private Tick _interpTo; //Field offset: 0x70
	private Tick _interpFrom; //Field offset: 0x74
	private float _remoteAlpha; //Field offset: 0x78
	private float _localAlpha; //Field offset: 0x7C
	private Tick _interpToPrev; //Field offset: 0x80
	private Tick _interpFromPrev; //Field offset: 0x84
	private float _remoteAlphaPrev; //Field offset: 0x88
	private float _localAlphaPrev; //Field offset: 0x8C
	private SimulationInput _inputRoot; //Field offset: 0x90
	private Pool _inputPool; //Field offset: 0x98
	private SimulationInputCollection _inputCollection; //Field offset: 0xA0
	private StateReplicator _stateReplicator; //Field offset: 0xA8
	internal Dictionary<Int32, SimulationConnection> _connections; //Field offset: 0xB0
	private Dictionary<PlayerRef, SimulationConnection> _playersConnections; //Field offset: 0xB8
	private HashSet<PlayerRef> _players; //Field offset: 0xC0
	private double _updateTime; //Field offset: 0xC8
	private bool _isResume; //Field offset: 0xD0
	private Tick _sendTick; //Field offset: 0xD4
	private bool _isLastTick; //Field offset: 0xD8
	private bool _isFirstTick; //Field offset: 0xD9
	private bool _isResimulation; //Field offset: 0xDA
	private bool _isInTick; //Field offset: 0xDB
	private bool _isInitialLocalTick; //Field offset: 0xDC
	private Nullable<Boolean> _isPaused; //Field offset: 0xDD
	internal FusionStatisticsManager _fusionStatsManager; //Field offset: 0xE0
	private Dictionary<Tick, Double> _tickUpdateTimes; //Field offset: 0xE8
	private Queue<ValueTuple`2<PlayerRef, Boolean>> _invokeJoinedLeaveQueue; //Field offset: 0xF0
	private HashSet<NetworkId> _globalInterestObjects; //Field offset: 0xF8
	private Dictionary<UInt64, PlayerRefMapping> _uniqueIdPlayerRefMapping; //Field offset: 0x100
	private SendContext _sendContext; //Field offset: 0x108
	private RecvContext _recvContext; //Field offset: 0x110
	private int _reliableSend; //Field offset: 0x118
	internal INetSocket _netSocket; //Field offset: 0x120
	internal NetPeer* _netPeer; //Field offset: 0x128
	private NetPeerGroup* _netPeerGroup; //Field offset: 0x130
	private Random _netPeerRng; //Field offset: 0x138
	private Stack<NetworkObjectHeaderSnapshot> _snapshotsPool; //Field offset: 0x140
	private uint _idCounter; //Field offset: 0x148
	private Dictionary<NetworkId, NetworkObjectMeta> _metaLookup; //Field offset: 0x150
	private Dictionary<NetworkObjectTypeId, NetworkObjectMeta> _metaSceneLookup; //Field offset: 0x158
	private ListMigration _metaMigration; //Field offset: 0x160
	private Dictionary<PlayerRef, NetworkId> _playerDataLookup; //Field offset: 0x178
	private Dictionary<PlayerRef, NetworkId> _playerLeftTempObjectCache; //Field offset: 0x180
	private HashSet<NetworkId> _structs; //Field offset: 0x188
	private int _structsVersion; //Field offset: 0x190
	private Allocator* _allocator; //Field offset: 0x198
	private Allocator* _allocatorObjects; //Field offset: 0x1A0

	public override IEnumerable<PlayerRef> ActivePlayers
	{
		[IteratorStateMachine(typeof(<get_ActivePlayers>d__138))]
		 get { } //Length: 104
	}

	internal ICallbacks Callbacks
	{
		internal get { } //Length: 8
	}

	public SimulationConfig Config
	{
		 get { } //Length: 8
	}

	internal IEnumerable<SimulationConnection> Connections
	{
		[IteratorStateMachine(typeof(<get_Connections>d__154))]
		internal get { } //Length: 104
	}

	public float DeltaTime
	{
		 get { } //Length: 136
	}

	private override ILogSource Fusion.ILogSourceProxy.LogSource
	{
		private get { } //Length: 8
	}

	internal bool HasRuntimeConfig
	{
		internal get { } //Length: 144
	}

	internal uint IdCounter
	{
		internal get { } //Length: 8
	}

	public int InputCount
	{
		 get { } //Length: 28
	}

	internal ulong InterpolateSequence
	{
		internal get { } //Length: 8
	}

	public bool IsClient
	{
		 get { } //Length: 120
	}

	public bool IsFirstTick
	{
		 get { } //Length: 8
	}

	public bool IsForward
	{
		 get { } //Length: 16
	}

	internal bool IsInTick
	{
		internal get { } //Length: 8
	}

	public bool IsLastTick
	{
		 get { } //Length: 8
	}

	public bool IsLocalPlayerFirstExecution
	{
		 get { } //Length: 16
	}

	public bool IsMasterClient
	{
		 get { } //Length: 164
	}

	internal bool IsPaused
	{
		internal get { } //Length: 108
	}

	public bool IsPlayer
	{
		 get { } //Length: 28
	}

	public bool IsResimulation
	{
		 get { } //Length: 8
	}

	internal bool IsResume
	{
		internal get { } //Length: 8
	}

	public bool IsRunning
	{
		 get { } //Length: 16
	}

	public bool IsServer
	{
		 get { } //Length: 120
	}

	public bool IsShutdown
	{
		 get { } //Length: 8
	}

	public bool IsSinglePlayer
	{
		 get { } //Length: 56
	}

	internal bool IsWaitingForTheInitialTick
	{
		internal get { } //Length: 8
	}

	public abstract Tick LatestServerTick
	{
		 get { } //Length: 0
	}

	public NetAddress LocalAddress
	{
		 get { } //Length: 28
	}

	public float LocalAlpha
	{
		 get { } //Length: 8
	}

	public abstract PlayerRef LocalPlayer
	{
		 get { } //Length: 0
	}

	public SimulationModes Mode
	{
		 get { } //Length: 8
	}

	public NetConfig* NetConfigPointer
	{
		 get { } //Length: 12
	}

	public int ObjectCount
	{
		 get { } //Length: 80
	}

	public Dictionary<NetworkId, NetworkObjectMeta> Objects
	{
		 get { } //Length: 8
	}

	public NetworkProjectConfig ProjectConfig
	{
		 get { } //Length: 8
	}

	internal int ReliableDataSendRate
	{
		internal get { } //Length: 64
		internal set { } //Length: 120
	}

	public float RemoteAlpha
	{
		 get { } //Length: 8
	}

	public Tick RemoteTick
	{
		 get { } //Length: 8
	}

	public Tick RemoteTickPrevious
	{
		 get { } //Length: 8
	}

	internal StateReplicator Replicator
	{
		internal get { } //Length: 8
	}

	internal SimulationRuntimeConfig RuntimeConfig
	{
		internal get { } //Length: 36
	}

	internal SimulationRuntimeConfig* RuntimeConfigPtr
	{
		internal get { } //Length: 220
	}

	public double SendDelta
	{
		 get { } //Length: 132
	}

	public int SendRate
	{
		 get { } //Length: 60
	}

	public SimulationStages Stage
	{
		 get { } //Length: 8
	}

	public Tick Tick
	{
		 get { } //Length: 8
	}

	public double TickDeltaDouble
	{
		 get { } //Length: 96
	}

	public float TickDeltaFloat
	{
		 get { } //Length: 100
	}

	public Tick TickPrevious
	{
		 get { } //Length: 120
	}

	public int TickRate
	{
		 get { } //Length: 20
	}

	public int TickStride
	{
		 get { } //Length: 132
	}

	public double Time
	{
		 get { } //Length: 116
	}

	public Topologies Topology
	{
		 get { } //Length: 28
	}

	internal Simulation(SimulationArgs args) { }

	[CompilerGenerated]
	private void <DeliverMessages>g__ConsumeMessage|241_0(ref <>c__DisplayClass241_0 unnamed_param_0, ref <>c__DisplayClass241_1 unnamed_param_1) { }

	[CompilerGenerated]
	internal static RpcSendMessageResult <SendMessage>g__VerifyResultToSendMessageResult|342_0(TargetObjectVerificationResult status) { }

	[CompilerGenerated]
	private Nullable<Vector3> <UpdateAreaOfInterest>g__ResolveCellPosition|232_0(NetworkObjectMeta m, NetworkTRSPData* trsp) { }

	internal void AddToGlobalObjectInterest(NetworkObjectMeta meta) { }

	protected override void AfterSimulation() { }

	protected override void AfterUpdate() { }

	internal NetworkObjectMeta AllocateObject(NetworkId id, NetworkObjectTypeId type, int wordCount, bool isStruct, Nullable<NetworkId> nestingRoot = null, Nullable<NetworkObjectNestingKey> nestingKey = null) { }

	internal NetworkObjectHeader* AllocateStruct(NetworkId id, int words, Nullable<NetworkObjectTypeId> objectTypeId = null) { }

	internal T* AllocateStruct(NetworkId id, int extraWords = 0, Nullable<NetworkObjectTypeId> objectTypeId = null) { }

	internal T* AllocateStructArray(NetworkId id, int elements, Nullable<NetworkObjectTypeId> objectTypeId = null) { }

	private AreaOfInterestCell AOI_GetCell(int cellKey, bool create) { }

	internal bool AOI_Query(SimulationConnection sc, List<List> result, bool clearResult) { }

	private void AOI_ReleaseCell(AreaOfInterestCell cell) { }

	internal void AOI_RemoveConnection(SimulationConnection sc) { }

	internal void AOI_RemoveFromAreaOfInterest(NetworkObjectMeta meta, bool invokeExit = false) { }

	internal void AOI_UpdateAreaOfInterest(SimulationConnection sc) { }

	internal void AOI_UpdateAreaOfInterest(NetworkObjectMeta meta, int newCellKey) { }

	protected override void BeforeFirstTick() { }

	protected override int BeforeSimulation() { }

	protected override void BeforeUpdate() { }

	private int CalculateForwardTicks() { }

	private void CalculateUpdateTime() { }

	internal PlayerRef Connection2Player(SimulationConnection c) { }

	internal override PlayerRef Connection2Player(NetConnection* c) { }

	private void ConsumeAndWriteMessagesIntoBuffer(ref SimulationMessageList inList, NetBitBuffer* buffer, int bitCapacity, ref SimulationMessageList outList, bool allowFirstMessageOverflow = true) { }

	private void DeletePlayerSimulationData(PlayerRef player) { }

	private void DeliverMessages(int tick) { }

	internal void Destroy(NetworkId id, NetworkObjectDestroyFlags flags) { }

	internal void Dispose() { }

	internal string DumpObject(NetworkObjectHeader* ptr) { }

	internal string DumpObject(NetworkId id) { }

	[Conditional("DEBUG")]
	internal void DumpObject(NetworkId id, StringBuilder sb) { }

	[Conditional("DEBUG")]
	internal void DumpObject(NetworkObjectHeader* header, StringBuilder sb) { }

	internal void EnterAreaOfInterest(int connection, NetworkId id) { }

	internal void EnterAreaOfInterest(SimulationConnection connection, NetworkId id) { }

	internal void ExitAreaOfInterest(int connection, NetworkId id) { }

	internal void ExitAreaOfInterest(SimulationConnection connection, NetworkId id) { }

	internal bool ForwardMessage(SimulationMessage* message, PlayerRef target, bool required) { }

	internal void FreeMessages(ref SimulationMessageList list) { }

	internal void FreeObject(NetworkId id) { }

	private override ILogSource Fusion.ILogSourceProxy.get_LogSource() { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnConnected(NetConnection* connection) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnConnectionAttempt(NetConnection* connection, int attempt, int totalConnectionAttempts) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnConnectionFailed(NetAddress address, NetConnectFailedReason reason) { }

	private override OnConnectionRequestReply Fusion.Sockets.INetPeerGroupCallbacks.OnConnectionRequest(NetAddress remoteAddres, Byte[] token, Byte[] uniqueid) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnDisconnected(NetConnection* connection, NetDisconnectReason reason) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnNotifyData(NetConnection* c, NetBitBuffer* buffer) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnNotifyDelivered(NetConnection* connection, NetSendEnvelope envelope) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnNotifyDispose(NetSendEnvelope envelope) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnNotifyLost(NetConnection* connection, NetSendEnvelope envelope) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnReliableData(NetConnection* connection, ReliableId id, Byte* data) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnUnconnectedData(NetBitBuffer* buffer) { }

	private override void Fusion.Sockets.INetPeerGroupCallbacks.OnUnreliableData(NetConnection* connection, NetBitBuffer* buffer) { }

	[IteratorStateMachine(typeof(<get_ActivePlayers>d__138))]
	public override IEnumerable<PlayerRef> get_ActivePlayers() { }

	internal ICallbacks get_Callbacks() { }

	public SimulationConfig get_Config() { }

	[IteratorStateMachine(typeof(<get_Connections>d__154))]
	internal IEnumerable<SimulationConnection> get_Connections() { }

	public float get_DeltaTime() { }

	internal bool get_HasRuntimeConfig() { }

	internal uint get_IdCounter() { }

	public int get_InputCount() { }

	internal ulong get_InterpolateSequence() { }

	public bool get_IsClient() { }

	public bool get_IsFirstTick() { }

	public bool get_IsForward() { }

	internal bool get_IsInTick() { }

	public bool get_IsLastTick() { }

	public bool get_IsLocalPlayerFirstExecution() { }

	public bool get_IsMasterClient() { }

	internal bool get_IsPaused() { }

	public bool get_IsPlayer() { }

	public bool get_IsResimulation() { }

	internal bool get_IsResume() { }

	public bool get_IsRunning() { }

	public bool get_IsServer() { }

	public bool get_IsShutdown() { }

	public bool get_IsSinglePlayer() { }

	internal bool get_IsWaitingForTheInitialTick() { }

	public abstract Tick get_LatestServerTick() { }

	public NetAddress get_LocalAddress() { }

	public float get_LocalAlpha() { }

	public abstract PlayerRef get_LocalPlayer() { }

	public SimulationModes get_Mode() { }

	public NetConfig* get_NetConfigPointer() { }

	public int get_ObjectCount() { }

	public Dictionary<NetworkId, NetworkObjectMeta> get_Objects() { }

	public NetworkProjectConfig get_ProjectConfig() { }

	internal int get_ReliableDataSendRate() { }

	public float get_RemoteAlpha() { }

	public Tick get_RemoteTick() { }

	public Tick get_RemoteTickPrevious() { }

	internal StateReplicator get_Replicator() { }

	internal SimulationRuntimeConfig get_RuntimeConfig() { }

	internal SimulationRuntimeConfig* get_RuntimeConfigPtr() { }

	public double get_SendDelta() { }

	public int get_SendRate() { }

	public SimulationStages get_Stage() { }

	public Tick get_Tick() { }

	public double get_TickDeltaDouble() { }

	public float get_TickDeltaFloat() { }

	public Tick get_TickPrevious() { }

	public int get_TickRate() { }

	public int get_TickStride() { }

	public double get_Time() { }

	public Topologies get_Topology() { }

	public void GetAreaOfInterestGizmoData(List<ValueTuple`4<Vector3, Vector3, Int32, Int32>> result) { }

	internal Nullable<Int32> GetConnectionIndexForPlayer(PlayerRef player) { }

	internal int GetGeneralAllocatorFreeSegmentsInBytes() { }

	internal int GetGeneralAllocatorUsedSegmentsInBytes() { }

	internal abstract SimulationInput GetInput(Tick tick, PlayerRef player) { }

	public PlayerRef GetInputAuthority(NetworkObject networkObject) { }

	public SimulationInput GetInputForPlayer(PlayerRef player) { }

	internal NetworkObjectHeaderSnapshotRef GetLatestSnapshot(NetworkId id) { }

	internal void GetMemorySnapshot(TargetAllocator targetAllocator, ref MemoryStatisticsSnapshot snapshot) { }

	private Void* GetMessageInternalData(SimulationMessage* message) { }

	private T GetMessageInternalData(SimulationMessage* message) { }

	private SimulationMessageInternalTypes GetMessageInternalType(SimulationMessage* message) { }

	internal NetworkId GetMessageTargetObjectIdForVerification(SimulationMessage* message) { }

	internal NetworkObjectMeta GetMeta(NetworkId id) { }

	internal NetworkId GetNextId() { }

	internal NetworkObjectHeader* GetObject(NetworkId id) { }

	internal int GetObjectsAllocatorFreeSegmentsInBytes() { }

	internal int GetObjectsAllocatorUsedSegmentsInBytes() { }

	public void GetObjectsAndPlayersInAreaOfInterestCell(int cellKey, List<PlayerRef> players, List<NetworkId> objects) { }

	public List<NetworkId> GetObjectsInAreaOfInterestForPlayer(PlayerRef player) { }

	internal Nullable<Int32> GetPlayerActorId(PlayerRef player) { }

	internal NetAddress GetPlayerAddress(PlayerRef player) { }

	internal Byte[] GetPlayerConnectionToken(PlayerRef player) { }

	internal NetworkId GetPlayerObjectId(PlayerRef player) { }

	internal Nullable<PlayerRefMapping> GetPlayerRefMapping(Byte[] id) { }

	internal Nullable<PlayerRefMapping> GetPlayerRefMapping(Byte* id) { }

	internal abstract double GetPlayerRtt(PlayerRef player) { }

	private PlayerSimulationData* GetPlayerSimulationData(PlayerRef player, bool create) { }

	internal long GetPlayerUniqueId(PlayerRef player) { }

	internal RpcTargetStatus GetRpcTargetStatus(PlayerRef target) { }

	private SimulationConnection GetSimulationConnection(NetConnection* c) { }

	internal SimulationConnection GetSimulationConnectionByIndex(int index) { }

	internal SimulationConnection GetSimulationConnectionForPlayer(PlayerRef player) { }

	internal NetworkObjectHeaderSnapshot GetSnapshot() { }

	public PlayerRef GetStateAuthority(NetworkObject networkObject) { }

	public bool HasAnyActiveConnections() { }

	internal bool HasObject(NetworkId id) { }

	internal void InterpolateSequenceIncrement() { }

	private void InvokeOnAfterAllTicks(bool resimulation, int ticks) { }

	private void InvokeOnAfterSimulation() { }

	private void InvokeOnBeforeAllTicks(bool resimulation, int ticks) { }

	private void InvokeOnBeforeSimulation(int forwardTickCount) { }

	private void InvokePlayerJoinedLeft() { }

	private void InvokeTick(SimulationStages stage, bool releaseAllInputs) { }

	internal bool IsHostPlayer(PlayerRef player) { }

	public bool IsInputAuthority(NetworkObject networkObject, PlayerRef playerRef) { }

	public Nullable<Boolean> IsInterestedIn(NetworkObject obj, PlayerRef player) { }

	internal bool IsLocalSimulationInputAuthority(NetworkObjectMeta meta) { }

	public bool IsLocalSimulationInputAuthority(NetworkObject obj) { }

	internal bool IsLocalSimulationStateAuthority(NetworkObjectMeta meta) { }

	public bool IsLocalSimulationStateAuthority(NetworkObject obj) { }

	public bool IsLocalSimulationStateAuthority(NetworkId id) { }

	internal bool IsLocalSimulationStateOrInputAuthority(NetworkObjectMeta meta) { }

	public bool IsLocalSimulationStateOrInputSource(NetworkObject obj) { }

	internal bool IsSimulated(NetworkId id) { }

	internal bool IsSimulated(NetworkObject obj) { }

	internal bool IsSimulated(NetworkObjectMeta meta) { }

	internal bool IsStateAuthority(NetworkObjectMeta networkObject, PlayerRef playerRef) { }

	public bool IsStateAuthority(NetworkObject networkObject, PlayerRef playerRef) { }

	public bool IsStateAuthority(PlayerRef stateSource, PlayerRef playerRef) { }

	internal void LogAllObjectIds() { }

	protected override void NetworkConnected(NetConnection* connection) { }

	protected override void NetworkDisconnected(NetConnection* connection, NetDisconnectReason reason) { }

	private bool NetworkGetBuffer(NetConnection* connection, out NetBitBuffer* buffer) { }

	private void NetworkInit(INetSocket socket, NetAddress address) { }

	protected override void NetworkReceiveDone() { }

	private void NetworkRecv() { }

	private void NetworkSend() { }

	private bool NetworkSendBuffer(NetConnection* connection, NetBitBuffer* buffer, SimulationPacketEnvelope* envelope) { }

	internal bool NetworkSendPing(NetAddress address, Void* data, int length) { }

	private void NetworkShutdown() { }

	protected override void NoSimulation() { }

	internal void NotifyWaitingForShutdown() { }

	private void OnEnvelopeDelivered(NetConnection* connection, SimulationPacketEnvelope* envelope) { }

	private void OnEnvelopeLost(NetConnection* connection, SimulationPacketEnvelope* envelope) { }

	private void OnMessageInternal(SimulationMessage* message) { }

	internal override void OnNetworkShutdown() { }

	internal override int Player2Connection(PlayerRef player) { }

	internal void PlayerAdd(PlayerRef player, SimulationConnection connection) { }

	internal void PlayerRemove(PlayerRef player) { }

	internal bool PlayerValid(PlayerRef player) { }

	private void PreparePackets() { }

	private void RecvMessages() { }

	internal abstract void RecvPacket() { }

	internal void RegisterUniqueIdPlayerMapping(int actorid, Byte[] id, PlayerRef playerRef) { }

	internal void RemoveFromGlobalObjectInterest(NetworkId id) { }

	internal void RequestStateAuthority(NetworkId id, bool wants) { }

	private void ResolveMessageSourceAndTarget(SimulationMessage* msg, PlayerRef sourcePlayer) { }

	internal void SendInternalSimulationMessage(SimulationMessageInternalTypes type, Void* buffer, int bufferLength, Nullable<PlayerRef> target = null) { }

	internal void SendInternalSimulationMessage(SimulationMessageInternalTypes type, T buffer, Nullable<PlayerRef> target = null) { }

	internal RpcSendMessageResult SendMessage(SimulationMessage* message) { }

	private void SendMessageInternal(SimulationMessage* message, NetConnection* netConnection) { }

	internal void SendReliableData(int connection, int target, ReliableKey key, Byte[] data) { }

	internal void set_ReliableDataSendRate(int value) { }

	internal void SetPlayerAlwaysInterested(PlayerRef player, NetworkId id, bool alwaysInterested) { }

	internal void SetPlayerObjectId(PlayerRef player, NetworkId id) { }

	internal void ShutdownNativeSocket() { }

	internal void SinglePlayerSetPaused(bool paused) { }

	internal void SnapshotRelease(ref NetworkObjectHeaderSnapshot snapshot) { }

	internal void SnapshotRelease(NetworkObjectHeaderSnapshot snapshot) { }

	private void StepSimulation(SimulationStages stage, bool lastTick, bool firstTick, bool freeInput) { }

	internal Void* TempAlloc(int size) { }

	internal T* TempAlloc() { }

	internal T* TempAllocArray(int length) { }

	internal T* TempDoubleArray(T* oldArray, int oldLength) { }

	internal void TempFree(Void* ptr) { }

	internal bool TryGetHeader(NetworkId id, out NetworkObjectHeader* header) { }

	public bool TryGetHostPlayer(out PlayerRef player) { }

	internal bool TryGetInstance(NetworkId id, out NetworkObject instance) { }

	internal bool TryGetMeta(NetworkId id, out NetworkObjectMeta meta) { }

	internal bool TryGetObject(NetworkId id, out NetworkObjectHeader* header) { }

	internal bool TryGetSceneInstance(NetworkObjectTypeId sceneObjectTypeId, out NetworkObject instance) { }

	internal bool TryGetSimulationConnectionForPlayer(PlayerRef player, out SimulationConnection sc) { }

	internal bool TryGetStruct(NetworkId id, out NetworkObjectHeader* value) { }

	internal bool TryGetStructData(NetworkId id, out Int32* value, out int wordCount) { }

	internal bool TryGetStructData(NetworkId id, out Int32* value) { }

	internal bool TryGetStructData(NetworkId id, NetworkObjectTypeId typeId, out T* value) { }

	internal bool TryGetStructData(NetworkId id, out T* value) { }

	public int Update(double dt) { }

	private void UpdateAreaOfInterest() { }

	internal void UpdateRemotePrefabs() { }

	private void UpdateSimulationStateForMasterClientObjects(bool isMasterClient) { }

	private bool VerifyMessageTargetObject(NetConnection* netConnection, NetworkId id, out TargetObjectVerificationResult result) { }

	private void WriteMessages() { }

	internal abstract void WritePackets() { }

}

