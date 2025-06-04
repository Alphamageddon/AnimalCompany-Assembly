namespace Fusion.Statistics;

public class NetworkObjectStatisticsSnapshot
{
	[CompilerGenerated]
	private int <InPackets>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <OutPackets>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private float <InBandwidth>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <OutBandwidth>k__BackingField; //Field offset: 0x1C

	public private float InBandwidth
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int InPackets
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private float OutBandwidth
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int OutPackets
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public NetworkObjectStatisticsSnapshot() { }

	[Conditional("DEBUG")]
	internal void AddToInBandwidthStat(float value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void AddToInPacketsStat(int value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void AddToOutBandwidthStat(float value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void AddToOutPacketsStat(int value, bool overrideValue = false) { }

	[CompilerGenerated]
	public float get_InBandwidth() { }

	[CompilerGenerated]
	public int get_InPackets() { }

	[CompilerGenerated]
	public float get_OutBandwidth() { }

	[CompilerGenerated]
	public int get_OutPackets() { }

	internal void Reset() { }

	[CompilerGenerated]
	private void set_InBandwidth(float value) { }

	[CompilerGenerated]
	private void set_InPackets(int value) { }

	[CompilerGenerated]
	private void set_OutBandwidth(float value) { }

	[CompilerGenerated]
	private void set_OutPackets(int value) { }

}

