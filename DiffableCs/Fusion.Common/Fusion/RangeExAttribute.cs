namespace Fusion;

[AttributeUsage(384)]
public class RangeExAttribute : DrawerPropertyAttribute
{
	[CompilerGenerated]
	private readonly double <Max>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly double <Min>k__BackingField; //Field offset: 0x20
	public bool ClampMin; //Field offset: 0x28
	public bool ClampMax; //Field offset: 0x29
	public bool UseSlider; //Field offset: 0x2A

	public double Max
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public double Min
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public RangeExAttribute(double min, double max) { }

	[CompilerGenerated]
	public double get_Max() { }

	[CompilerGenerated]
	public double get_Min() { }

}

