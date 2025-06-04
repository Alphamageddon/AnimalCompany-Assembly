namespace UnityEngine.ProBuilder;

internal sealed class SemVer : IEquatable<SemVer>, IComparable<SemVer>, IComparable
{
	public const string DefaultStringFormat = "M.m.p-t.b"; //Field offset: 0x0
	[SerializeField]
	private int m_Major; //Field offset: 0x10
	[SerializeField]
	private int m_Minor; //Field offset: 0x14
	[SerializeField]
	private int m_Patch; //Field offset: 0x18
	[SerializeField]
	private int m_Build; //Field offset: 0x1C
	[SerializeField]
	private string m_Type; //Field offset: 0x20
	[SerializeField]
	private string m_Metadata; //Field offset: 0x28
	[SerializeField]
	private string m_Date; //Field offset: 0x30

	public int build
	{
		 get { } //Length: 8
	}

	public string date
	{
		 get { } //Length: 80
	}

	public int major
	{
		 get { } //Length: 8
	}

	public SemVer MajorMinorPatch
	{
		 get { } //Length: 132
	}

	public string metadata
	{
		 get { } //Length: 80
	}

	public int minor
	{
		 get { } //Length: 8
	}

	public int patch
	{
		 get { } //Length: 8
	}

	public string type
	{
		 get { } //Length: 80
	}

	public SemVer() { }

	public SemVer(string formatted, string date = null) { }

	public SemVer(int major, int minor, int patch, int build = -1, string type = null, string date = null, string metadata = null) { }

	public override int CompareTo(SemVer version) { }

	public override int CompareTo(object obj) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(SemVer version) { }

	public int get_build() { }

	public string get_date() { }

	public int get_major() { }

	public SemVer get_MajorMinorPatch() { }

	public string get_metadata() { }

	public int get_minor() { }

	public int get_patch() { }

	public string get_type() { }

	private static int GetBuildNumber(string input) { }

	public virtual int GetHashCode() { }

	public bool IsValid() { }

	public static bool op_Equality(SemVer left, SemVer right) { }

	public static bool op_GreaterThan(SemVer left, SemVer right) { }

	public static bool op_GreaterThanOrEqual(SemVer left, SemVer right) { }

	public static bool op_Inequality(SemVer left, SemVer right) { }

	public static bool op_LessThan(SemVer left, SemVer right) { }

	public static bool op_LessThanOrEqual(SemVer left, SemVer right) { }

	public string ToString(string format) { }

	public virtual string ToString() { }

	public static bool TryGetVersionInfo(string input, out SemVer version) { }

	private static int WrapNoValue(int value) { }

}

