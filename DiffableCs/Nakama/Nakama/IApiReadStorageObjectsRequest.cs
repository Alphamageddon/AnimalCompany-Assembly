namespace Nakama;

public interface IApiReadStorageObjectsRequest
{

	public IEnumerable<IApiReadStorageObjectId> ObjectIds
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiReadStorageObjectId> get_ObjectIds() { }

}

