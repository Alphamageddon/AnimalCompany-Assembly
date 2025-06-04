namespace Nakama;

internal class MatchmakerUser : IMatchmakerUser
{
	[CompilerGenerated]
	private Dictionary<String, Double> <_numericProperties>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private UserPresence <_presence>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<String, String> <_stringProperties>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "numeric_properties")]
	[Preserve]
	public Dictionary<String, Double> _numericProperties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "presence")]
	[Preserve]
	public UserPresence _presence
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "string_properties")]
	[Preserve]
	public Dictionary<String, String> _stringProperties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IDictionary<String, Double> NumericProperties
	{
		 get { } //Length: 116
	}

	public override IUserPresence Presence
	{
		 get { } //Length: 8
	}

	public override IDictionary<String, String> StringProperties
	{
		 get { } //Length: 116
	}

	public MatchmakerUser() { }

	[CompilerGenerated]
	public Dictionary<String, Double> get__numericProperties() { }

	[CompilerGenerated]
	public UserPresence get__presence() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__stringProperties() { }

	public override IDictionary<String, Double> get_NumericProperties() { }

	public override IUserPresence get_Presence() { }

	public override IDictionary<String, String> get_StringProperties() { }

	[CompilerGenerated]
	public void set__numericProperties(Dictionary<String, Double> value) { }

	[CompilerGenerated]
	public void set__presence(UserPresence value) { }

	[CompilerGenerated]
	public void set__stringProperties(Dictionary<String, String> value) { }

	public virtual string ToString() { }

}

