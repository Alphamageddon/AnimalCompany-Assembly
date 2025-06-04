namespace UnityEngine.ProBuilder.Poly2Tri;

internal static class DTSweep
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public TriangulationPoint ep; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <SplitEdge>b__0(DTSweepConstraint e) { }

	}

	private const double PI_div2 = 1.5707963267948966; //Field offset: 0x0
	private const double PI_3div4 = 2.356194490192345; //Field offset: 0x0

	private static double BasinAngle(AdvancingFrontNode node) { }

	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	private static void FinalizationPolygon(DTSweepContext tcx) { }

	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	private static double HoleAngle(AdvancingFrontNode node) { }

	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }

	private static void SplitEdge(TriangulationPoint ep, TriangulationPoint eq, TriangulationPoint p) { }

	private static void Sweep(DTSweepContext tcx) { }

	public static void Triangulate(DTSweepContext tcx) { }

	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

}

