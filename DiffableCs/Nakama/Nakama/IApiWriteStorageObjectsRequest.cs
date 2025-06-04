namespace Nakama;

public interface IApiWriteStorageObjectsRequest
{

	public IEnumerable<IApiWriteStorageObject> Objects
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiWriteStorageObject> get_Objects() { }

}

