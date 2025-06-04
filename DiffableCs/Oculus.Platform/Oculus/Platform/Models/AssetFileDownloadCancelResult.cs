namespace Oculus.Platform.Models;

public class AssetFileDownloadCancelResult
{
	public readonly ulong AssetFileId; //Field offset: 0x10
	public readonly ulong AssetId; //Field offset: 0x18
	public readonly string Filepath; //Field offset: 0x20
	public readonly bool Success; //Field offset: 0x28

	public AssetFileDownloadCancelResult(IntPtr o) { }

}

