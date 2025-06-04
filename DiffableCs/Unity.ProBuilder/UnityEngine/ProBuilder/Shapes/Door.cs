namespace UnityEngine.ProBuilder.Shapes;

[Shape("Door")]
public class Door : Shape
{
	[Min(0.01)]
	[SerializeField]
	private float m_DoorHeight; //Field offset: 0x10
	[Min(0.01)]
	[SerializeField]
	private float m_LegWidth; //Field offset: 0x14

	public Door() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

}

