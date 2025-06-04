namespace Oculus.Platform.Models;

public class Leaderboard
{
	public readonly string ApiName; //Field offset: 0x10
	public readonly Destination DestinationOptional; //Field offset: 0x18
	[Obsolete("Deprecated in favor of DestinationOptional")]
	public readonly Destination Destination; //Field offset: 0x20
	public readonly ulong ID; //Field offset: 0x28

	public Leaderboard(IntPtr o) { }

}

