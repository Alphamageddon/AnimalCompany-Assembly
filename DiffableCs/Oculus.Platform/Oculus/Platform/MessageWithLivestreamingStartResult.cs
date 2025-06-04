namespace Oculus.Platform;

public class MessageWithLivestreamingStartResult : Message<LivestreamingStartResult>
{

	public MessageWithLivestreamingStartResult(IntPtr c_message) { }

	protected virtual LivestreamingStartResult GetDataFromMessage(IntPtr c_message) { }

	public virtual LivestreamingStartResult GetLivestreamingStartResult() { }

}

