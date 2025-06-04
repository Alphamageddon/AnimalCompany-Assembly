namespace Fusion;

public class NetworkPrefabSourceStaticLazy : NetworkAssetSourceStaticLazy<NetworkObject>, INetworkPrefabSource, INetworkAssetSource<NetworkObject>
{
	public NetworkObjectGuid AssetGuid; //Field offset: 0x18

	private override NetworkObjectGuid Fusion.INetworkPrefabSource.AssetGuid
	{
		private get { } //Length: 12
	}

	public NetworkPrefabSourceStaticLazy() { }

	private override NetworkObjectGuid Fusion.INetworkPrefabSource.get_AssetGuid() { }

}

