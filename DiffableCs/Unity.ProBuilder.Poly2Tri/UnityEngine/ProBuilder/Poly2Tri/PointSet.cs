namespace UnityEngine.ProBuilder.Poly2Tri;

internal class PointSet : Triangulatable
{
	[CompilerGenerated]
	private IList<TriangulationPoint> <Points>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IList<DelaunayTriangle> <Triangles>k__BackingField; //Field offset: 0x18

	public private override IList<TriangulationPoint> Points
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override IList<DelaunayTriangle> Triangles
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override TriangulationMode TriangulationMode
	{
		 get { } //Length: 8
	}

	public PointSet(List<TriangulationPoint> points) { }

	public override void AddTriangle(DelaunayTriangle t) { }

	public override void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	public override void ClearTriangles() { }

	[CompilerGenerated]
	public override IList<TriangulationPoint> get_Points() { }

	[CompilerGenerated]
	public override IList<DelaunayTriangle> get_Triangles() { }

	public override TriangulationMode get_TriangulationMode() { }

	public override void Prepare(TriangulationContext tcx) { }

	[CompilerGenerated]
	private void set_Points(IList<TriangulationPoint> value) { }

	[CompilerGenerated]
	private void set_Triangles(IList<DelaunayTriangle> value) { }

}

