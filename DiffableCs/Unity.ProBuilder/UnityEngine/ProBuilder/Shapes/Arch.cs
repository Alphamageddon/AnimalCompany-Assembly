namespace UnityEngine.ProBuilder.Shapes;

[Shape("Arch")]
public class Arch : Shape
{
	[Min(0.01)]
	[SerializeField]
	private float m_Thickness; //Field offset: 0x10
	[Range(2, 200)]
	[SerializeField]
	private int m_NumberOfSides; //Field offset: 0x14
	[Range(1, 360)]
	[SerializeField]
	private float m_ArchDegrees; //Field offset: 0x18
	[SerializeField]
	private bool m_EndCaps; //Field offset: 0x1C
	[SerializeField]
	private bool m_Smooth; //Field offset: 0x1D

	public Arch() { }

	public virtual void CopyShape(Shape shape) { }

	private Vector3[] GetFace(Vector2 vertex1, Vector2 vertex2, float depth) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

}

