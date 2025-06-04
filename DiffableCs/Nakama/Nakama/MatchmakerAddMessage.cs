namespace Nakama;

internal class MatchmakerAddMessage
{
	[CompilerGenerated]
	private int <MaxCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <MinCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Dictionary<String, Double> <NumericProperties>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Query>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Dictionary<String, String> <StringProperties>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Nullable<Int32> <CountMultiple>k__BackingField; //Field offset: 0x30

	[DataMember(Name = "count_multiple")]
	[Preserve]
	public Nullable<Int32> CountMultiple
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "max_count")]
	[Preserve]
	public int MaxCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "min_count")]
	[Preserve]
	public int MinCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "numeric_properties")]
	[Preserve]
	public Dictionary<String, Double> NumericProperties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "query")]
	[Preserve]
	public string Query
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "string_properties")]
	[Preserve]
	public Dictionary<String, String> StringProperties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MatchmakerAddMessage() { }

	[CompilerGenerated]
	public Nullable<Int32> get_CountMultiple() { }

	[CompilerGenerated]
	public int get_MaxCount() { }

	[CompilerGenerated]
	public int get_MinCount() { }

	[CompilerGenerated]
	public Dictionary<String, Double> get_NumericProperties() { }

	[CompilerGenerated]
	public string get_Query() { }

	[CompilerGenerated]
	public Dictionary<String, String> get_StringProperties() { }

	[CompilerGenerated]
	public void set_CountMultiple(Nullable<Int32> value) { }

	[CompilerGenerated]
	public void set_MaxCount(int value) { }

	[CompilerGenerated]
	public void set_MinCount(int value) { }

	[CompilerGenerated]
	public void set_NumericProperties(Dictionary<String, Double> value) { }

	[CompilerGenerated]
	public void set_Query(string value) { }

	[CompilerGenerated]
	public void set_StringProperties(Dictionary<String, String> value) { }

	public virtual string ToString() { }

}

