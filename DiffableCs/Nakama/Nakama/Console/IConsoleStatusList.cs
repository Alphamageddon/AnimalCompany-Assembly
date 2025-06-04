namespace Nakama.Console;

public interface IConsoleStatusList
{

	public IEnumerable<IStatusListStatus> Nodes
	{
		 get { } //Length: 0
	}

	public IEnumerable<IStatusListStatus> get_Nodes() { }

}

