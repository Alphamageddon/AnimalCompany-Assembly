namespace Satori;

internal class ApiFlagList : IApiFlagList
{
	[CompilerGenerated]
	private List<ApiFlag> <_flags>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "flags")]
	[Preserve]
	public List<ApiFlag> _flags
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiFlag> Flags
	{
		 get { } //Length: 120
	}

	public ApiFlagList() { }

	[CompilerGenerated]
	public List<ApiFlag> get__flags() { }

	public override IEnumerable<IApiFlag> get_Flags() { }

	[CompilerGenerated]
	public void set__flags(List<ApiFlag> value) { }

	public virtual string ToString() { }

}

