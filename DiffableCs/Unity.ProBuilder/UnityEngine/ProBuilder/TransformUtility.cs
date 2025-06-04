namespace UnityEngine.ProBuilder;

[Extension]
public static class TransformUtility
{
	private static Dictionary<Transform, Transform[]> s_ChildStack; //Field offset: 0x0

	private static TransformUtility() { }

	[Extension]
	public static Vertex InverseTransformVertex(Transform transform, Vertex vertex) { }

	internal static void ReparentChildren(Transform t) { }

	[Extension]
	public static Vertex TransformVertex(Transform transform, Vertex vertex) { }

	internal static void UnparentChildren(Transform t) { }

}

