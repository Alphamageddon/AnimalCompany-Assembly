namespace Oculus.Platform;

public class MessageWithLivestreamingApplicationStatus : Message<LivestreamingApplicationStatus>
{

	public MessageWithLivestreamingApplicationStatus(IntPtr c_message) { }

	protected virtual LivestreamingApplicationStatus GetDataFromMessage(IntPtr c_message) { }

	public virtual LivestreamingApplicationStatus GetLivestreamingApplicationStatus() { }

}

