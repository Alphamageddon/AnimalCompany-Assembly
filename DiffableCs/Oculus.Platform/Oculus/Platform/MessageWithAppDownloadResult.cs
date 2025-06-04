namespace Oculus.Platform;

public class MessageWithAppDownloadResult : Message<AppDownloadResult>
{

	public MessageWithAppDownloadResult(IntPtr c_message) { }

	public virtual AppDownloadResult GetAppDownloadResult() { }

	protected virtual AppDownloadResult GetDataFromMessage(IntPtr c_message) { }

}

