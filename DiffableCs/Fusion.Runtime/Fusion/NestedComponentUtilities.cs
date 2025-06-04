namespace Fusion;

[Extension]
public static class NestedComponentUtilities
{
	private static class RecyclableList
	{
		public static List<T> List; //Field offset: 0x0

		private static RecyclableList`1() { }

	}

	private static Queue<Transform> nodesQueue; //Field offset: 0x0
	private static Stack<Transform> nodeStack; //Field offset: 0x8

	private static NestedComponentUtilities() { }

	[Extension]
	public static T EnsureRootComponentExists(Transform transform) { }

	[Extension]
	public static T[] FindObjectsOfTypeInOrder(Scene scene, bool includeInactive = false) { }

	[Extension]
	public static void FindObjectsOfTypeInOrder(Scene scene, List<T> list, bool includeInactive = false) { }

	[Extension]
	public static TCast[] FindObjectsOfTypeInOrder(Scene scene, bool includeInactive = false) { }

	[Extension]
	public static void FindObjectsOfTypeInOrder(Scene scene, List<TCast> list, bool includeInactive = false) { }

	[Extension]
	public static T GetNestedComponentInChildren(Transform t, bool includeInactive) { }

	[Extension]
	public static T GetNestedComponentInParent(Transform t) { }

	[Extension]
	public static T GetNestedComponentInParents(Transform t) { }

	[Extension]
	public static List<T> GetNestedComponentsInChildren(Transform t, List<T> list, bool includeInactive = true) { }

	[Extension]
	public static List<T> GetNestedComponentsInChildren(Transform t, List<T> list, bool includeInactive = true, Type[] stopOn) { }

	[Extension]
	public static void GetNestedComponentsInChildren(Transform t, bool includeInactive, List<T> list) { }

	[Extension]
	public static void GetNestedComponentsInParents(Transform t, List<T> list) { }

	[Extension]
	public static void GetNestedComponentsInParents(Transform t, List<T> list) { }

	[Extension]
	public static T GetParentComponent(Transform t) { }

}

