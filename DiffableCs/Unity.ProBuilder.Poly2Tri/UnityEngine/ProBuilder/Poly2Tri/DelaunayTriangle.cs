namespace UnityEngine.ProBuilder.Poly2Tri;

internal class DelaunayTriangle
{
	public FixedArray3<TriangulationPoint> Points; //Field offset: 0x10
	public FixedArray3<DelaunayTriangle> Neighbors; //Field offset: 0x28
	public FixedBitArray3 EdgeIsConstrained; //Field offset: 0x40
	public FixedBitArray3 EdgeIsDelaunay; //Field offset: 0x43
	[CompilerGenerated]
	private bool <IsInterior>k__BackingField; //Field offset: 0x46

	public bool IsInterior
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public DelaunayTriangle(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	public double Area() { }

	public TriangulationPoint Centroid() { }

	public bool Contains(TriangulationPoint p) { }

	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	[CompilerGenerated]
	public bool get_IsInterior() { }

	public bool GetConstrainedEdgeAcross(TriangulationPoint p) { }

	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	public bool GetDelaunayEdgeAcross(TriangulationPoint p) { }

	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	public int IndexCCWFrom(TriangulationPoint p) { }

	public int IndexCWFrom(TriangulationPoint p) { }

	public int IndexOf(TriangulationPoint p) { }

	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	public void MarkConstrainedEdge(int index) { }

	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	public void MarkConstrainedEdge(DTSweepConstraint edge) { }

	public void MarkEdge(List<DelaunayTriangle> tList) { }

	public void MarkEdge(DelaunayTriangle triangle) { }

	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	public void MarkNeighbor(DelaunayTriangle t) { }

	public void MarkNeighborEdges() { }

	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	private void RotateCW() { }

	[CompilerGenerated]
	public void set_IsInterior(bool value) { }

	public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce) { }

	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce) { }

	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce) { }

	public virtual string ToString() { }

}

