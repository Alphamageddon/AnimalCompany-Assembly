namespace Nakama;

public interface IApiStorageObjectList
{

	public string Cursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiStorageObject> Objects
	{
		 get { } //Length: 0
	}

	public string get_Cursor() { }

	public IEnumerable<IApiStorageObject> get_Objects() { }

}

