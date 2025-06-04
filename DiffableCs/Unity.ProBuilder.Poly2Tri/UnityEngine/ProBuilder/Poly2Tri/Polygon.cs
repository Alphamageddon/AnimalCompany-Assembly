namespace UnityEngine.ProBuilder.Poly2Tri;

internal class Polygon : Triangulatable
{
	protected List<TriangulationPoint> _points; //Field offset: 0x10
	protected List<TriangulationPoint> _steinerPoints; //Field offset: 0x18
	protected List<Polygon> _holes; //Field offset: 0x20
	protected List<DelaunayTriangle> _triangles; //Field offset: 0x28
	protected PolygonPoint _last; //Field offset: 0x30

	public IList<Polygon> Holes
	{
		 get { } //Length: 8
	}

	public override IList<TriangulationPoint> Points
	{
		 get { } //Length: 8
	}

	public override IList<DelaunayTriangle> Triangles
	{
		 get { } //Length: 8
	}

	public override TriangulationMode TriangulationMode
	{
		 get { } //Length: 8
	}

	public Polygon(IList<PolygonPoint> points) { }

	public Polygon(IEnumerable<PolygonPoint> points) { }

	public Polygon(PolygonPoint[] points) { }

	public void AddHole(Polygon poly) { }

	public void AddPoint(PolygonPoint p) { }

	public void AddPoints(IEnumerable<PolygonPoint> list) { }

	public void AddSteinerPoint(TriangulationPoint point) { }

	public void AddSteinerPoints(List<TriangulationPoint> points) { }

	public override void AddTriangle(DelaunayTriangle t) { }

	public override void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	public void ClearSteinerPoints() { }

	public override void ClearTriangles() { }

	public IList<Polygon> get_Holes() { }

	public override IList<TriangulationPoint> get_Points() { }

	public override IList<DelaunayTriangle> get_Triangles() { }

	public override TriangulationMode get_TriangulationMode() { }

	public void InsertPointAfter(PolygonPoint point, PolygonPoint newPoint) { }

	public override void Prepare(TriangulationContext tcx) { }

	public void RemovePoint(PolygonPoint p) { }

}

