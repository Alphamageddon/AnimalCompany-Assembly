namespace UnityEngine.ProBuilder;

public sealed class Vertex : IEquatable<Vertex>
{
	[SerializeField]
	private Vector3 m_Position; //Field offset: 0x10
	[SerializeField]
	private Color m_Color; //Field offset: 0x1C
	[SerializeField]
	private Vector3 m_Normal; //Field offset: 0x2C
	[SerializeField]
	private Vector4 m_Tangent; //Field offset: 0x38
	[SerializeField]
	private Vector2 m_UV0; //Field offset: 0x48
	[SerializeField]
	private Vector2 m_UV2; //Field offset: 0x50
	[SerializeField]
	private Vector4 m_UV3; //Field offset: 0x58
	[SerializeField]
	private Vector4 m_UV4; //Field offset: 0x68
	[SerializeField]
	private MeshArrays m_Attributes; //Field offset: 0x78

	internal MeshArrays attributes
	{
		internal get { } //Length: 8
	}

	public Color color
	{
		 get { } //Length: 12
		 set { } //Length: 40
	}

	private bool hasColor
	{
		private get { } //Length: 12
		private set { } //Length: 48
	}

	private bool hasNormal
	{
		private get { } //Length: 12
		private set { } //Length: 48
	}

	private bool hasPosition
	{
		private get { } //Length: 12
		private set { } //Length: 32
	}

	private bool hasTangent
	{
		private get { } //Length: 12
		private set { } //Length: 48
	}

	private bool hasUV0
	{
		private get { } //Length: 12
		private set { } //Length: 48
	}

	private bool hasUV2
	{
		private get { } //Length: 12
		private set { } //Length: 48
	}

	private bool hasUV3
	{
		private get { } //Length: 12
		private set { } //Length: 48
	}

	private bool hasUV4
	{
		private get { } //Length: 12
		private set { } //Length: 48
	}

	public Vector3 normal
	{
		 get { } //Length: 12
		 set { } //Length: 40
	}

	public Vector3 position
	{
		 get { } //Length: 12
		 set { } //Length: 40
	}

	public Vector4 tangent
	{
		 get { } //Length: 12
		 set { } //Length: 40
	}

	public Vector2 uv0
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public Vector2 uv2
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public Vector4 uv3
	{
		 get { } //Length: 12
		 set { } //Length: 40
	}

	public Vector4 uv4
	{
		 get { } //Length: 12
		 set { } //Length: 40
	}

	public Vertex(Vertex vertex) { }

	public Vertex() { }

	public void Add(Vertex b) { }

	public static Vertex Add(Vertex a, Vertex b) { }

	public static Vertex Average(IList<Vertex> vertices, IList<Int32> indexes = null) { }

	public void Divide(float value) { }

	public static Vertex Divide(Vertex a, float value) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(Vertex other, MeshArrays mask) { }

	public override bool Equals(Vertex other) { }

	internal MeshArrays get_attributes() { }

	public Color get_color() { }

	private bool get_hasColor() { }

	private bool get_hasNormal() { }

	private bool get_hasPosition() { }

	private bool get_hasTangent() { }

	private bool get_hasUV0() { }

	private bool get_hasUV2() { }

	private bool get_hasUV3() { }

	private bool get_hasUV4() { }

	public Vector3 get_normal() { }

	public Vector3 get_position() { }

	public Vector4 get_tangent() { }

	public Vector2 get_uv0() { }

	public Vector2 get_uv2() { }

	public Vector4 get_uv3() { }

	public Vector4 get_uv4() { }

	public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4>& uv3, out List<Vector4>& uv4, MeshArrays attributes) { }

	public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4>& uv3, out List<Vector4>& uv4) { }

	public virtual int GetHashCode() { }

	public bool HasArrays(MeshArrays attribute) { }

	public static Vertex Mix(Vertex x, Vertex y, float weight) { }

	public void Multiply(float value) { }

	public static Vertex Multiply(Vertex a, float value) { }

	public void Normalize() { }

	public static Vertex op_Addition(Vertex a, Vertex b) { }

	public static Vertex op_Division(Vertex a, float value) { }

	public static bool op_Equality(Vertex a, Vertex b) { }

	public static bool op_Inequality(Vertex a, Vertex b) { }

	public static Vertex op_Multiply(Vertex a, float value) { }

	public static Vertex op_Subtraction(Vertex a, Vertex b) { }

	public void set_color(Color value) { }

	private void set_hasColor(bool value) { }

	private void set_hasNormal(bool value) { }

	private void set_hasPosition(bool value) { }

	private void set_hasTangent(bool value) { }

	private void set_hasUV0(bool value) { }

	private void set_hasUV2(bool value) { }

	private void set_hasUV3(bool value) { }

	private void set_hasUV4(bool value) { }

	public void set_normal(Vector3 value) { }

	public void set_position(Vector3 value) { }

	public void set_tangent(Vector4 value) { }

	public void set_uv0(Vector2 value) { }

	public void set_uv2(Vector2 value) { }

	public void set_uv3(Vector4 value) { }

	public void set_uv4(Vector4 value) { }

	public static void SetMesh(Mesh mesh, IList<Vertex> vertices) { }

	public void Subtract(Vertex b) { }

	public static Vertex Subtract(Vertex a, Vertex b) { }

	public string ToString(string args = null) { }

}

