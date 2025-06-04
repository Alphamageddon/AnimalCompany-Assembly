namespace Nakama;

public interface IApiSubscriptionList
{

	public string Cursor
	{
		 get { } //Length: 0
	}

	public string PrevCursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiValidatedSubscription> ValidatedSubscriptions
	{
		 get { } //Length: 0
	}

	public string get_Cursor() { }

	public string get_PrevCursor() { }

	public IEnumerable<IApiValidatedSubscription> get_ValidatedSubscriptions() { }

}

