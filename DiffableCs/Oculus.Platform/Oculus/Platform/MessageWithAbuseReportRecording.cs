namespace Oculus.Platform;

public class MessageWithAbuseReportRecording : Message<AbuseReportRecording>
{

	public MessageWithAbuseReportRecording(IntPtr c_message) { }

	public virtual AbuseReportRecording GetAbuseReportRecording() { }

	protected virtual AbuseReportRecording GetDataFromMessage(IntPtr c_message) { }

}

