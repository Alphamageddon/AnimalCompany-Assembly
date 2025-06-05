namespace AnimalCompany;

public class NetworkVFX : SimulationBehaviour
{
	private static NetworkVFX _instance; //Field offset: 0x0
	public NetworkRunner runner; //Field offset: 0x48
	public SerializableDictionary<NetworkVFXType, ParticleSystem> particles; //Field offset: 0x50

	public NetworkVFX() { }

	private void Awake() { }

	private void HandleNewRunner(NetworkRunner runner) { }

	public static void PlayVFX(NetworkVFXType type, Vector3 position, Quaternion rotation) { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	private static void RPC_PlayVFX(NetworkRunner runner, NetworkVFXType type, Vector3 position, Quaternion rotation) { }

	[NetworkRpcStaticWeavedInvoker("System.Void AnimalCompany.NetworkVFX::RPC_PlayVFX(Fusion.NetworkRunner,AnimalCompany.NetworkVFXType,UnityEngine.Vector3,UnityEngine.Quaternion)")]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayVFX@Invoker(NetworkRunner runner, SimulationMessage* message) { }

}

