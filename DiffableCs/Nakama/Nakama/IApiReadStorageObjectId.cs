namespace Nakama;

public interface IApiReadStorageObjectId
{

	public string Collection
	{
		 get { } //Length: 0
	}

	public string Key
	{
		 get { } //Length: 0
	}

	public string UserId
	{
		 get { } //Length: 0
	}

	public string get_Collection() { }

	public string get_Key() { }

	public string get_UserId() { }

}

