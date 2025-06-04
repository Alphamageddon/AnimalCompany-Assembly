namespace Nakama;

public interface IApiListSubscriptionsRequest
{

	public string Cursor
	{
		 get { } //Length: 0
	}

	public int Limit
	{
		 get { } //Length: 0
	}

	public string get_Cursor() { }

	public int get_Limit() { }

}

