namespace UnityEngine.ProBuilder;

public static class Smoothing
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Face, Int32> <>9__5_0; //Field offset: 0x8
		public static Func<Face, Int32> <>9__9_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <ApplySmoothingGroups>b__9_0(Face x) { }

		internal int <GetUnusedSmoothingGroup>b__5_0(Face x) { }

	}

	internal const int smoothingGroupNone = 0; //Field offset: 0x0
	internal const int smoothRangeMin = 1; //Field offset: 0x0
	internal const int smoothRangeMax = 24; //Field offset: 0x0
	internal const int hardRangeMin = 25; //Field offset: 0x0
	internal const int hardRangeMax = 42; //Field offset: 0x0

	public static void ApplySmoothingGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, float angleThreshold) { }

	internal static void ApplySmoothingGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, float angleThreshold, Vector3[] normals) { }

	private static bool FindSoftEdgesRecursive(Vector3[] normals, WingedEdge wing, float angleThreshold, HashSet<Face> processed) { }

	private static int GetNextUnusedSmoothingGroup(int start, HashSet<Int32> used) { }

	public static int GetUnusedSmoothingGroup(ProBuilderMesh mesh) { }

	public static bool IsSmooth(int index) { }

	private static bool IsSoftEdge(Vector3[] normals, EdgeLookup left, EdgeLookup right, float threshold) { }

}

