namespace UnityEngine.ProBuilder.Shapes;

[Shape("Plane")]
public class Plane : Shape
{
	[Min(0)]
	[SerializeField]
	private int m_HeightSegments; //Field offset: 0x10
	[Min(0)]
	[SerializeField]
	private int m_WidthSegments; //Field offset: 0x14

	public Plane() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

}

