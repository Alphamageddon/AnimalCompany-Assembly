namespace Nakama;

public interface IApiDeleteStorageObjectId
{

	public string Collection
	{
		 get { } //Length: 0
	}

	public string Key
	{
		 get { } //Length: 0
	}

	public string Version
	{
		 get { } //Length: 0
	}

	public string get_Collection() { }

	public string get_Key() { }

	public string get_Version() { }

}

