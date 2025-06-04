namespace UnityEngine.ProBuilder;

[Extension]
internal static class InternalUtility
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string valid; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <TryParseColor>b__0(char c) { }

	}


	public static string ControlKeyString(char character) { }

	[Extension]
	public static T DemandComponent(Component component) { }

	[Extension]
	public static T DemandComponent(GameObject gameObject) { }

	public static GameObject EmptyGameObjectWithTransform(Transform t) { }

	public static T[] GetComponents(GameObject go) { }

	[Extension]
	public static T[] GetComponents(IEnumerable<Transform> transforms) { }

	public static GameObject MeshGameObjectWithTransform(string name, Transform t, Mesh mesh, Material mat, bool inheritParent) { }

	[Extension]
	public static T NextEnumValue(T current) { }

	public static bool TryParseColor(string value, ref Color col) { }

}

