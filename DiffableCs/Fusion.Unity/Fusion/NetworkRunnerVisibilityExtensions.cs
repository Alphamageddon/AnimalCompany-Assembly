namespace Fusion;

[Extension]
public static class NetworkRunnerVisibilityExtensions
{
	private class RunnerVisibility
	{
		[CompilerGenerated]
		private bool <IsVisible>k__BackingField; //Field offset: 0x10
		public LinkedList<RunnerVisibilityLink> Nodes; //Field offset: 0x18

		public bool IsVisible
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public RunnerVisibility() { }

		[CompilerGenerated]
		public bool get_IsVisible() { }

		[CompilerGenerated]
		public void set_IsVisible(bool value) { }

	}

	private static readonly String[] RecognizedBehaviourNames; //Field offset: 0x0
	private static readonly Type[] RecognizedBehaviourTypes; //Field offset: 0x8
	private static readonly Dictionary<NetworkRunner, RunnerVisibility> DictionaryLookup; //Field offset: 0x10
	private static bool _commonLinksWithMissingInputAuthNeedRefresh; //Field offset: 0x18
	private static readonly Dictionary<String, List`1<RunnerVisibilityLink>> CommonObjectLookup; //Field offset: 0x20

	private static NetworkRunnerVisibilityExtensions() { }

	private static void AddNodeToCommonLookup(RunnerVisibilityLink link) { }

	[Extension]
	public static void AddVisibilityNodes(NetworkRunner runner, GameObject go) { }

	private static void CollectBehavioursAndAddNodes(GameObject go, NetworkRunner runner, List<RunnerVisibilityLink> existingNodes) { }

	[Extension]
	public static void DisableVisibilityExtension(NetworkRunner runner) { }

	[Extension]
	public static void EnableVisibilityExtension(NetworkRunner runner) { }

	[Extension]
	private static RunnerVisibility GetVisibilityInfo(NetworkRunner runner) { }

	[Extension]
	private static LinkedList<RunnerVisibilityLink> GetVisibilityNodes(NetworkRunner runner) { }

	[Extension]
	public static bool GetVisible(NetworkRunner runner) { }

	[Extension]
	public static bool HasVisibilityEnabled(NetworkRunner runner) { }

	[Extension]
	internal static bool IsRecognizedByRunnerVisibility(Type type) { }

	internal static void RefreshCommonObjectVisibilities() { }

	private static void RefreshRunnerVisibility(NetworkRunner runner, bool refreshCommonObjects = true) { }

	private static void RegisterNode(RunnerVisibilityLink link, NetworkRunner runner, Component comp) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void ResetAllSimulationStatics() { }

	internal static void ResetStatics() { }

	public static void RetryRefreshCommonLinks() { }

	[Extension]
	public static void SetVisible(NetworkRunner runner, bool isVisibile) { }

	[Extension]
	public static void UnregisterNode(RunnerVisibilityLink link) { }

}

