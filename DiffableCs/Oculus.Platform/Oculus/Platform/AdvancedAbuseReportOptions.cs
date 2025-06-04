namespace Oculus.Platform;

public class AdvancedAbuseReportOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public AdvancedAbuseReportOptions() { }

	public void AddSuggestedUser(ulong userID) { }

	public void ClearDeveloperDefinedContext() { }

	public void ClearSuggestedUsers() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(AdvancedAbuseReportOptions options) { }

	public void SetDeveloperDefinedContext(string key, string value) { }

	public void SetObjectType(string value) { }

	public void SetReportType(AbuseReportType value) { }

	public void SetVideoMode(AbuseReportVideoMode value) { }

}

