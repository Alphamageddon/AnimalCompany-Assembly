namespace Oculus.Platform.Models;

public class AssetFileDownloadResult
{
	public readonly ulong AssetId; //Field offset: 0x10
	public readonly string Filepath; //Field offset: 0x18

	public AssetFileDownloadResult(IntPtr o) { }

}

