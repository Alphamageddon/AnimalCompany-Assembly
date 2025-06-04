namespace Oculus.Platform.Models;

public class LeaderboardEntryList : DeserializableList<LeaderboardEntry>
{
	public readonly ulong TotalCount; //Field offset: 0x28

	public LeaderboardEntryList(IntPtr a) { }

}

