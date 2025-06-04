namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class MeshTransform
{

	[Extension]
	public static void CenterPivot(ProBuilderMesh mesh, Int32[] indexes) { }

	[Extension]
	public static void FreezeScaleTransform(ProBuilderMesh mesh) { }

	[Extension]
	internal static void SetPivot(ProBuilderMesh mesh, PivotLocation pivotLocation) { }

	[Extension]
	public static void SetPivot(ProBuilderMesh mesh, Vector3 worldPosition) { }

}

