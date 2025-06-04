namespace UnityEngine.Animations.Rigging;

internal static class RigBuilderUtils
{
	internal struct PlayableChain
	{
		public string name; //Field offset: 0x0
		public Playable[] playables; //Field offset: 0x8

		public bool IsValid() { }

	}

	private static readonly ushort k_AnimationOutputPriority; //Field offset: 0x0

	private static RigBuilderUtils() { }

	public static PlayableGraph BuildPlayableGraph(Animator animator, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer) { }

	public static void BuildPlayableGraph(PlayableGraph graph, Animator animator, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer) { }

	public static IEnumerable<PlayableChain> BuildPlayables(Animator animator, PlayableGraph graph, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer) { }

	public static Playable[] BuildRigPlayables(PlayableGraph graph, IRigLayer layer) { }

}

