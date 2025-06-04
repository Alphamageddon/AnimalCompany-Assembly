namespace Oculus.Platform;

public class MessageWithLivestreamingVideoStats : Message<LivestreamingVideoStats>
{

	public MessageWithLivestreamingVideoStats(IntPtr c_message) { }

	protected virtual LivestreamingVideoStats GetDataFromMessage(IntPtr c_message) { }

	public virtual LivestreamingVideoStats GetLivestreamingVideoStats() { }

}

