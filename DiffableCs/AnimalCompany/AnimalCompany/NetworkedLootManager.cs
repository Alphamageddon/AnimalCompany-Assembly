namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class NetworkedLootManager : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public LootSpawnGroup spawnGroup; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <Spawned>b__0(NetworkRunner runner, NetworkObject obj) { }

	}

	[SerializeField]
	private NetworkedLootSpawnGroup _networkedLootSpawnPrefab; //Field offset: 0x80
	private LootSpawnGroup[] _lootSpawnGroups; //Field offset: 0x88

	public NetworkedLootManager() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Spawned() { }

}

