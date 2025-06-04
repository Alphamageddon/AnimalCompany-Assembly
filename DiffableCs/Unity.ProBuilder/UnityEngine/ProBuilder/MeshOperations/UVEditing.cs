namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
internal static class UVEditing
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector4, Vector2> <>9__2_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<Int32, Int32>, Int32> <>9__4_1; //Field offset: 0x10
		public static Func<Face, IEnumerable`1<Int32>> <>9__8_0; //Field offset: 0x18
		public static Func<Face, IEnumerable`1<Int32>> <>9__8_1; //Field offset: 0x20
		public static Func<Face, IEnumerable`1<Int32>> <>9__9_0; //Field offset: 0x28
		public static Func<Face, IEnumerable`1<Int32>> <>9__11_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal Vector2 <GetUVs>b__2_0(Vector4 x) { }

		internal IEnumerable<Int32> <ProjectFacesAuto>b__8_0(Face x) { }

		internal IEnumerable<Int32> <ProjectFacesAuto>b__8_1(Face x) { }

		internal IEnumerable<Int32> <ProjectFacesBox>b__11_0(Face x) { }

		internal IEnumerable<Int32> <ProjectFacesBox>b__9_0(Face x) { }

		internal int <SewUVs>b__4_1(KeyValuePair<Int32, Int32> y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Face f1; //Field offset: 0x10
		public Face f2; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal bool <AutoStitch>b__0(WingedEdge x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public int b; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <SewUVs>b__0(KeyValuePair<Int32, Int32> x) { }

	}


	private static bool AlignEdges(ProBuilderMesh mesh, Face faceToMove, Edge edgeToAlignTo, Edge edgeToBeAligned, int channel) { }

	internal static void ApplyUVs(ProBuilderMesh mesh, Vector2[] uvs, int channel, bool applyToMesh = true) { }

	public static bool AutoStitch(ProBuilderMesh mesh, Face f1, Face f2, int channel) { }

	[Extension]
	public static void CollapseUVs(ProBuilderMesh mesh, Int32[] indexes) { }

	internal static Vector2 FindMinimalUV(Vector2[] uvs, Int32[] indices = null, float xMin = 0, float yMin = 0) { }

	public static Vector2[] FitUVs(Vector2[] uvs) { }

	internal static Vector2[] GetUVs(ProBuilderMesh mesh, int channel) { }

	internal static void ProjectFacesAuto(ProBuilderMesh mesh, Face[] faces, int channel) { }

	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, int channel = 0) { }

	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, Vector2 lowerLeftAnchor, int channel = 0) { }

	public static void ProjectFacesSphere(ProBuilderMesh pb, Int32[] indexes, int channel = 0) { }

	[Extension]
	public static void SewUVs(ProBuilderMesh mesh, Int32[] indexes, float delta) { }

	[Extension]
	public static void SplitUVs(ProBuilderMesh mesh, IEnumerable<Int32> indexes) { }

	internal static void SplitUVs(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

}

