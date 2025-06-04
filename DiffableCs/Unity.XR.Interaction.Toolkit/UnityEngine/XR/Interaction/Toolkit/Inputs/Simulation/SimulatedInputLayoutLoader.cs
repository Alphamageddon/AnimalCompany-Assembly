namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

[Preserve]
public static class SimulatedInputLayoutLoader
{

	[Preserve]
	private static SimulatedInputLayoutLoader() { }

	[Preserve]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	public static void Initialize() { }

	private static void RegisterInputLayouts() { }

}

