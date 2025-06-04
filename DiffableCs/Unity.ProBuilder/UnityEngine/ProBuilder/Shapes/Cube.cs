namespace UnityEngine.ProBuilder.Shapes;

[Shape("Cube")]
public class Cube : Shape
{
	private static readonly Vector3[] k_CubeVertices; //Field offset: 0x0
	private static readonly Int32[] k_CubeTriangles; //Field offset: 0x8

	private static Cube() { }

	public Cube() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

}

