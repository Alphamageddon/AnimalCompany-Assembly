namespace Nakama.Console;

public interface IConsoleConfig
{

	public string Config
	{
		 get { } //Length: 0
	}

	public string ServerVersion
	{
		 get { } //Length: 0
	}

	public IEnumerable<IConfigWarning> Warnings
	{
		 get { } //Length: 0
	}

	public string get_Config() { }

	public string get_ServerVersion() { }

	public IEnumerable<IConfigWarning> get_Warnings() { }

}

