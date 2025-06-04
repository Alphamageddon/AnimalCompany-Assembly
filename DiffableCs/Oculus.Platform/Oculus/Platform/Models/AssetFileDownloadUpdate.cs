namespace Oculus.Platform.Models;

public class AssetFileDownloadUpdate
{
	public readonly ulong AssetFileId; //Field offset: 0x10
	public readonly ulong AssetId; //Field offset: 0x18
	public readonly ulong BytesTotal; //Field offset: 0x20
	public readonly long BytesTransferred; //Field offset: 0x28
	public readonly bool Completed; //Field offset: 0x30

	public AssetFileDownloadUpdate(IntPtr o) { }

}

