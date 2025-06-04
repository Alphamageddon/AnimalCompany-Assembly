namespace Fusion;

public class NetworkObjectProviderDefault : Behaviour, INetworkObjectProvider
{
	[InlineHelp]
	public bool DelayIfSceneManagerIsBusy; //Field offset: 0x20

	public NetworkObjectProviderDefault() { }

	public override NetworkObjectAcquireResult AcquirePrefabInstance(NetworkRunner runner, in NetworkPrefabAcquireContext context, out NetworkObject instance) { }

	protected override void DestroyPrefabInstance(NetworkRunner runner, NetworkPrefabId prefabId, NetworkObject instance) { }

	protected override void DestroyPrefabNestedObject(NetworkRunner runner, NetworkObject instance) { }

	protected override void DestroySceneObject(NetworkRunner runner, NetworkSceneObjectId sceneObjectId, NetworkObject instance) { }

	protected override NetworkObject InstantiatePrefab(NetworkRunner runner, NetworkObject prefab) { }

	public override void ReleaseInstance(NetworkRunner runner, in NetworkObjectReleaseContext context) { }

}

