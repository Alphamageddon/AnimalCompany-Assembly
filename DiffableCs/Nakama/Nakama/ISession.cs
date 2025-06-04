namespace Nakama;

public interface ISession
{

	public string AuthToken
	{
		 get { } //Length: 0
	}

	public bool Created
	{
		 get { } //Length: 0
	}

	public long CreateTime
	{
		 get { } //Length: 0
	}

	public long ExpireTime
	{
		 get { } //Length: 0
	}

	public bool IsExpired
	{
		 get { } //Length: 0
	}

	public bool IsRefreshExpired
	{
		 get { } //Length: 0
	}

	public long RefreshExpireTime
	{
		 get { } //Length: 0
	}

	public string RefreshToken
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

	public IDictionary<String, String> Vars
	{
		 get { } //Length: 0
	}

	public string get_AuthToken() { }

	public bool get_Created() { }

	public long get_CreateTime() { }

	public long get_ExpireTime() { }

	public bool get_IsExpired() { }

	public bool get_IsRefreshExpired() { }

	public long get_RefreshExpireTime() { }

	public string get_RefreshToken() { }

	public string get_UserId() { }

	public string get_Username() { }

	public IDictionary<String, String> get_Vars() { }

	public bool HasExpired(DateTime offset) { }

	public bool HasRefreshExpired(DateTime offset) { }

}

