namespace UnityEngine.ProBuilder.Shapes;

[Shape("Sphere")]
public class Sphere : Shape
{
	private static readonly Vector3[] k_IcosphereVertices; //Field offset: 0x0
	private static readonly Int32[] k_IcosphereTriangles; //Field offset: 0x8
	[Range(1, 5)]
	[SerializeField]
	private int m_Subdivisions; //Field offset: 0x10
	private int m_BottomMostVertexIndex; //Field offset: 0x14
	[SerializeField]
	private bool m_Smooth; //Field offset: 0x18

	private static Sphere() { }

	public Sphere() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

}

