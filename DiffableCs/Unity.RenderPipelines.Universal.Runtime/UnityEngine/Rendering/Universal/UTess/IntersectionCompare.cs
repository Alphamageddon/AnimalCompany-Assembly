namespace UnityEngine.Rendering.Universal.UTess;

internal struct IntersectionCompare : IComparer<int2>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <xvasort>e__FixedBuffer
	{
		public double FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <xvbsort>e__FixedBuffer
	{
		public double FixedElementField; //Field offset: 0x0

	}

	public NativeArray<double2> points; //Field offset: 0x0
	public NativeArray<int2> edges; //Field offset: 0x10
	[FixedBuffer(typeof(double, 4)]
	public <xvasort>e__FixedBuffer xvasort; //Field offset: 0x20
	[FixedBuffer(typeof(double, 4)]
	public <xvbsort>e__FixedBuffer xvbsort; //Field offset: 0x40

	public override int Compare(int2 a, int2 b) { }

}

