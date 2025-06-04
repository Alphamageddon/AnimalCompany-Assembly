namespace Satori;

public interface IApiAuthenticateRequest
{

	public IDictionary<String, String> Custom
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Default
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> get_Custom() { }

	public IDictionary<String, String> get_Default() { }

	public string get_Id() { }

}

