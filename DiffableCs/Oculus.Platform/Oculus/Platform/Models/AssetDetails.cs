namespace Oculus.Platform.Models;

public class AssetDetails
{
	public readonly ulong AssetId; //Field offset: 0x10
	public readonly string AssetType; //Field offset: 0x18
	public readonly string DownloadStatus; //Field offset: 0x20
	public readonly string Filepath; //Field offset: 0x28
	public readonly string IapStatus; //Field offset: 0x30
	public readonly LanguagePackInfo LanguageOptional; //Field offset: 0x38
	[Obsolete("Deprecated in favor of LanguageOptional")]
	public readonly LanguagePackInfo Language; //Field offset: 0x40
	public readonly string Metadata; //Field offset: 0x48

	public AssetDetails(IntPtr o) { }

}

