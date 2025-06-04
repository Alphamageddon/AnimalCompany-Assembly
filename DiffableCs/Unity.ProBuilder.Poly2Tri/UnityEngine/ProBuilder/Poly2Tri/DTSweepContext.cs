namespace UnityEngine.ProBuilder.Poly2Tri;

internal class DTSweepContext : TriangulationContext
{
	private readonly float ALPHA; //Field offset: 0x40
	public AdvancingFront Front; //Field offset: 0x48
	[CompilerGenerated]
	private TriangulationPoint <Head>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private TriangulationPoint <Tail>k__BackingField; //Field offset: 0x58
	public DTSweepBasin Basin; //Field offset: 0x60
	public DTSweepEdgeEvent EdgeEvent; //Field offset: 0x68
	private DTSweepPointComparator _comparator; //Field offset: 0x70

	public virtual TriangulationAlgorithm Algorithm
	{
		 get { } //Length: 8
	}

	public TriangulationPoint Head
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public virtual bool IsDebugEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 116
	}

	public TriangulationPoint Tail
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public DTSweepContext() { }

	public void AddNode(AdvancingFrontNode node) { }

	public virtual void Clear() { }

	public void CreateAdvancingFront() { }

	public void FinalizeTriangulation() { }

	public virtual TriangulationAlgorithm get_Algorithm() { }

	[CompilerGenerated]
	public TriangulationPoint get_Head() { }

	public virtual bool get_IsDebugEnabled() { }

	[CompilerGenerated]
	public TriangulationPoint get_Tail() { }

	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	public void MapTriangleToNodes(DelaunayTriangle t) { }

	public void MeshClean(DelaunayTriangle triangle) { }

	private void MeshCleanReq(DelaunayTriangle triangle) { }

	public virtual TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	public virtual void PrepareTriangulation(Triangulatable t) { }

	public void RemoveFromList(DelaunayTriangle triangle) { }

	public void RemoveNode(AdvancingFrontNode node) { }

	[CompilerGenerated]
	public void set_Head(TriangulationPoint value) { }

	protected virtual void set_IsDebugEnabled(bool value) { }

	[CompilerGenerated]
	public void set_Tail(TriangulationPoint value) { }

}

