namespace Fusion;

[IsReadOnly]
public struct NetworkPrefabAcquireContext
{
	public readonly NetworkPrefabId PrefabId; //Field offset: 0x0
	public readonly NetworkObjectMeta Meta; //Field offset: 0x8
	public readonly bool IsSynchronous; //Field offset: 0x10
	public readonly bool DontDestroyOnLoad; //Field offset: 0x11

	public Int32* Data
	{
		 get { } //Length: 80
	}

	public bool HasHeader
	{
		 get { } //Length: 16
	}

	public NetworkPrefabAcquireContext(NetworkPrefabId prefabId, NetworkObjectMeta meta = null, bool isSynchronous = true, bool dontDestroyOnLoad = false) { }

	public Int32* get_Data() { }

	public bool get_HasHeader() { }

}

