namespace Fusion;

public class TimeSyncConfiguration
{
	[InlineHelp]
	[RangeEx(1, 10)]
	[Unit(Units::Seconds (2))]
	public double SampleWindowSeconds; //Field offset: 0x10
	[InlineHelp]
	[RangeEx(0.10000000149011612, 25)]
	[Unit(Units::Percentage (8))]
	public double MaxLateInputs; //Field offset: 0x18
	[InlineHelp]
	[RangeEx(0.10000000149011612, 25)]
	[Unit(Units::Percentage (8))]
	public double MaxLateSnapshots; //Field offset: 0x20
	[InlineHelp]
	[RangeEx(0, 8)]
	[Unit(Units::Packets (19))]
	public int RedundantInputs; //Field offset: 0x28
	[InlineHelp]
	[RangeEx(0, 8)]
	[Unit(Units::Packets (19))]
	public int RedundantSnapshots; //Field offset: 0x2C

	private double MaxInterpSpeedAdjust
	{
		private get { } //Length: 8
	}

	internal double MaxInterpSpeedAdjustNormalized
	{
		internal get { } //Length: 108
	}

	internal double MaxLateInputsNormalized
	{
		internal get { } //Length: 128
	}

	internal double MaxLateSnapshotsNormalized
	{
		internal get { } //Length: 128
	}

	private double MaxSimSpeedAdjust
	{
		private get { } //Length: 8
	}

	internal double MaxSimSpeedAdjustNormalized
	{
		internal get { } //Length: 108
	}

	internal int RedundantInputsNormalized
	{
		internal get { } //Length: 100
	}

	internal int RedundantSnapshotsNormalized
	{
		internal get { } //Length: 100
	}

	internal double SampleWindowSecondsNormalized
	{
		internal get { } //Length: 108
	}

	public TimeSyncConfiguration() { }

	private double get_MaxInterpSpeedAdjust() { }

	internal double get_MaxInterpSpeedAdjustNormalized() { }

	internal double get_MaxLateInputsNormalized() { }

	internal double get_MaxLateSnapshotsNormalized() { }

	private double get_MaxSimSpeedAdjust() { }

	internal double get_MaxSimSpeedAdjustNormalized() { }

	internal int get_RedundantInputsNormalized() { }

	internal int get_RedundantSnapshotsNormalized() { }

	internal double get_SampleWindowSecondsNormalized() { }

	internal static TimeSyncConfiguration GetFromTickrate(Resolved tickrate) { }

}

