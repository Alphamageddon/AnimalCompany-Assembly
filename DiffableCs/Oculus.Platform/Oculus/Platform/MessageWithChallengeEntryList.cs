namespace Oculus.Platform;

public class MessageWithChallengeEntryList : Message<ChallengeEntryList>
{

	public MessageWithChallengeEntryList(IntPtr c_message) { }

	public virtual ChallengeEntryList GetChallengeEntryList() { }

	protected virtual ChallengeEntryList GetDataFromMessage(IntPtr c_message) { }

}

