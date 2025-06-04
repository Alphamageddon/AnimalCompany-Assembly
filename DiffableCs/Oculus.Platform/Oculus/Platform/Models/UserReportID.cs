namespace Oculus.Platform.Models;

public class UserReportID
{
	public readonly bool DidCancel; //Field offset: 0x10
	public readonly ulong ID; //Field offset: 0x18

	public UserReportID(IntPtr o) { }

}

