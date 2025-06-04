namespace UnityEngine.ProBuilder;

internal class Changelog
{
	private const string k_ChangelogEntryPattern = "(##\s\[[0-9]+\.[0-9]+\.[0-9]+(\-[a-zA-Z]+(\.[0-9]+)*)*\])"; //Field offset: 0x0
	private const string k_VersionInfoPattern = "(?<=##\s\[).*(?=\])"; //Field offset: 0x0
	private const string k_VersionDatePattern = "(?<=##\s\[.*\]\s-\s)[0-9-]*"; //Field offset: 0x0
	[SerializeField]
	private List<ChangelogEntry> m_Entries; //Field offset: 0x10

	public ReadOnlyCollection<ChangelogEntry> entries
	{
		 get { } //Length: 124
	}

	public Changelog(string log) { }

	private ChangelogEntry CreateEntry(string version, string contents) { }

	public ReadOnlyCollection<ChangelogEntry> get_entries() { }

}

