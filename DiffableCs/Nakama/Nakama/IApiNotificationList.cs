namespace Nakama;

public interface IApiNotificationList
{

	public string CacheableCursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiNotification> Notifications
	{
		 get { } //Length: 0
	}

	public string get_CacheableCursor() { }

	public IEnumerable<IApiNotification> get_Notifications() { }

}

