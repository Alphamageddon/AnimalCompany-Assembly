namespace Satori;

public interface IApiLiveEventList
{

	public IEnumerable<IApiLiveEvent> LiveEvents
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiLiveEvent> get_LiveEvents() { }

}

