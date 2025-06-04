namespace Satori;

public interface IApiGetMessageListResponse
{

	public string CacheableCursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiMessage> Messages
	{
		 get { } //Length: 0
	}

	public string NextCursor
	{
		 get { } //Length: 0
	}

	public string PrevCursor
	{
		 get { } //Length: 0
	}

	public string get_CacheableCursor() { }

	public IEnumerable<IApiMessage> get_Messages() { }

	public string get_NextCursor() { }

	public string get_PrevCursor() { }

}

