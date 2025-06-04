namespace Fusion;

public class LagCompensationSettings
{
	[InlineHelp]
	public bool Enabled; //Field offset: 0x10
	[ErrorIf("HitboxBufferLengthInMs", 600, "Recommended value exceeded, unless a very high tick rate (100+) is intended.", CompareOperator::Greater (5))]
	[InlineHelp]
	[RangeEx(30, 800, ClampMax = False)]
	[Unit(Units::MilliSecs (3))]
	[WarnIf("HitboxBufferLengthInMs", 300, "Recommended value exceeded, unless a very high tick rate (100+) is intended.", CompareOperator::Greater (5))]
	public int HitboxBufferLengthInMs; //Field offset: 0x14
	[FormerlySerializedAs("HitboxCapacity")]
	[InlineHelp]
	[RangeEx(16, 1024, ClampMax = False, UseSlider = False)]
	[Unit(Units::Count (18))]
	public int HitboxDefaultCapacity; //Field offset: 0x18
	[InlineHelp]
	[Unit(Units::Count (18))]
	public int CachedStaticCollidersSize; //Field offset: 0x1C

	public float ExpansionFactor
	{
		 get { } //Length: 12
	}

	public bool Optimize
	{
		 get { } //Length: 8
	}

	public LagCompensationSettings() { }

	public float get_ExpansionFactor() { }

	public bool get_Optimize() { }

}

