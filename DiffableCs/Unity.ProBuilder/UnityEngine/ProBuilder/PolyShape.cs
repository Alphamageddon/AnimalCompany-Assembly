namespace UnityEngine.ProBuilder;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[ProGridsConditionalSnap]
public sealed class PolyShape : MonoBehaviour
{
	public enum PolyEditMode
	{
		None = 0,
		Path = 1,
		Height = 2,
		Edit = 3,
	}

	private ProBuilderMesh m_Mesh; //Field offset: 0x20
	[FormerlySerializedAs("points")]
	[SerializeField]
	internal List<Vector3> m_Points; //Field offset: 0x28
	[FormerlySerializedAs("extrude")]
	[SerializeField]
	private float m_Extrude; //Field offset: 0x30
	[FormerlySerializedAs("polyEditMode")]
	[SerializeField]
	private PolyEditMode m_EditMode; //Field offset: 0x34
	[FormerlySerializedAs("flipNormals")]
	[SerializeField]
	private bool m_FlipNormals; //Field offset: 0x38
	[SerializeField]
	internal bool isOnGrid; //Field offset: 0x39

	public ReadOnlyCollection<Vector3> controlPoints
	{
		 get { } //Length: 124
	}

	public float extrude
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool flipNormals
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	internal ProBuilderMesh mesh
	{
		internal get { } //Length: 148
		internal set { } //Length: 8
	}

	internal PolyEditMode polyEditMode
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public PolyShape() { }

	public ReadOnlyCollection<Vector3> get_controlPoints() { }

	public float get_extrude() { }

	public bool get_flipNormals() { }

	internal ProBuilderMesh get_mesh() { }

	internal PolyEditMode get_polyEditMode() { }

	private bool IsSnapEnabled() { }

	public void set_extrude(float value) { }

	public void set_flipNormals(bool value) { }

	internal void set_mesh(ProBuilderMesh value) { }

	internal void set_polyEditMode(PolyEditMode value) { }

	public void SetControlPoints(IList<Vector3> points) { }

}

