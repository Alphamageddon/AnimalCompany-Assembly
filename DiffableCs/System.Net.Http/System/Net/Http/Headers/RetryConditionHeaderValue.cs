namespace System.Net.Http.Headers;

public class RetryConditionHeaderValue : ICloneable
{
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable<TimeSpan> <Delta>k__BackingField; //Field offset: 0x28

	public private Nullable<DateTimeOffset> Date
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private Nullable<TimeSpan> Delta
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public RetryConditionHeaderValue(DateTimeOffset date) { }

	public RetryConditionHeaderValue(TimeSpan delta) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	public Nullable<TimeSpan> get_Delta() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	private void set_Delta(Nullable<TimeSpan> value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

}

