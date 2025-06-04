namespace Fusion;

[IsReadOnly]
public struct NetworkPrefabInfo
{
	public readonly NetworkPrefabId Prefab; //Field offset: 0x0
	public readonly NetworkObjectHeader* Header; //Field offset: 0x8
	public readonly bool IsSynchronous; //Field offset: 0x10

	public Int32* Data
	{
		 get { } //Length: 76
	}

	public bool HasHeader
	{
		 get { } //Length: 16
	}

	internal NetworkPrefabInfo(NetworkPrefabId prefab, NetworkObjectHeader* header, bool synchronous) { }

	public Int32* get_Data() { }

	public bool get_HasHeader() { }

}

