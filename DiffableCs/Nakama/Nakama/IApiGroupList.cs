namespace Nakama;

public interface IApiGroupList
{

	public string Cursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiGroup> Groups
	{
		 get { } //Length: 0
	}

	public string get_Cursor() { }

	public IEnumerable<IApiGroup> get_Groups() { }

}

