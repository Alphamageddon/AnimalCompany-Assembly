namespace Fusion.Sockets;

internal struct NetPeerGroupMap
{
	internal struct Entry
	{
		public Entry* Next; //Field offset: 0x0
		public ulong Hash; //Field offset: 0x8
		public EntryState State; //Field offset: 0x10
		public NetAddress Address; //Field offset: 0x18
		public short Group; //Field offset: 0x30

	}

	internal enum EntryState
	{
		None = 0,
		Free = 1,
		Used = 2,
	}

	public Entry** Buckets; //Field offset: 0x0
	public Entry* Entries; //Field offset: 0x8
	public Entry* FreeHead; //Field offset: 0x10
	public ulong UsedCount; //Field offset: 0x18
	public ulong FreeCount; //Field offset: 0x20
	public ulong CapacityUsable; //Field offset: 0x28
	public ulong CapacityAllocated; //Field offset: 0x30

	public ulong Count
	{
		 get { } //Length: 12
	}

	public bool Full
	{
		 get { } //Length: 20
	}

	public static NetPeerGroupMap* Allocate(int capacity) { }

	public static void Dispose(NetPeerGroupMap* map) { }

	public short Find(NetAddress address) { }

	public ulong get_Count() { }

	public bool get_Full() { }

	public bool Insert(NetAddress address, short group) { }

	public int Remove(NetAddress address) { }

}

