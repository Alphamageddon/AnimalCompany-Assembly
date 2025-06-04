namespace UnityEngine.Rendering;

[AddComponentMenu(null)]
[ExecuteAlways]
public class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver
{
	public struct PerScenarioData
	{
		public int sceneHash; //Field offset: 0x0
		public TextAsset cellDataAsset; //Field offset: 0x8
		public TextAsset cellOptionalDataAsset; //Field offset: 0x10

	}

	private struct SerializablePerScenarioDataItem
	{
		public string scenario; //Field offset: 0x0
		public PerScenarioData data; //Field offset: 0x8

	}

	[SerializeField]
	internal ProbeVolumeAsset asset; //Field offset: 0x20
	[SerializeField]
	internal TextAsset cellSharedDataAsset; //Field offset: 0x28
	[SerializeField]
	internal TextAsset cellSupportDataAsset; //Field offset: 0x30
	[SerializeField]
	private List<SerializablePerScenarioDataItem> serializedScenarios; //Field offset: 0x38
	internal Dictionary<String, PerScenarioData> scenarios; //Field offset: 0x40
	private bool assetLoaded; //Field offset: 0x48
	private string activeScenario; //Field offset: 0x50
	private string otherScenario; //Field offset: 0x58

	public ProbeVolumePerSceneData() { }

	internal void Clear() { }

	internal void Initialize() { }

	private void OnDisable() { }

	private void OnEnable() { }

	internal void QueueAssetLoading() { }

	internal void QueueAssetRemoval() { }

	internal void RemoveScenario(string scenario) { }

	internal void RenameScenario(string scenario, string newName) { }

	internal bool ResolveCells() { }

	private bool ResolvePerScenarioCellData() { }

	internal bool ResolveSharedCellData() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	internal void UpdateActiveScenario(string activeScenario, string otherScenario) { }

}

