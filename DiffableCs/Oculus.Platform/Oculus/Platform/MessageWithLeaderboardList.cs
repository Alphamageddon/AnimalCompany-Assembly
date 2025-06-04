namespace Oculus.Platform;

public class MessageWithLeaderboardList : Message<LeaderboardList>
{

	public MessageWithLeaderboardList(IntPtr c_message) { }

	protected virtual LeaderboardList GetDataFromMessage(IntPtr c_message) { }

	public virtual LeaderboardList GetLeaderboardList() { }

}

