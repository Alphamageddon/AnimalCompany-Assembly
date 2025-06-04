namespace Photon.Voice;

public interface ILogger
{

	public LogLevel Level
	{
		 get { } //Length: 0
	}

	public LogLevel get_Level() { }

	public void Log(LogLevel level, string fmt, Object[] args) { }

}

