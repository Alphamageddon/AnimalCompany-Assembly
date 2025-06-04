namespace Nakama;

public interface IApiAccountCustom
{

	public string Id
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Vars
	{
		 get { } //Length: 0
	}

	public string get_Id() { }

	public IDictionary<String, String> get_Vars() { }

}

