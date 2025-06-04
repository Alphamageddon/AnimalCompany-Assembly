namespace Oculus.Platform;

public class AbuseReportOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public AbuseReportOptions() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(AbuseReportOptions options) { }

	public void SetPreventPeopleChooser(bool value) { }

	public void SetReportType(AbuseReportType value) { }

}

