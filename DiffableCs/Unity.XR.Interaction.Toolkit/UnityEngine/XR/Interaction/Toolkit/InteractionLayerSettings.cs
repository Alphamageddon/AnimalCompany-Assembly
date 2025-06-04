namespace UnityEngine.XR.Interaction.Toolkit;

[ScriptableSettingsPath("Assets/XRI/Settings")]
internal class InteractionLayerSettings : ScriptableSettings<InteractionLayerSettings>, ISerializationCallbackReceiver
{
	private const string k_DefaultLayerName = "Default"; //Field offset: 0x0
	internal const int layerSize = 32; //Field offset: 0x0
	internal const int builtInLayerSize = 1; //Field offset: 0x0
	[SerializeField]
	private String[] m_LayerNames; //Field offset: 0x18

	public InteractionLayerSettings() { }

	internal int GetLayer(string layerName) { }

	internal string GetLayerNameAt(int index) { }

	internal void GetLayerNamesAndValues(List<String> names, List<Int32> values) { }

	internal bool IsLayerEmpty(int index) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	internal void SetLayerNameAt(int index, string layerName) { }

}

