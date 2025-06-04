namespace Oculus.Platform;

public class MessageWithAppDownloadProgressResult : Message<AppDownloadProgressResult>
{

	public MessageWithAppDownloadProgressResult(IntPtr c_message) { }

	public virtual AppDownloadProgressResult GetAppDownloadProgressResult() { }

	protected virtual AppDownloadProgressResult GetDataFromMessage(IntPtr c_message) { }

}

