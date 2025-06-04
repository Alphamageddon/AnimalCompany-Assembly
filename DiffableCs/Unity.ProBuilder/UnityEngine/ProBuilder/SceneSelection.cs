namespace UnityEngine.ProBuilder;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public class SceneSelection : IEquatable<SceneSelection>
{
	public GameObject gameObject; //Field offset: 0x10
	public ProBuilderMesh mesh; //Field offset: 0x18
	private List<Int32> m_Vertices; //Field offset: 0x20
	private List<Edge> m_Edges; //Field offset: 0x28
	private List<Face> m_Faces; //Field offset: 0x30
	[Obsolete("Use SetSingleVertex")]
	public int vertex; //Field offset: 0x38
	[Obsolete("Use SetSingleEdge")]
	public Edge edge; //Field offset: 0x3C
	[Obsolete("Use SetSingleFace")]
	public Face face; //Field offset: 0x48

	public List<Edge> edges
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<Face> faces
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<Int32> vertexes
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	internal SceneSelection(ProBuilderMesh mesh, List<Edge> edges) { }

	public SceneSelection(GameObject gameObject = null) { }

	public SceneSelection(ProBuilderMesh mesh, int vertex) { }

	public SceneSelection(ProBuilderMesh mesh, Edge edge) { }

	public SceneSelection(ProBuilderMesh mesh, Face face) { }

	internal SceneSelection(ProBuilderMesh mesh, List<Int32> vertexes) { }

	internal SceneSelection(ProBuilderMesh mesh, List<Face> faces) { }

	public void Clear() { }

	public void CopyTo(SceneSelection dst) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(SceneSelection other) { }

	public List<Edge> get_edges() { }

	public List<Face> get_faces() { }

	public List<Int32> get_vertexes() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SceneSelection left, SceneSelection right) { }

	public static bool op_Inequality(SceneSelection left, SceneSelection right) { }

	public void set_edges(List<Edge> value) { }

	public void set_faces(List<Face> value) { }

	public void set_vertexes(List<Int32> value) { }

	public void SetSingleEdge(Edge edge) { }

	public void SetSingleFace(Face face) { }

	public void SetSingleVertex(int vertex) { }

	public virtual string ToString() { }

}

