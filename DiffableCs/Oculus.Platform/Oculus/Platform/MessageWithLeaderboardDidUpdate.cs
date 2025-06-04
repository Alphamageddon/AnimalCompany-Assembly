namespace Oculus.Platform;

public class MessageWithLeaderboardDidUpdate : Message<Boolean>
{

	public MessageWithLeaderboardDidUpdate(IntPtr c_message) { }

	protected virtual bool GetDataFromMessage(IntPtr c_message) { }

	public virtual bool GetLeaderboardDidUpdate() { }

}

