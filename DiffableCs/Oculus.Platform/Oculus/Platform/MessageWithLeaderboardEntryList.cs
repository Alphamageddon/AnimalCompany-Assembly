namespace Oculus.Platform;

public class MessageWithLeaderboardEntryList : Message<LeaderboardEntryList>
{

	public MessageWithLeaderboardEntryList(IntPtr c_message) { }

	protected virtual LeaderboardEntryList GetDataFromMessage(IntPtr c_message) { }

	public virtual LeaderboardEntryList GetLeaderboardEntryList() { }

}

