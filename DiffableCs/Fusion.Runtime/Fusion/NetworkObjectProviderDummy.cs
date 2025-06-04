namespace Fusion;

public class NetworkObjectProviderDummy : INetworkObjectProvider
{

	public NetworkObjectProviderDummy() { }

	public NetworkObjectAcquireResult AcquirePrefabInstance(NetworkRunner runner, in NetworkPrefabAcquireContext context, out NetworkObject instance) { }

	private override NetworkObjectAcquireResult Fusion.INetworkObjectProvider.AcquirePrefabInstance(NetworkRunner runner, in NetworkPrefabAcquireContext context, out NetworkObject result) { }

	private override void Fusion.INetworkObjectProvider.ReleaseInstance(NetworkRunner runner, in NetworkObjectReleaseContext context) { }

	public void ReleaseInstance(NetworkRunner runner, in NetworkObjectReleaseContext context) { }

}

