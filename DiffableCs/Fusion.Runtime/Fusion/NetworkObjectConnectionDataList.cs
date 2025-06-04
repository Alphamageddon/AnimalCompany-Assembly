namespace Fusion;

internal struct NetworkObjectConnectionDataList
{
	public int Count; //Field offset: 0x0
	public NetworkObjectConnectionData Head; //Field offset: 0x8
	public NetworkObjectConnectionData Tail; //Field offset: 0x10

	public void AddAfter(NetworkObjectConnectionData item, NetworkObjectConnectionData after) { }

	public void AddBefore(NetworkObjectConnectionData item, NetworkObjectConnectionData before) { }

	public void AddFirst(NetworkObjectConnectionData item) { }

	public void AddLast(NetworkObjectConnectionData item) { }

	public void Concat(ref NetworkObjectConnectionDataList other) { }

	private bool IsInList(NetworkObjectConnectionData item) { }

	public void Remove(NetworkObjectConnectionData item) { }

	public NetworkObjectConnectionDataList RemoveAll() { }

	public NetworkObjectConnectionData RemoveHead() { }

}

