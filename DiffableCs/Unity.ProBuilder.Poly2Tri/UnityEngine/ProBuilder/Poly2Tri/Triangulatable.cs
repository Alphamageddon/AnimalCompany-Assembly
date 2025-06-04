namespace UnityEngine.ProBuilder.Poly2Tri;

internal interface Triangulatable
{

	public IList<TriangulationPoint> Points
	{
		 get { } //Length: 0
	}

	public IList<DelaunayTriangle> Triangles
	{
		 get { } //Length: 0
	}

	public TriangulationMode TriangulationMode
	{
		 get { } //Length: 0
	}

	public void AddTriangle(DelaunayTriangle t) { }

	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	public void ClearTriangles() { }

	public IList<TriangulationPoint> get_Points() { }

	public IList<DelaunayTriangle> get_Triangles() { }

	public TriangulationMode get_TriangulationMode() { }

	public void Prepare(TriangulationContext tcx) { }

}

