namespace System.Net.Http.Headers;

public class RangeConditionHeaderValue : ICloneable
{
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EntityTagHeaderValue <EntityTag>k__BackingField; //Field offset: 0x28

	public private Nullable<DateTimeOffset> Date
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private EntityTagHeaderValue EntityTag
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public RangeConditionHeaderValue(DateTimeOffset date) { }

	public RangeConditionHeaderValue(EntityTagHeaderValue entityTag) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	public EntityTagHeaderValue get_EntityTag() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	private void set_EntityTag(EntityTagHeaderValue value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

}

