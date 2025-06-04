namespace Nakama;

public interface IApiStorageObjects
{

	public IEnumerable<IApiStorageObject> Objects
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiStorageObject> get_Objects() { }

}

