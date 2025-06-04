namespace Fusion;

internal static class FusionRuntimeCheck
{

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void RuntimeCheck() { }

}

