namespace UnityEngine.ProBuilder;

internal sealed class FaceRebuildData
{
	public Face face; //Field offset: 0x10
	public List<Vertex> vertices; //Field offset: 0x18
	public List<Int32> sharedIndexes; //Field offset: 0x20
	public List<Int32> sharedIndexesUV; //Field offset: 0x28
	private int _appliedOffset; //Field offset: 0x30

	public FaceRebuildData() { }

	public static void Apply(IEnumerable<FaceRebuildData> newFaces, ProBuilderMesh mesh, List<Vertex> vertices = null, List<Face> faces = null) { }

	public static void Apply(IEnumerable<FaceRebuildData> newFaces, List<Vertex> vertices, List<Face> faces, Dictionary<Int32, Int32> sharedVertexLookup, Dictionary<Int32, Int32> sharedTextureLookup = null) { }

	public int Offset() { }

	public virtual string ToString() { }

}

