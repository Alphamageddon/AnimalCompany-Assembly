namespace Oculus.Platform;

public class MessageWithChallengeList : Message<ChallengeList>
{

	public MessageWithChallengeList(IntPtr c_message) { }

	public virtual ChallengeList GetChallengeList() { }

	protected virtual ChallengeList GetDataFromMessage(IntPtr c_message) { }

}

