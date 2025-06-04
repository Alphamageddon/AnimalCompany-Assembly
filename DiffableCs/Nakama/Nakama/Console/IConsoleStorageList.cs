namespace Nakama.Console;

public interface IConsoleStorageList
{

	public IEnumerable<IApiStorageObject> Objects
	{
		 get { } //Length: 0
	}

	public int TotalCount
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiStorageObject> get_Objects() { }

	public int get_TotalCount() { }

}

