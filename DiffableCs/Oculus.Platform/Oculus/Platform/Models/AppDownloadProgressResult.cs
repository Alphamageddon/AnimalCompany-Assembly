namespace Oculus.Platform.Models;

public class AppDownloadProgressResult
{
	public readonly long DownloadBytes; //Field offset: 0x10
	public readonly long DownloadedBytes; //Field offset: 0x18
	public readonly AppStatus StatusCode; //Field offset: 0x20

	public AppDownloadProgressResult(IntPtr o) { }

}

