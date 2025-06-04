namespace Satori;

internal class ApiEventRequest : IApiEventRequest
{
	[CompilerGenerated]
	private List<ApiEvent> <_events>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "events")]
	[Preserve]
	public List<ApiEvent> _events
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiEvent> Events
	{
		 get { } //Length: 120
	}

	public ApiEventRequest() { }

	[CompilerGenerated]
	public List<ApiEvent> get__events() { }

	public override IEnumerable<IApiEvent> get_Events() { }

	[CompilerGenerated]
	public void set__events(List<ApiEvent> value) { }

	public virtual string ToString() { }

}

