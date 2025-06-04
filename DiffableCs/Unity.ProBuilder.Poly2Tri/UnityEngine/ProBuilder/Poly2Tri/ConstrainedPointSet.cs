namespace UnityEngine.ProBuilder.Poly2Tri;

internal class ConstrainedPointSet : PointSet
{
	[CompilerGenerated]
	private Int32[] <EdgeIndex>k__BackingField; //Field offset: 0x20

	public private Int32[] EdgeIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public virtual TriangulationMode TriangulationMode
	{
		 get { } //Length: 8
	}

	public ConstrainedPointSet(List<TriangulationPoint> points, Int32[] index) { }

	[CompilerGenerated]
	public Int32[] get_EdgeIndex() { }

	public virtual TriangulationMode get_TriangulationMode() { }

	public virtual void Prepare(TriangulationContext tcx) { }

	[CompilerGenerated]
	private void set_EdgeIndex(Int32[] value) { }

}

