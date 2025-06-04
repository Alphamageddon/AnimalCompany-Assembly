namespace Fusion.Sockets;

public struct NetConnectionMap
{
	internal enum EntryState
	{
		None = 0,
		Free = 1,
		Used = 2,
	}

	internal struct Iterator
	{
		private NetConnectionMap* _map; //Field offset: 0x0
		private int _index; //Field offset: 0x8
		private int _count; //Field offset: 0xC

		public NetConnection* Current
		{
			 get { } //Length: 64
		}

		public bool IsValid
		{
			 get { } //Length: 32
		}

		public Iterator(NetConnectionMap* map) { }

		public NetConnection* get_Current() { }

		public bool get_IsValid() { }

		public bool Next() { }

	}

	private struct UniqueIdMapping
	{
		public long UniqueId; //Field offset: 0x0
		public short Index; //Field offset: 0x8

	}

	private NetConnection** Buckets; //Field offset: 0x0
	private NetConnection* FreeHead; //Field offset: 0x8
	internal NetConnection* Connections; //Field offset: 0x10
	private UniqueIdMapping* UniqueIdHashes; //Field offset: 0x18
	private short Group; //Field offset: 0x20
	private ulong UsedCount; //Field offset: 0x28
	private ulong FreeCount; //Field offset: 0x30
	private ulong IdsCount; //Field offset: 0x38
	private ulong CapacityAllocated; //Field offset: 0x40
	internal ulong CapacityUsable; //Field offset: 0x48

	public NetConnection* ConnectionsBuffer
	{
		 get { } //Length: 8
	}

	public int Count
	{
		 get { } //Length: 16
	}

	public int CountUsed
	{
		 get { } //Length: 8
	}

	public bool Full
	{
		 get { } //Length: 20
	}

	public static NetConnectionMap* Allocate(int capacity, short groupIndex, in NetConfig* config) { }

	private bool ContainsUniqueId(long value, out short groupIndex) { }

	public static void Dispose(NetConnectionMap* map, INetPeerGroupCallbacks callbacks) { }

	public NetConnection* Find(NetAddress address) { }

	public NetConnection* Find(NetConnectionId id) { }

	public NetConnection* FindByIndex(int index) { }

	private ulong FindInsertionIndex(long value) { }

	public NetConnection* get_ConnectionsBuffer() { }

	public int get_Count() { }

	public int get_CountUsed() { }

	public bool get_Full() { }

	public NetConnection* Insert(NetAddress address, Byte[] uniqueId) { }

	public NetConnection* Remap(NetAddress oldAddress, NetAddress newAddress) { }

	public bool Remove(NetAddress address) { }

	private bool RemoveUniqueId(long value) { }

	private void StoreUniqueId(long value, short groupIndex) { }

	public bool TryFindByIndex(int index, out NetConnection* connection) { }

}

