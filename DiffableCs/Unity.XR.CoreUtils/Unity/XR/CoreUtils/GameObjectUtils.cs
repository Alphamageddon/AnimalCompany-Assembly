namespace Unity.XR.CoreUtils;

[Extension]
public static class GameObjectUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <GetNamedChild>b__0(Transform currentTransform) { }

	}

	private static readonly List<GameObject> k_GameObjects; //Field offset: 0x0
	private static readonly List<Transform> k_Transforms; //Field offset: 0x8
	[CompilerGenerated]
	private static Action<GameObject> GameObjectInstantiated; //Field offset: 0x10

	public static event Action<GameObject> GameObjectInstantiated
	{
		[CompilerGenerated]
		 add { } //Length: 244
		[CompilerGenerated]
		 remove { } //Length: 244
	}

	private static GameObjectUtils() { }

	[CompilerGenerated]
	public static void add_GameObjectInstantiated(Action<GameObject> value) { }

	public static GameObject CloneWithHideFlags(GameObject original, Transform parent = null) { }

	private static void CopyHideFlagsRecursively(GameObject copyFrom, GameObject copyTo) { }

	public static GameObject Create() { }

	public static GameObject Create(string name) { }

	public static T ExhaustiveComponentSearch(GameObject desiredSource) { }

	public static T ExhaustiveTaggedComponentSearch(GameObject desiredSource, string tag) { }

	[Extension]
	public static void GetChildGameObjects(GameObject go, List<GameObject> childGameObjects) { }

	public static T GetComponentInActiveScene() { }

	public static T GetComponentInScene(Scene scene) { }

	public static void GetComponentsInActiveScene(List<T> components, bool includeInactive = false) { }

	public static void GetComponentsInAllScenes(List<T> components, bool includeInactive = false) { }

	public static void GetComponentsInScene(Scene scene, List<T> components, bool includeInactive = false) { }

	[Extension]
	public static GameObject GetNamedChild(GameObject go, string name) { }

	public static GameObject Instantiate(GameObject original, Vector3 position, Quaternion rotation) { }

	public static GameObject Instantiate(GameObject original, Transform parent = null, bool worldPositionStays = true) { }

	public static GameObject Instantiate(GameObject original, Transform parent, Vector3 position, Quaternion rotation) { }

	[CompilerGenerated]
	public static void remove_GameObjectInstantiated(Action<GameObject> value) { }

}

