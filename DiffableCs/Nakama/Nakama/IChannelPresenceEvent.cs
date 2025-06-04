namespace Nakama;

public interface IChannelPresenceEvent
{

	public string ChannelId
	{
		 get { } //Length: 0
	}

	public string GroupId
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 0
	}

	public string RoomName
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

	public string get_ChannelId() { }

	public string get_GroupId() { }

	public IEnumerable<IUserPresence> get_Joins() { }

	public IEnumerable<IUserPresence> get_Leaves() { }

	public string get_RoomName() { }

	public string get_UserIdOne() { }

	public string get_UserIdTwo() { }

}

