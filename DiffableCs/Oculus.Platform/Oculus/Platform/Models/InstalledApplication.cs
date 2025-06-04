namespace Oculus.Platform.Models;

public class InstalledApplication
{
	public readonly string ApplicationId; //Field offset: 0x10
	public readonly string PackageName; //Field offset: 0x18
	public readonly string Status; //Field offset: 0x20
	public readonly int VersionCode; //Field offset: 0x28
	public readonly string VersionName; //Field offset: 0x30

	public InstalledApplication(IntPtr o) { }

}

