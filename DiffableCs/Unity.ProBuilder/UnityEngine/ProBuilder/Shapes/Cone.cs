namespace UnityEngine.ProBuilder.Shapes;

[Shape("Cone")]
public class Cone : Shape
{
	[Range(3, 64)]
	[SerializeField]
	internal int m_NumberOfSides; //Field offset: 0x10
	private float m_Radius; //Field offset: 0x14
	[SerializeField]
	private bool m_Smooth; //Field offset: 0x18

	public Cone() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

}

