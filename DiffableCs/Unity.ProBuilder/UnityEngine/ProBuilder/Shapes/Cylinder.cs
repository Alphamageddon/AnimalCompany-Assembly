namespace UnityEngine.ProBuilder.Shapes;

[Shape("Cylinder")]
public class Cylinder : Shape
{
	[Range(3, 64)]
	[SerializeField]
	private int m_AxisDivisions; //Field offset: 0x10
	[Min(0)]
	[SerializeField]
	private int m_HeightCuts; //Field offset: 0x14
	[SerializeField]
	private bool m_Smooth; //Field offset: 0x18

	public Cylinder() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

}

