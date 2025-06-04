namespace UnityEngine.ProBuilder.Shapes;

[Shape("Pipe")]
public class Pipe : Shape
{
	[Min(0.01)]
	[SerializeField]
	private float m_Thickness; //Field offset: 0x10
	[Range(3, 64)]
	[SerializeField]
	private int m_NumberOfSides; //Field offset: 0x14
	[Range(0, 31)]
	[SerializeField]
	private int m_HeightCuts; //Field offset: 0x18
	[SerializeField]
	private bool m_Smooth; //Field offset: 0x1C

	public Pipe() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

}

