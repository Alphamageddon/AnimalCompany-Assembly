namespace Nakama;

public interface ILogger
{

	public void DebugFormat(string format, Object[] args) { }

	public void ErrorFormat(string format, Object[] args) { }

	public void InfoFormat(string format, Object[] args) { }

	public void WarnFormat(string format, Object[] args) { }

}

