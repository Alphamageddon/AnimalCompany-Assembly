namespace Nakama;

public interface IApiAccountGameCenter
{

	public string BundleId
	{
		 get { } //Length: 0
	}

	public string PlayerId
	{
		 get { } //Length: 0
	}

	public string PublicKeyUrl
	{
		 get { } //Length: 0
	}

	public string Salt
	{
		 get { } //Length: 0
	}

	public string Signature
	{
		 get { } //Length: 0
	}

	public string TimestampSeconds
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Vars
	{
		 get { } //Length: 0
	}

	public string get_BundleId() { }

	public string get_PlayerId() { }

	public string get_PublicKeyUrl() { }

	public string get_Salt() { }

	public string get_Signature() { }

	public string get_TimestampSeconds() { }

	public IDictionary<String, String> get_Vars() { }

}

