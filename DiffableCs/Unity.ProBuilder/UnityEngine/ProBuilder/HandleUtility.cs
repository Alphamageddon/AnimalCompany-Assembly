namespace UnityEngine.ProBuilder;

[Extension]
public static class HandleUtility
{

	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, out RaycastHit hit, HashSet<Face> ignore = null) { }

	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, out RaycastHit hit, float distance, CullingMode cullingMode, HashSet<Face> ignore = null) { }

	internal static bool FaceRaycast(Ray InWorldRay, ProBuilderMesh mesh, out List<RaycastHit>& hits, CullingMode cullingMode, HashSet<Face> ignore = null) { }

	internal static bool FaceRaycastBothCullModes(Ray worldRay, ProBuilderMesh mesh, ref SimpleTuple<Face, Vector3>& back, ref SimpleTuple<Face, Vector3>& front) { }

	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<Int32> vertices) { }

	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<Edge> edges) { }

	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, Edge edge) { }

	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<Edge> edges) { }

	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, Face face) { }

	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<Face> faces) { }

	public static Quaternion GetRotation(ProBuilderMesh mesh, IEnumerable<Int32> indices) { }

	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<Int32> vertices) { }

	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, int vertex) { }

	[Extension]
	internal static Ray InverseTransformRay(Transform transform, Ray InWorldRay) { }

	internal static bool MeshRaycast(Ray InRay, Vector3[] mesh, Int32[] triangles, out RaycastHit hit, float distance = ∞) { }

	internal static bool MeshRaycast(Ray InWorldRay, GameObject gameObject, out RaycastHit hit, float distance = ∞) { }

	internal static bool PointIsOccluded(Camera cam, ProBuilderMesh pb, Vector3 worldPoint) { }

	[Extension]
	internal static Vector3 ScreenToGuiPoint(Camera camera, Vector3 point, float pixelsPerPoint) { }

}

