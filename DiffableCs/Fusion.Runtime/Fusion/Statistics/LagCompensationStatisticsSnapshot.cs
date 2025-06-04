namespace Fusion.Statistics;

public class LagCompensationStatisticsSnapshot
{
	[CompilerGenerated]
	private int <BVHMaxDeep>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <BVHNodesCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <HitboxesCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private double <AddOnBufferTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private double <AddOnBVHTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private double <UpdateBVHTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private double <UpdateBufferTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private double <AdvanceBufferTime>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private double <RefitBVHTime>k__BackingField; //Field offset: 0x48

	public private double AddOnBufferTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private double AddOnBVHTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private double AdvanceBufferTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int BVHMaxDeep
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int BVHNodesCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int HitboxesCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private double RefitBVHTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public double TotalElapsedTime
	{
		 get { } //Length: 40
	}

	public private double UpdateBufferTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private double UpdateBVHTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public LagCompensationStatisticsSnapshot() { }

	internal void ClearSnapshot() { }

	internal void CopyFromSnapshot(LagCompensationStatisticsSnapshot snapshot) { }

	[CompilerGenerated]
	public double get_AddOnBufferTime() { }

	[CompilerGenerated]
	public double get_AddOnBVHTime() { }

	[CompilerGenerated]
	public double get_AdvanceBufferTime() { }

	[CompilerGenerated]
	public int get_BVHMaxDeep() { }

	[CompilerGenerated]
	public int get_BVHNodesCount() { }

	[CompilerGenerated]
	public int get_HitboxesCount() { }

	[CompilerGenerated]
	public double get_RefitBVHTime() { }

	public double get_TotalElapsedTime() { }

	[CompilerGenerated]
	public double get_UpdateBufferTime() { }

	[CompilerGenerated]
	public double get_UpdateBVHTime() { }

	[CompilerGenerated]
	private void set_AddOnBufferTime(double value) { }

	[CompilerGenerated]
	private void set_AddOnBVHTime(double value) { }

	[CompilerGenerated]
	private void set_AdvanceBufferTime(double value) { }

	[CompilerGenerated]
	private void set_BVHMaxDeep(int value) { }

	[CompilerGenerated]
	private void set_BVHNodesCount(int value) { }

	[CompilerGenerated]
	private void set_HitboxesCount(int value) { }

	[CompilerGenerated]
	private void set_RefitBVHTime(double value) { }

	[CompilerGenerated]
	private void set_UpdateBufferTime(double value) { }

	[CompilerGenerated]
	private void set_UpdateBVHTime(double value) { }

	[Conditional("DEBUG")]
	internal void SetAddOnBufferTime(double value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void SetAddOnBVHTime(double value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void SetAdvanceBufferTime(double value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void SetBVHMaxDeep(int value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void SetBVHNodeCount(int value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void SetHitboxesCount(int value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void SetRefitBVHTime(double value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void SetUpdateBufferTime(double value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void SetUpdateBVHTime(double value, bool overrideValue = false) { }

}

