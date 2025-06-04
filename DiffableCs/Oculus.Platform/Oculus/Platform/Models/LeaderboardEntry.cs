namespace Oculus.Platform.Models;

public class LeaderboardEntry
{
	public readonly string DisplayScore; //Field offset: 0x10
	public readonly Byte[] ExtraData; //Field offset: 0x18
	public readonly ulong ID; //Field offset: 0x20
	public readonly int Rank; //Field offset: 0x28
	public readonly long Score; //Field offset: 0x30
	public readonly SupplementaryMetric SupplementaryMetricOptional; //Field offset: 0x38
	[Obsolete("Deprecated in favor of SupplementaryMetricOptional")]
	public readonly SupplementaryMetric SupplementaryMetric; //Field offset: 0x40
	public readonly DateTime Timestamp; //Field offset: 0x48
	public readonly User User; //Field offset: 0x50

	public LeaderboardEntry(IntPtr o) { }

}

