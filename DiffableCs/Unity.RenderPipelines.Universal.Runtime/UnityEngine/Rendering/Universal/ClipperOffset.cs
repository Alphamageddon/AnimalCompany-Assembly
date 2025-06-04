namespace UnityEngine.Rendering.Universal;

internal class ClipperOffset
{
	private const double two_pi = 6.283185307179586; //Field offset: 0x0
	private const double def_arc_tolerance = 0.25; //Field offset: 0x0
	private List<List`1<IntPoint>> m_destPolys; //Field offset: 0x10
	private List<IntPoint> m_srcPoly; //Field offset: 0x18
	private List<IntPoint> m_destPoly; //Field offset: 0x20
	private List<DoublePoint> m_normals; //Field offset: 0x28
	private double m_delta; //Field offset: 0x30
	private double m_sinA; //Field offset: 0x38
	private double m_sin; //Field offset: 0x40
	private double m_cos; //Field offset: 0x48
	private double m_StepsPerRad; //Field offset: 0x50
	private IntPoint m_lowest; //Field offset: 0x58
	private PolyNode m_polyNodes; //Field offset: 0x88
	[CompilerGenerated]
	private double <ArcTolerance>k__BackingField; //Field offset: 0x90

	public double ArcTolerance
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ClipperOffset(double arcTolerance = 0.25) { }

	public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType) { }

	public void AddPaths(List<List`1<IntPoint>> paths, JoinType joinType, EndType endType) { }

	public void Clear() { }

	internal void DoMiter(int j, int k, double r) { }

	private void DoOffset(double delta) { }

	internal void DoRound(int j, int k) { }

	internal void DoSquare(int j, int k) { }

	public void Execute(ref List<List`1<IntPoint>>& solution, double delta, int inputSize) { }

	public void Execute(ref PolyTree solution, double delta) { }

	private void FixOrientations() { }

	[CompilerGenerated]
	public double get_ArcTolerance() { }

	internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2) { }

	private void OffsetPoint(int j, ref int k, JoinType jointype) { }

	internal static long Round(double value) { }

	[CompilerGenerated]
	public void set_ArcTolerance(double value) { }

}

