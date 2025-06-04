namespace Nakama;

internal class ApiNotificationList : IApiNotificationList
{
	[CompilerGenerated]
	private string <CacheableCursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiNotification> <_notifications>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "notifications")]
	[Preserve]
	public List<ApiNotification> _notifications
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "cacheable_cursor")]
	[Preserve]
	public override string CacheableCursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiNotification> Notifications
	{
		 get { } //Length: 120
	}

	public ApiNotificationList() { }

	[CompilerGenerated]
	public List<ApiNotification> get__notifications() { }

	[CompilerGenerated]
	public override string get_CacheableCursor() { }

	public override IEnumerable<IApiNotification> get_Notifications() { }

	[CompilerGenerated]
	public void set__notifications(List<ApiNotification> value) { }

	[CompilerGenerated]
	public void set_CacheableCursor(string value) { }

	public virtual string ToString() { }

}

