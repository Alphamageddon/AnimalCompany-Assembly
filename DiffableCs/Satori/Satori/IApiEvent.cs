namespace Satori;

public interface IApiEvent
{

	public string Id
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Metadata
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public string Timestamp
	{
		 get { } //Length: 0
	}

	public string Value
	{
		 get { } //Length: 0
	}

	public string get_Id() { }

	public IDictionary<String, String> get_Metadata() { }

	public string get_Name() { }

	public string get_Timestamp() { }

	public string get_Value() { }

}

