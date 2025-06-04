namespace Nakama;

public interface IChannel
{

	public string GroupId
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Presences
	{
		 get { } //Length: 0
	}

	public string RoomName
	{
		 get { } //Length: 0
	}

	public IUserPresence Self
	{
		 get { } //Length: 0
	}

	public string UserIdOne
	{
		 get { } //Length: 0
	}

	public string UserIdTwo
	{
		 get { } //Length: 0
	}

	public string get_GroupId() { }

	public string get_Id() { }

	public IEnumerable<IUserPresence> get_Presences() { }

	public string get_RoomName() { }

	public IUserPresence get_Self() { }

	public string get_UserIdOne() { }

	public string get_UserIdTwo() { }

}

