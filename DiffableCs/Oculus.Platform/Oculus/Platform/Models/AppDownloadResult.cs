namespace Oculus.Platform.Models;

public class AppDownloadResult
{
	public readonly AppInstallResult AppInstallResult; //Field offset: 0x10
	public readonly long Timestamp; //Field offset: 0x18

	public AppDownloadResult(IntPtr o) { }

}

