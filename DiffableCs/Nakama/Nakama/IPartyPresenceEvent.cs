namespace Nakama;

public interface IPartyPresenceEvent
{

	public IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 0
	}

	public string PartyId
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> get_Joins() { }

	public IEnumerable<IUserPresence> get_Leaves() { }

	public string get_PartyId() { }

}

