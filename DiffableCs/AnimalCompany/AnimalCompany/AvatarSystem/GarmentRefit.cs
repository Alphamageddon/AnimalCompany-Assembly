namespace AnimalCompany.AvatarSystem;

public static class GarmentRefit
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <PreProcessCageOcclusion>b__1_0(int x) { }

	}


	private static Int32[] PreProcessCageOcclusion(Int32[] cageTriangles, Vector3[] cageVertices, Vector3[] cageNormals, Int32[] garmentTriangles, Vector3[] garmentVertices) { }

	public static GarmentRefitPreProcessResult PreProcessGarment(Matrix4x4 garmentToCageMatrix, Vector3[] cageVertices, Vector3[] cageNormals, Int32[] cageTriangles, Int32[] garmentTriangles, Vector3[] garmentVertices) { }

	private static bool RaycastTriangle(Vector3 origin, Vector3 direction, Vector3 v0, Vector3 v1, Vector3 v2, out Vector3 hitPoint) { }

	public static void Refit(GarmentRefitPreProcessResult cache, Vector3[] cageVerticesBase, Vector3[] cageVerticesTarget, Int32[] cageTriangles, Mesh garmentMeshWarped) { }

	private static Vector3 TransformPointToDistortedTriangle(Vector3 pv, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 t0, Vector3 t1, Vector3 t2) { }

}

