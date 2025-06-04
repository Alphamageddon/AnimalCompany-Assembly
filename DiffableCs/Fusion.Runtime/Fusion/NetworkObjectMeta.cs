namespace Fusion;

public class NetworkObjectMeta
{
	public struct List
	{
		public int Count; //Field offset: 0x0
		public NetworkObjectMeta Head; //Field offset: 0x8
		public NetworkObjectMeta Tail; //Field offset: 0x10

		public void AddAfter(NetworkObjectMeta item, NetworkObjectMeta after) { }

		public void AddBefore(NetworkObjectMeta item, NetworkObjectMeta before) { }

		public void AddFirst(NetworkObjectMeta item) { }

		public void AddLast(NetworkObjectMeta item) { }

		public void Concat(List other) { }

		private bool IsInList(NetworkObjectMeta item) { }

		public static NetworkObjectMeta Next(NetworkObjectMeta item) { }

		public void Remove(NetworkObjectMeta item) { }

		public List RemoveAll() { }

		public NetworkObjectMeta RemoveHead() { }

	}

	public struct ListMigration
	{
		public int Count; //Field offset: 0x0
		public NetworkObjectMeta Head; //Field offset: 0x8
		public NetworkObjectMeta Tail; //Field offset: 0x10

		public void AddAfter(NetworkObjectMeta item, NetworkObjectMeta after) { }

		public void AddBefore(NetworkObjectMeta item, NetworkObjectMeta before) { }

		public void AddFirst(NetworkObjectMeta item) { }

		public void AddLast(NetworkObjectMeta item) { }

		private bool IsInList(NetworkObjectMeta item) { }

		public static NetworkObjectMeta Next(NetworkObjectMeta item) { }

		public void Remove(NetworkObjectMeta item) { }

		public NetworkObjectMeta RemoveHead() { }

	}

	private static NetworkBufferSerializerInfo[] _serializersStatic; //Field offset: 0x0
	internal const int PRIORITY_LEVEL_LOW = 3; //Field offset: 0x0
	internal const int PRIORITY_LEVEL_MED = 2; //Field offset: 0x0
	internal const int PRIORITY_LEVEL_HIGH = 1; //Field offset: 0x0
	internal const int PRIORITY_LEVEL_PLAYER = 0; //Field offset: 0x0
	internal const int PRIORITY_IDLE = -32768; //Field offset: 0x0
	internal const int PRIORITY_LEVEL_LOWEST = 4; //Field offset: 0x0
	internal const int PRIORITY_LEVEL_COUNT = 5; //Field offset: 0x0
	private static NetworkBufferSerializerInfo[] _serializersNone; //Field offset: 0x8
	private Allocator* _allocator; //Field offset: 0x10
	private Int32* _changes; //Field offset: 0x18
	private Simulation _simulation; //Field offset: 0x20
	private NetworkObjectHeaderSnapshot _shadow; //Field offset: 0x28
	private NetworkObjectHeaderSnapshot _render; //Field offset: 0x30
	private NetworkObjectHeaderSnapshot _previous; //Field offset: 0x38
	private NetworkObjectHeaderSnapshot _migration; //Field offset: 0x40
	private NetworkObjectHeaderSnapshotList _snapshots; //Field offset: 0x48
	private NetworkObjectHeaderSnapshot[] _snapshotsByIndex; //Field offset: 0x60
	private Nullable<Tick> _snapshotsByIndexLatest; //Field offset: 0x68
	private Timeline _timeline; //Field offset: 0x70
	private NetworkObjectMeta _prev; //Field offset: 0x78
	private NetworkObjectMeta _next; //Field offset: 0x80
	private NetworkObjectMeta _prevMigration; //Field offset: 0x88
	private NetworkObjectMeta _nextMigration; //Field offset: 0x90
	internal Tick ScannedTick; //Field offset: 0x98
	internal Tick ChangedTick; //Field offset: 0x9C
	internal int AreaOfInterestCell; //Field offset: 0xA0
	internal NetworkObjectMetaFlags Flags; //Field offset: 0xA4
	internal PlayerUniqueData PlayerData; //Field offset: 0xA8
	internal NetworkObjectHeader* Header; //Field offset: 0xB0
	internal NetworkObject Instance; //Field offset: 0xB8

