namespace Satori;

public interface ISession
{

	public string AuthToken
	{
		 get { } //Length: 0
	}

	public long ExpireTime
	{
		 get { } //Length: 0
	}

	public string IdentityId
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

	public string get_AuthToken() { }

	public long get_ExpireTime() { }

	public string get_IdentityId() { }

	public bool get_IsExpired() { }

	public bool get_IsRefreshExpired() { }

	public long get_RefreshExpireTime() { }

	public string get_RefreshToken() { }

	public bool HasExpired(DateTime offset) { }

	public bool HasRefreshExpired(DateTime offset) { }

}

