namespace Fusion.Statistics;

public class BehaviourStatisticsSnapshot
{
	[CompilerGenerated]
	private int <FixedUpdateNetworkExecutionCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <RenderExecutionCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private double <FixedUpdateNetworkExecutionTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private double <RenderExecutionTime>k__BackingField; //Field offset: 0x20

	public private int FixedUpdateNetworkExecutionCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private double FixedUpdateNetworkExecutionTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int RenderExecutionCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private double RenderExecutionTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public BehaviourStatisticsSnapshot() { }

	[Conditional("DEBUG")]
	internal void AccumulateFixedUpdateNetworkExecutionCount(int count) { }

	[Conditional("DEBUG")]
	internal void AccumulateFixedUpdateNetworkExecutionTime(double time) { }

	[Conditional("DEBUG")]
	internal void AccumulateRenderExecutionCount(int count) { }

	[Conditional("DEBUG")]
	internal void AccumulateRenderExecutionTime(double time) { }

	[Conditional("DEBUG")]
	internal void ClearSnapshot() { }

	[Conditional("DEBUG")]
	internal void CopyFromSnapshot(BehaviourStatisticsSnapshot snapshot) { }

	[CompilerGenerated]
	public int get_FixedUpdateNetworkExecutionCount() { }

	[CompilerGenerated]
	public double get_FixedUpdateNetworkExecutionTime() { }

	[CompilerGenerated]
	public int get_RenderExecutionCount() { }

	[CompilerGenerated]
	public double get_RenderExecutionTime() { }

	[CompilerGenerated]
	private void set_FixedUpdateNetworkExecutionCount(int value) { }

	[CompilerGenerated]
	private void set_FixedUpdateNetworkExecutionTime(double value) { }

	[CompilerGenerated]
	private void set_RenderExecutionCount(int value) { }

	[CompilerGenerated]
	private void set_RenderExecutionTime(double value) { }

}

