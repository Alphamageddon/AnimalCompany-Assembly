namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GeometryUtilityScripting", StaticAccessorType::DoubleColon (2))]
public sealed class GeometryUtility
{

	public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	[NativeName("ExtractPlanes")]
	private static void Internal_ExtractPlanes(out Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	private static void Internal_ExtractPlanes_Injected(out Plane[] planes, ref Matrix4x4 worldToProjectionMatrix) { }

	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	private static bool TestPlanesAABB_Injected(Plane[] planes, ref Bounds bounds) { }

}

