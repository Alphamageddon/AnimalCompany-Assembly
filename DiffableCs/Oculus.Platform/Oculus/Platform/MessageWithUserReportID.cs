namespace Oculus.Platform;

public class MessageWithUserReportID : Message<UserReportID>
{

	public MessageWithUserReportID(IntPtr c_message) { }

	protected virtual UserReportID GetDataFromMessage(IntPtr c_message) { }

	public virtual UserReportID GetUserReportID() { }

}

