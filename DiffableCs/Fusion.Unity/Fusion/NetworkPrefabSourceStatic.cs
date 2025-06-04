namespace Fusion;

public class NetworkPrefabSourceStatic : NetworkAssetSourceStatic<NetworkObject>, INetworkPrefabSource, INetworkAssetSource<NetworkObject>
{
	public NetworkObjectGuid AssetGuid; //Field offset: 0x18

	private override NetworkObjectGuid Fusion.INetworkPrefabSource.AssetGuid
	{
		private get { } //Length: 12
	}

	public NetworkPrefabSourceStatic() { }

	private override NetworkObjectGuid Fusion.INetworkPrefabSource.get_AssetGuid() { }

}

