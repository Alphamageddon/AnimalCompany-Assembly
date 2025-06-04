namespace Fusion;

internal class NetworkObjectPriorityList
{
	public PlayerRef Player; //Field offset: 0x10
	public NetworkObjectConnectionDataList Idle; //Field offset: 0x18
	private NetworkObjectConnectionDataList[] Levels; //Field offset: 0x30

	public NetworkObjectPriorityList() { }

	public void Add(NetworkObjectConnectionData item) { }

	public NetworkObjectConnectionDataList GetLevelList(int level) { }

	public void IncreasePriorities() { }

	public void Remove(NetworkObjectConnectionData item) { }

	public void RemoveSent(NetworkObjectConnectionData item) { }

	public void SetActive(NetworkObjectConnectionData item, NetworkObjectMeta meta) { }

	public void SetIdle(NetworkObjectConnectionData item) { }

}

