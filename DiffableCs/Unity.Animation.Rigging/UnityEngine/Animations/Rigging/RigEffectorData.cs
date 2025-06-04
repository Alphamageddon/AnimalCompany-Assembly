namespace UnityEngine.Animations.Rigging;

public class RigEffectorData
{
	internal struct Style
	{
		public Mesh shape; //Field offset: 0x0
		public Color color; //Field offset: 0x8
		public float size; //Field offset: 0x18
		public Vector3 position; //Field offset: 0x1C
		public Vector3 rotation; //Field offset: 0x28

	}

	[SerializeField]
	private Transform m_Transform; //Field offset: 0x10
	[SerializeField]
	private Style m_Style; //Field offset: 0x18
	[SerializeField]
	private bool m_Visible; //Field offset: 0x50

	public Style style
	{
		 get { } //Length: 32
	}

	public Transform transform
	{
		 get { } //Length: 8
	}

	public bool visible
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public RigEffectorData() { }

	public Style get_style() { }

	public Transform get_transform() { }

	public bool get_visible() { }

	public void Initialize(Transform transform, Style style) { }

	public void set_visible(bool value) { }

}

