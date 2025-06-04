namespace UnityEngine.Playables;

[Extension]
public static class PlayableExtensions
{

	[Extension]
	public static int AddInput(U playable, V sourcePlayable, int sourceOutputIndex, float weight = 0) { }

	[Extension]
	public static void ConnectInput(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) { }

	[Extension]
	public static PlayableGraph GetGraph(U playable) { }

	[Extension]
	public static int GetInputCount(U playable) { }

	[Extension]
	public static void SetInputCount(U playable, int value) { }

	[Extension]
	public static void SetInputWeight(U playable, int inputIndex, float weight) { }

}

