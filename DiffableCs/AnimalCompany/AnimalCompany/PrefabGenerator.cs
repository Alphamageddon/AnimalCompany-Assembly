namespace AnimalCompany;

public class PrefabGenerator : SimulationBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnBeforeSpawned <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <GeneratePrefabInternal>b__11_0(NetworkRunner runner, NetworkObject o) { }

	}

	internal enum PrefabType
	{
		DeadBody_Poop = 0,
		Splashes = 1,
	}

	private static Dictionary<PrefabType, RandomPrefab> _prefabDictionary; //Field offset: 0x0
	private static PrefabGenerator _instance; //Field offset: 0x8
	public NetworkRunner runner; //Field offset: 0x48
	private List<NetworkObject> _generatedPrefabs; //Field offset: 0x50
	[SerializeField]
	private LayerMask _groundLayerMask; //Field offset: 0x58

	private static PrefabGenerator() { }

	public PrefabGenerator() { }

	private void Awake() { }

	public static void GeneratePrefab(PrefabType prefabType, Vector3 position, Quaternion rotation, bool onGround = false) { }

	private static void GeneratePrefabInternal(PrefabType prefabType, Vector3 position, Quaternion rotation) { }

	private void HandleNewRunner(NetworkRunner runner) { }

	private static GameObject LoadPrefab(PrefabType prefabType) { }

	private void OnDestroy() { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	public static void RPC_GeneratePrefab(NetworkRunner runner, PrefabType prefabType, Vector3 position, Quaternion rotation) { }

	[NetworkRpcStaticWeavedInvoker("System.Void AnimalCompany.PrefabGenerator::RPC_GeneratePrefab(Fusion.NetworkRunner,AnimalCompany.PrefabGenerator/PrefabType,UnityEngine.Vector3,UnityEngine.Quaternion)")]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_GeneratePrefab@Invoker(NetworkRunner runner, SimulationMessage* message) { }

}

