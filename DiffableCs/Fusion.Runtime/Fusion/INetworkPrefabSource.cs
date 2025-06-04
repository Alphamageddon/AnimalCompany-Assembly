namespace Fusion;

public interface INetworkPrefabSource : INetworkAssetSource<NetworkObject>
{

	public NetworkObjectGuid AssetGuid
	{
		 get { } //Length: 0
	}

	public NetworkObjectGuid get_AssetGuid() { }

}

