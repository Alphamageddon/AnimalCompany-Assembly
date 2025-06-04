namespace Nakama;

public interface IUserPresence
{

	public bool Persistence
	{
		 get { } //Length: 0
	}

	public string SessionId
	{
		 get { } //Length: 0
	}

	public string Status
	{
		 get { } //Length: 0
	}

	public string UserId
	{
		 get { } //Length: 0
	}

	public string Username
	{
		 get { } //Length: 0
	}

	public bool get_Persistence() { }

	public string get_SessionId() { }

	public string get_Status() { }

	public string get_UserId() { }

	public string get_Username() { }

}

