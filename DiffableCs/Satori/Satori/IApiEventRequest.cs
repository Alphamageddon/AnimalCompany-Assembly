namespace Satori;

public interface IApiEventRequest
{

	public IEnumerable<IApiEvent> Events
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiEvent> get_Events() { }

}

