namespace Fusion;

public interface INetworkObjectProvider
{

	public NetworkObjectAcquireResult AcquirePrefabInstance(NetworkRunner runner, in NetworkPrefabAcquireContext context, out NetworkObject result) { }

	public void ReleaseInstance(NetworkRunner runner, in NetworkObjectReleaseContext context) { }

}

