namespace UnityEngine.ProBuilder;

public sealed class Submesh
{
	[SerializeField]
	internal Int32[] m_Indexes; //Field offset: 0x10
	[SerializeField]
	internal MeshTopology m_Topology; //Field offset: 0x18
	[SerializeField]
	internal int m_SubmeshIndex; //Field offset: 0x1C

	public IEnumerable<Int32> indexes
	{
		 get { } //Length: 124
		 set { } //Length: 92
	}

	public int submeshIndex
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public MeshTopology topology
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Submesh(int submeshIndex, MeshTopology topology, IEnumerable<Int32> indexes) { }

	public Submesh(Mesh mesh, int subMeshIndex) { }

	public IEnumerable<Int32> get_indexes() { }

	public int get_submeshIndex() { }

	public MeshTopology get_topology() { }

	internal static int GetSubmeshCount(ProBuilderMesh mesh) { }

	public static Submesh[] GetSubmeshes(IEnumerable<Face> faces, int submeshCount, MeshTopology preferredTopology = 0) { }

	internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh) { }

	public void set_indexes(IEnumerable<Int32> value) { }

	public void set_submeshIndex(int value) { }

	public void set_topology(MeshTopology value) { }

	public virtual string ToString() { }

}

