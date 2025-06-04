namespace Fusion.Addons.Physics;

public struct TRSThresholds
{
	[InlineHelp]
	public bool UseEnergy; //Field offset: 0x0
	[InlineHelp]
	[Unit(Units::Units (16))]
	public float Position; //Field offset: 0x4
	[InlineHelp]
	[Unit(Units::Degrees (10))]
	public float Rotation; //Field offset: 0x8
	[InlineHelp]
	[Unit(Units::NormalizedPercentage (9))]
	public float Scale; //Field offset: 0xC

	public static TRSThresholds Default
	{
		 get { } //Length: 32
	}

	public static TRSThresholds get_Default() { }

}