	internal Int32* Changes
	{
		internal get { } //Length: 104
	}

	internal Int32* DataPointer
	{
		internal get { } //Length: 12
	}

	internal bool HasMainTRSP
	{
		internal get { } //Length: 32
	}

	internal bool HasSnapshots
	{
		internal get { } //Length: 16
	}

	public NetworkId Id
	{
		 get { } //Length: 24
	}

	public PlayerRef InputAuthority
	{
		 get { } //Length: 24
	}

	internal bool IsObject
	{
		internal get { } //Length: 28
	}

	internal bool IsStruct
	{
		internal get { } //Length: 28
	}

	internal NetworkTRSPData* MainTRSPData
	{
		internal get { } //Length: 40
	}

	internal NetworkObjectHeaderSnapshotRef Migration
	{
		internal get { } //Length: 44
	}

	internal NetworkObjectHeaderSnapshotRef Previous
	{
		internal get { } //Length: 44
	}

	internal NetworkObjectHeaderSnapshotRef Render
	{
		internal get { } //Length: 44
	}

	internal NetworkBufferSerializerInfo[] Serializers
	{
		internal get { } //Length: 100
	}

	internal NetworkObjectHeaderSnapshotRef Shadow
	{
		internal get { } //Length: 44
	}

	internal NetworkObjectHeaderSnapshotRef SnapshotLatest
	{
		internal get { } //Length: 8
	}

	public PlayerRef StateAuthority
	{
		 get { } //Length: 24
	}

	internal Timeline Timeline
	{
		internal get { } //Length: 132
	}

	public NetworkObjectTypeId Type
	{
		 get { } //Length: 24
	}

	private static NetworkObjectMeta() { }

	internal NetworkObjectMeta(Simulation simulation, Allocator* allocator) { }

	internal void AddLatestSnapshotToTimeline() { }

	internal static int DecodePriorityLevel(int level) { }

	internal static int EncodePriorityLevel(int level) { }

	internal NetworkObjectHeaderSnapshot FindSnapshot(Tick tick) { }

	internal Int32* get_Changes() { }

	internal Int32* get_DataPointer() { }

	internal bool get_HasMainTRSP() { }

	internal bool get_HasSnapshots() { }

	public NetworkId get_Id() { }

	public PlayerRef get_InputAuthority() { }

	internal bool get_IsObject() { }

	internal bool get_IsStruct() { }

	internal NetworkTRSPData* get_MainTRSPData() { }

	internal NetworkObjectHeaderSnapshotRef get_Migration() { }

	internal NetworkObjectHeaderSnapshotRef get_Previous() { }

	internal NetworkObjectHeaderSnapshotRef get_Render() { }

	internal NetworkBufferSerializerInfo[] get_Serializers() { }

	internal NetworkObjectHeaderSnapshotRef get_Shadow() { }

	internal NetworkObjectHeaderSnapshotRef get_SnapshotLatest() { }

	public PlayerRef get_StateAuthority() { }

	internal Timeline get_Timeline() { }

	public NetworkObjectTypeId get_Type() { }

	internal Int32* GetBehaviourPtr(NetworkBehaviour behaviour) { }

	internal int GetPriority(PlayerRef player) { }

	internal static NetworkBufferSerializerInfo[] GetSerializers(bool main) { }

	private NetworkObjectHeaderSnapshot GetSnapshot(NetworkObjectHeader* header, bool copyState) { }

	internal void Init(NetworkObjectHeader* ptr) { }

	internal static bool IsActive(int level) { }

	internal static bool IsIdle(int level) { }

	internal NetworkObjectHeaderSnapshotRef NextSnapshot(Tick tick) { }

	internal void Release() { }

	internal bool TryFindSnapshot(Tick tick, out NetworkObjectHeaderSnapshot snapshot) { }

}

