namespace Nakama;

public interface IMatchPresenceEvent
{

	public IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 0
	}

	public string MatchId
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> get_Joins() { }

	public IEnumerable<IUserPresence> get_Leaves() { }

	public string get_MatchId() { }

}

