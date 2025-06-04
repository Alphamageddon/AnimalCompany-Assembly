namespace Satori;

internal class ApiLiveEventList : IApiLiveEventList
{
	[CompilerGenerated]
	private List<ApiLiveEvent> <_liveEvents>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "live_events")]
	[Preserve]
	public List<ApiLiveEvent> _liveEvents
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiLiveEvent> LiveEvents
	{
		 get { } //Length: 120
	}

	public ApiLiveEventList() { }

	[CompilerGenerated]
	public List<ApiLiveEvent> get__liveEvents() { }

	public override IEnumerable<IApiLiveEvent> get_LiveEvents() { }

	[CompilerGenerated]
	public void set__liveEvents(List<ApiLiveEvent> value) { }

	public virtual string ToString() { }

}

