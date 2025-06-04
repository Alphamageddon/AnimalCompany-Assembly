namespace Nakama;

public interface IStatusPresenceEvent
{

	public IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> get_Joins() { }

	public IEnumerable<IUserPresence> get_Leaves() { }

}

