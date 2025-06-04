namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

[ScriptableSettingsPath("Assets/XRI/Settings")]
internal class XRDeviceSimulatorSettings : ScriptableSettings<XRDeviceSimulatorSettings>
{
	[SerializeField]
	private bool m_AutomaticallyInstantiateSimulatorPrefab; //Field offset: 0x18
	[SerializeField]
	private bool m_AutomaticallyInstantiateInEditorOnly; //Field offset: 0x19
	[SerializeField]
	private GameObject m_SimulatorPrefab; //Field offset: 0x20

	internal bool automaticallyInstantiateInEditorOnly
	{
		internal get { } //Length: 8
		internal set { } //Length: 12
	}

	internal bool automaticallyInstantiateSimulatorPrefab
	{
		internal get { } //Length: 8
		internal set { } //Length: 12
	}

	internal GameObject simulatorPrefab
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public XRDeviceSimulatorSettings() { }

	internal bool get_automaticallyInstantiateInEditorOnly() { }

	internal bool get_automaticallyInstantiateSimulatorPrefab() { }

	internal GameObject get_simulatorPrefab() { }

	internal void set_automaticallyInstantiateInEditorOnly(bool value) { }

	internal void set_automaticallyInstantiateSimulatorPrefab(bool value) { }

	internal void set_simulatorPrefab(GameObject value) { }

}

