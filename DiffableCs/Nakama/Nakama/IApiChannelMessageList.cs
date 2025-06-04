namespace Nakama;

public interface IApiChannelMessageList
{

	public string CacheableCursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiChannelMessage> Messages
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

	public IEnumerable<IApiChannelMessage> get_Messages() { }

	public string get_NextCursor() { }

	public string get_PrevCursor() { }

}

