namespace Oculus.Platform;

public class MessageWithLivestreamingStatus : Message<LivestreamingStatus>
{

	public MessageWithLivestreamingStatus(IntPtr c_message) { }

	protected virtual LivestreamingStatus GetDataFromMessage(IntPtr c_message) { }

	public virtual LivestreamingStatus GetLivestreamingStatus() { }

}

