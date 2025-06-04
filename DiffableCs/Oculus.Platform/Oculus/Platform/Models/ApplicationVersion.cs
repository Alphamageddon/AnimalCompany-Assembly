namespace Oculus.Platform.Models;

public class ApplicationVersion
{
	public readonly int CurrentCode; //Field offset: 0x10
	public readonly string CurrentName; //Field offset: 0x18
	public readonly int LatestCode; //Field offset: 0x20
	public readonly string LatestName; //Field offset: 0x28
	public readonly long ReleaseDate; //Field offset: 0x30
	public readonly string Size; //Field offset: 0x38

	public ApplicationVersion(IntPtr o) { }

}

