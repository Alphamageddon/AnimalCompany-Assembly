namespace UnityEngine.ProBuilder.Shapes;

[Shape("Torus")]
public class Torus : Shape
{
	[Range(3, 64)]
	[SerializeField]
	private int m_Rows; //Field offset: 0x10
	[Range(3, 64)]
	[SerializeField]
	private int m_Columns; //Field offset: 0x14
	[Min(0.01)]
	[SerializeField]
	private float m_TubeRadius; //Field offset: 0x18
	[Range(0, 360)]
	[SerializeField]
	private float m_HorizontalCircumference; //Field offset: 0x1C
	[Range(0, 360)]
	[SerializeField]
	private float m_VerticalCircumference; //Field offset: 0x20
	[SerializeField]
	private bool m_Smooth; //Field offset: 0x24

	public Torus() { }

	public virtual void CopyShape(Shape shape) { }

	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, Vector3 offset) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

}

