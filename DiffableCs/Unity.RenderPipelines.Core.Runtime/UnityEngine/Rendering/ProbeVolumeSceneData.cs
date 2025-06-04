namespace UnityEngine.Rendering;

public class ProbeVolumeSceneData : ISerializationCallbackReceiver
{
	public class BakingSet
	{
		public string name; //Field offset: 0x10
		public List<String> sceneGUIDs; //Field offset: 0x18
		public ProbeVolumeBakingProcessSettings settings; //Field offset: 0x20
		public ProbeReferenceVolumeProfile profile; //Field offset: 0x50
		public List<String> lightingScenarios; //Field offset: 0x58

		public BakingSet() { }

		internal string CreateScenario(string name) { }

		internal bool RemoveScenario(string name) { }

	}

	private struct SerializableBoundItem
	{
		[SerializeField]
		public string sceneGUID; //Field offset: 0x0
		[SerializeField]
		public Bounds bounds; //Field offset: 0x8

	}

	private struct SerializableHasPVItem
	{
		[SerializeField]
		public string sceneGUID; //Field offset: 0x0
		[SerializeField]
		public bool hasProbeVolumes; //Field offset: 0x8

	}

	private struct SerializablePVBakeSettings
	{
		public string sceneGUID; //Field offset: 0x0
		public ProbeVolumeBakingProcessSettings settings; //Field offset: 0x8

	}

	private struct SerializablePVProfile
	{
		[SerializeField]
		public string sceneGUID; //Field offset: 0x0
		[SerializeField]
		public ProbeReferenceVolumeProfile profile; //Field offset: 0x8

	}

	private static PropertyInfo s_SceneGUID; //Field offset: 0x0
	[SerializeField]
	private List<SerializableBoundItem> serializedBounds; //Field offset: 0x10
	[SerializeField]
	private List<SerializableHasPVItem> serializedHasVolumes; //Field offset: 0x18
	[SerializeField]
	private List<SerializablePVProfile> serializedProfiles; //Field offset: 0x20
	[SerializeField]
	private List<SerializablePVBakeSettings> serializedBakeSettings; //Field offset: 0x28
	[SerializeField]
	private List<BakingSet> serializedBakingSets; //Field offset: 0x30
	internal object parentAsset; //Field offset: 0x38
	internal string parentSceneDataPropertyName; //Field offset: 0x40
	public Dictionary<String, Bounds> sceneBounds; //Field offset: 0x48
	internal Dictionary<String, Boolean> hasProbeVolumes; //Field offset: 0x50
	internal Dictionary<String, ProbeReferenceVolumeProfile> sceneProfiles; //Field offset: 0x58
	internal Dictionary<String, ProbeVolumeBakingProcessSettings> sceneBakingSettings; //Field offset: 0x60
	internal List<BakingSet> bakingSets; //Field offset: 0x68
	[SerializeField]
	private string m_LightingScenario; //Field offset: 0x70
	private string m_OtherScenario; //Field offset: 0x78
	private float m_ScenarioBlendingFactor; //Field offset: 0x80

	internal string lightingScenario
	{
		internal get { } //Length: 8
	}

	internal string otherScenario
	{
		internal get { } //Length: 8
	}

	internal float scenarioBlendingFactor
	{
		internal get { } //Length: 8
	}

	private static ProbeVolumeSceneData() { }

	public ProbeVolumeSceneData(object parentAsset, string parentSceneDataPropertyName) { }

	internal void BlendLightingScenario(string otherScenario, float blendingFactor) { }

	internal BakingSet CreateNewBakingSet(string name) { }

	internal string get_lightingScenario() { }

	internal string get_otherScenario() { }

	internal float get_scenarioBlendingFactor() { }

	internal static string GetSceneGUID(Scene scene) { }

	private void InitializeBakingSet(BakingSet set, string name) { }

	private void InitializeScenarios(BakingSet set) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	internal void SetActiveScenario(string scenario) { }

	public void SetParentObject(object parent, string parentSceneDataPropertyName) { }

	internal void SyncBakingSetSettings() { }

	private void UpdateBakingSets() { }

}

