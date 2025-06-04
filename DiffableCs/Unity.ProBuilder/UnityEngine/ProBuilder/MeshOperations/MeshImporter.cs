namespace UnityEngine.ProBuilder.MeshOperations;

public sealed class MeshImporter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vertex, Vector3> <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Vector3 <Import>b__9_0(Vertex x) { }

	}

	private static readonly MeshImportSettings k_DefaultImportSettings; //Field offset: 0x0
	private Mesh m_SourceMesh; //Field offset: 0x10
	private Material[] m_SourceMaterials; //Field offset: 0x18
	private ProBuilderMesh m_Destination; //Field offset: 0x20
	private Vertex[] m_Vertices; //Field offset: 0x28

	private static MeshImporter() { }

	public MeshImporter(GameObject gameObject) { }

	public MeshImporter(Mesh sourceMesh, Material[] sourceMaterials, ProBuilderMesh destination) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete]
	public MeshImporter(ProBuilderMesh destination) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete]
	public bool Import(GameObject go, MeshImportSettings importSettings = null) { }

	public void Import(MeshImportSettings importSettings = null) { }

}

