namespace UnityEngine.ProBuilder;

internal class ChangelogEntry
{
	[SerializeField]
	private SemVer m_VersionInfo; //Field offset: 0x10
	[SerializeField]
	private string m_ReleaseNotes; //Field offset: 0x18

	public string releaseNotes
	{
		 get { } //Length: 8
	}

	public SemVer versionInfo
	{
		 get { } //Length: 8
	}

	public ChangelogEntry(SemVer version, string releaseNotes) { }

	public string get_releaseNotes() { }

	public SemVer get_versionInfo() { }

	public virtual string ToString() { }

}

