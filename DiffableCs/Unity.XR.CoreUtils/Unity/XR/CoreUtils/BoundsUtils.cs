namespace Unity.XR.CoreUtils;

public static class BoundsUtils
{
	private static readonly List<Renderer> k_Renderers; //Field offset: 0x0
	private static readonly List<Transform> k_Transforms; //Field offset: 0x8

	private static BoundsUtils() { }

	public static Bounds GetBounds(List<GameObject> gameObjects) { }

	public static Bounds GetBounds(Transform[] transforms) { }

	public static Bounds GetBounds(Transform transform) { }

	public static Bounds GetBounds(List<Renderer> renderers) { }

	public static Bounds GetBounds(List<T> colliders) { }

	public static Bounds GetBounds(List<Vector3> points) { }

}

