namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

[Preserve]
public static class XRDeviceSimulatorLoader
{

	[Preserve]
	private static XRDeviceSimulatorLoader() { }

	[Preserve]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterSceneLoad (0))]
	public static void Initialize() { }

}

