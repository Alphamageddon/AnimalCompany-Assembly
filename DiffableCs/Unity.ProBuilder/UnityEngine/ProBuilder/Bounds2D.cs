namespace UnityEngine.ProBuilder;

internal sealed class Bounds2D
{
	public Vector2 center; //Field offset: 0x10
	[SerializeField]
	private Vector2 m_Size; //Field offset: 0x18
	[SerializeField]
	private Vector2 m_Extents; //Field offset: 0x20

	public Vector2[] corners
	{
		 get { } //Length: 200
	}

	public Vector2 extents
	{
		 get { } //Length: 8
	}

	public Vector2 size
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public Bounds2D() { }

	public Bounds2D(Vector2 center, Vector2 size) { }

	public Bounds2D(IList<Vector2> points) { }

	public Bounds2D(IList<Vector2> points, IList<Int32> indexes) { }

	internal Bounds2D(Vector3[] points, Edge[] edges) { }

	public Bounds2D(Vector2[] points, int length) { }

	public static Vector2 Center(IList<Vector2> points, IList<Int32> indexes) { }

	internal static Vector2 Center(IList<Vector4> points, IEnumerable<Int32> indexes) { }

	public static Vector2 Center(IList<Vector2> points) { }

	public bool ContainsPoint(Vector2 point) { }

	public Vector2[] get_corners() { }

	public Vector2 get_extents() { }

	public Vector2 get_size() { }

	public bool Intersects(Rect rect) { }

	public bool Intersects(Bounds2D bounds) { }

	public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd) { }

	public void set_size(Vector2 value) { }

	public void SetWithPoints(IList<Vector2> points) { }

	public void SetWithPoints(IList<Vector2> points, IList<Int32> indexes) { }

	public static Vector2 Size(IList<Vector2> points, IList<Int32> indexes) { }

	public virtual string ToString() { }

}

