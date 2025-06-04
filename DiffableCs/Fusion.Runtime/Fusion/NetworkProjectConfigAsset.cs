namespace Fusion;

[FusionGlobalScriptableObject("Assets/Photon/Fusion/Resources/NetworkProjectConfig.fusion", DefaultContentsGeneratorMethod = "GenerateDefaultContents")]
[ScriptHelp]
public class NetworkProjectConfigAsset : FusionGlobalScriptableObject<NetworkProjectConfigAsset>
{
	internal struct SerializableSimulationBehaviourMeta
	{
		public SerializableType<SimulationBehaviour> Type; //Field offset: 0x0
		public int ExecutionOrder; //Field offset: 0x8

	}

	[DrawInline]
	[SerializeField]
	public NetworkProjectConfig Config; //Field offset: 0x20
	[HideArrayElementLabel]
	[InlineHelp]
	[ResolveNetworkPrefabSource]
	[SerializeReference]
	public List<INetworkPrefabSource> Prefabs; //Field offset: 0x28
	public NetworkPrefabTableOptions PrefabOptions; //Field offset: 0x30
	[InlineHelp]
	[ReadOnly]
	[SerializeField]
	public SerializableSimulationBehaviourMeta[] BehaviourMeta; //Field offset: 0x38

	public static NetworkProjectConfigAsset Global
	{
		 get { } //Length: 64
	}

	public static bool IsGlobalLoaded
	{
		 get { } //Length: 64
	}

	public NetworkProjectConfigAsset() { }

	private static string GenerateDefaultContents() { }

	public static NetworkProjectConfigAsset get_Global() { }

	public static bool get_IsGlobalLoaded() { }

	protected virtual void OnDisable() { }

	private void OnEnable() { }

	public static bool TryGetGlobal(out NetworkProjectConfigAsset global) { }

	public static void UnloadGlobal() { }

}

