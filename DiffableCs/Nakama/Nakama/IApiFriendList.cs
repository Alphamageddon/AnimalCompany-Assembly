namespace Nakama;

public interface IApiFriendList
{

	public string Cursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiFriend> Friends
	{
		 get { } //Length: 0
	}

	public string get_Cursor() { }

	public IEnumerable<IApiFriend> get_Friends() { }

}

