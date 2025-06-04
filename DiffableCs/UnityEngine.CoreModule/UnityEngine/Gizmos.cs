namespace UnityEngine;

[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
[StaticAccessor("GizmoBindings", StaticAccessorType::DoubleColon (2))]
public sealed class Gizmos
{

	public static Color color
	{
		 get { } //Length: 72
		 set { } //Length: 68
	}

	public static Matrix4x4 matrix
	{
		 get { } //Length: 100
		 set { } //Length: 60
	}

	[NativeThrows]
	public static void DrawCube(Vector3 center, Vector3 size) { }

	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	[NativeThrows]
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	[NativeThrows]
	public static void DrawLine(Vector3 from, Vector3 to) { }

	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation) { }

	[NativeThrows]
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	public static void DrawRay(Vector3 from, Vector3 direction) { }

	[NativeThrows]
	public static void DrawSphere(Vector3 center, float radius) { }

	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	[NativeThrows]
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	[NativeThrows]
	public static void DrawWireSphere(Vector3 center, float radius) { }

	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	public static Color get_color() { }

	private static void get_color_Injected(out Color ret) { }

	public static Matrix4x4 get_matrix() { }

	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	public static void set_color(Color value) { }

	private static void set_color_Injected(ref Color value) { }

	public static void set_matrix(Matrix4x4 value) { }

	private static void set_matrix_Injected(ref Matrix4x4 value) { }

}

