namespace UnityEngine.ProBuilder.Shapes;

[Shape("Stairs")]
public class Stairs : Shape
{
	[SerializeField]
	private StepGenerationType m_StepGenerationType; //Field offset: 0x10
	[Min(0.01)]
	[SerializeField]
	private float m_StepsHeight; //Field offset: 0x14
	[Range(1, 256)]
	[SerializeField]
	private int m_StepsCount; //Field offset: 0x18
	[SerializeField]
	private bool m_HomogeneousSteps; //Field offset: 0x1C
	[Range(-360, 360)]
	[SerializeField]
	private float m_Circumference; //Field offset: 0x20
	[SerializeField]
	private bool m_Sides; //Field offset: 0x24
	[Min(0)]
	[SerializeField]
	private float m_InnerRadius; //Field offset: 0x28

	public bool sides
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Stairs() { }

	private Bounds BuildCurvedStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	private Bounds BuildStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	public virtual void CopyShape(Shape shape) { }

	public bool get_sides() { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	public void set_sides(bool value) { }

	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

}

