namespace Nakama;

public interface IApiRpc
{

	public string HttpKey
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public string Payload
	{
		 get { } //Length: 0
	}

	public string get_HttpKey() { }

	public string get_Id() { }

	public string get_Payload() { }

}

