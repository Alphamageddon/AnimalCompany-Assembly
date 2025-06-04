namespace Fusion;

[Extension]
public static class Versioning
{
	public static readonly Version InvalidVersion; //Field offset: 0x0

	public static Version GetCurrentVersion
	{
		 get { } //Length: 240
	}

	private static Versioning() { }

	public static string AssemblyFileVersion() { }

	public static Version get_GetCurrentVersion() { }

	[Extension]
	public static Version ShortVersion(Version version) { }

}

