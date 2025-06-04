namespace Fusion;

public class NetworkPrefabSourceResource : NetworkAssetSourceResource<NetworkObject>, INetworkPrefabSource, INetworkAssetSource<NetworkObject>
{
	public NetworkObjectGuid AssetGuid; //Field offset: 0x30

	private override NetworkObjectGuid Fusion.INetworkPrefabSource.AssetGuid
	{
		private get { } //Length: 12
	}

	public NetworkPrefabSourceResource() { }

	private override NetworkObjectGuid Fusion.INetworkPrefabSource.get_AssetGuid() { }

}

