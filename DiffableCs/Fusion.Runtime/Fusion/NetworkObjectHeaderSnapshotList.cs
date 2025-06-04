namespace Fusion;

internal struct NetworkObjectHeaderSnapshotList
{
	public const int SIZE = 24; //Field offset: 0x0
	public const int ALIGNMENT = 8; //Field offset: 0x0
	private int _count; //Field offset: 0x0
	private NetworkObjectHeaderSnapshot _tail; //Field offset: 0x8
	private NetworkObjectHeaderSnapshot _head; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 8
	}

	public NetworkObjectHeaderSnapshot Latest
	{
		 get { } //Length: 8
	}

	public NetworkObjectHeaderSnapshot Oldest
	{
		 get { } //Length: 8
	}

	public void AddAfter(NetworkObjectHeaderSnapshot after, NetworkObjectHeaderSnapshot item) { }

	public void AddBefore(NetworkObjectHeaderSnapshot before, NetworkObjectHeaderSnapshot item) { }

	public void AddFirst(NetworkObjectHeaderSnapshot item) { }

	public void AddLast(NetworkObjectHeaderSnapshot item) { }

	public int get_Count() { }

	public NetworkObjectHeaderSnapshot get_Latest() { }

	public NetworkObjectHeaderSnapshot get_Oldest() { }

	private bool IsInList(NetworkObjectHeaderSnapshot item) { }

	public void Remove(NetworkObjectHeaderSnapshot item) { }

	public NetworkObjectHeaderSnapshot RemoveLatest() { }

	public NetworkObjectHeaderSnapshot RemoveOldest() { }

}

