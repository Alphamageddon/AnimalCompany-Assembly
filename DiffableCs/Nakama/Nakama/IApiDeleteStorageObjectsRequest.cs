namespace Nakama;

public interface IApiDeleteStorageObjectsRequest
{

	public IEnumerable<IApiDeleteStorageObjectId> ObjectIds
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiDeleteStorageObjectId> get_ObjectIds() { }

}

