namespace Nakama;

public interface IApiEvent
{

	public bool External
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Properties
	{
		 get { } //Length: 0
	}

	public string Timestamp
	{
		 get { } //Length: 0
	}

	public bool get_External() { }

	public string get_Name() { }

	public IDictionary<String, String> get_Properties() { }

	public string get_Timestamp() { }

}

