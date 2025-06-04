namespace UnityEngine.ProBuilder.Shapes;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
internal sealed class ProBuilderShape : MonoBehaviour
{
	[SerializeReference]
	private Shape m_Shape; //Field offset: 0x20
	[SerializeField]
	private Vector3 m_Size; //Field offset: 0x28
	[SerializeField]
	private Quaternion m_Rotation; //Field offset: 0x34
	private ProBuilderMesh m_Mesh; //Field offset: 0x48
	[SerializeField]
	private PivotLocation m_PivotLocation; //Field offset: 0x50
	[SerializeField]
	private Vector3 m_PivotPosition; //Field offset: 0x54
	[SerializeField]
	internal ushort m_UnmodifiedMeshVersion; //Field offset: 0x60
	private Bounds m_EditionBounds; //Field offset: 0x64
	[SerializeField]
	private Bounds m_ShapeBox; //Field offset: 0x7C

	public Bounds editionBounds
	{
		 get { } //Length: 188
	}

	public bool isEditable
	{
		 get { } //Length: 40
	}

	public ProBuilderMesh mesh
	{
		 get { } //Length: 248
	}

	public Vector3 pivotGlobalPosition
	{
		 get { } //Length: 52
		 set { } //Length: 96
	}

	public Vector3 pivotLocalPosition
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public PivotLocation pivotLocation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Quaternion rotation
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public Shape shape
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Bounds shapeBox
	{
		 get { } //Length: 20
	}

	public Vector3 size
	{
		 get { } //Length: 12
		 set { } //Length: 188
	}

	public ProBuilderShape() { }

	public Bounds get_editionBounds() { }

	public bool get_isEditable() { }

	public ProBuilderMesh get_mesh() { }

	public Vector3 get_pivotGlobalPosition() { }

	public Vector3 get_pivotLocalPosition() { }

	public PivotLocation get_pivotLocation() { }

	public Quaternion get_rotation() { }

	public Shape get_shape() { }

	public Bounds get_shapeBox() { }

	public Vector3 get_size() { }

	private void OnValidate() { }

	internal void Rebuild(Bounds bounds, Quaternion rotation, Vector3 cornerPivot) { }

	private void Rebuild() { }

	internal void RebuildPivot(Vector3 size, Quaternion rotation) { }

	private void ResetPivot(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	internal void RotateInsideBounds(Quaternion deltaRotation) { }

	public void set_pivotGlobalPosition(Vector3 value) { }

	public void set_pivotLocalPosition(Vector3 value) { }

	public void set_pivotLocation(PivotLocation value) { }

	public void set_rotation(Quaternion value) { }

	public void set_shape(Shape value) { }

	public void set_size(Vector3 value) { }

	internal void SetShape(Shape shape, PivotLocation location) { }

	internal void UpdateBounds(Bounds bounds) { }

	internal void UpdateComponent() { }

}

