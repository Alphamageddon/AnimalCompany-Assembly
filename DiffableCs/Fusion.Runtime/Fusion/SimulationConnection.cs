namespace Fusion;

internal class SimulationConnection
{
	public const int INTEGRATOR_HISTORY_MULT = 10; //Field offset: 0x0
	private Simulation _simulation; //Field offset: 0x10
	private Dictionary<NetworkId, NetworkObjectConnectionData> _objects; //Field offset: 0x18
	private Queue<NetworkId> _objectsDestroyed; //Field offset: 0x20
	public PlayerRef Player; //Field offset: 0x28
	public bool AreaOfInterestHasBeenUpdated; //Field offset: 0x2C
	public HashSet<Int32> AreaOfInterestCells; //Field offset: 0x30
	public ulong MessagesInSequence; //Field offset: 0x38
	public ulong MessagesOutSequence; //Field offset: 0x40
	public SimulationMessageList MessagesIn; //Field offset: 0x48
	public SimulationMessageList MessagesOut; //Field offset: 0x60
	internal double LastSend; //Field offset: 0x78
	internal int ActiveStructsVersion; //Field offset: 0x80
	internal int ActiveStructsIndex; //Field offset: 0x84
	internal List<NetworkObjectConnectionData> ActiveStructs; //Field offset: 0x88
	internal TimeSeries _packetRecvDelta; //Field offset: 0x90
	internal Timer _packetRecvDeltaTimer; //Field offset: 0x98
	internal Buffer _inputs; //Field offset: 0xB0
	internal TimeSeries _clientOffset; //Field offset: 0xB8
	internal Tick _latestTickReceived; //Field offset: 0xC0
	internal Tick _latestTickAcknowledged; //Field offset: 0xC4
	internal NetworkObjectPriorityList ObjectPriorityList; //Field offset: 0xC8
	internal NetConnection* Connection; //Field offset: 0xD0
	internal NetConnectionId ConnectionId; //Field offset: 0xD8
	internal HashSet<NetworkId> PendingDeleteMainTRSP; //Field offset: 0xE0

	public int ConnectionIndex
	{
		 get { } //Length: 28
	}

	public int DestroysPending
	{
		 get { } //Length: 72
	}

	internal SimulationConnection(Simulation simulation) { }

	public void AddAlwaysInterested(NetworkObjectMeta meta) { }

	public bool DestroyedNextId(out NetworkId id) { }

	public void Free(Simulation simulation) { }

	public int get_ConnectionIndex() { }

	public int get_DestroysPending() { }

	public NetworkObjectConnectionData GetObjectData(NetworkId id, bool create, bool allowFail = false) { }

	public int GetPriority(NetworkObjectMeta meta) { }

	public void InputReceiveDelta(Tick tick, double receive, double expected) { }

	public void ObjectData_Destroyed(NetworkId id) { }

	public Nullable<Boolean> ObjectData_IsCreateUnconfirmed(NetworkId id) { }

	public Nullable<Boolean> ObjectData_IsDestroyUnconfirmed(NetworkId id) { }

	public void ObjectData_Remove(NetworkId id) { }

	public static PlayerRef op_Implicit(SimulationConnection c) { }

	public void PacketReceiveDelta() { }

	public void RemoveAlwaysInterested(NetworkObjectMeta meta) { }

	public void ResetTimeFeedback() { }

	public void SetActive(NetworkObjectConnectionData data, NetworkObjectMeta meta) { }

	public void SetIdle(NetworkObjectConnectionData data) { }

	public bool TryGetObjectData(NetworkId id, out NetworkObjectConnectionData data) { }

}

