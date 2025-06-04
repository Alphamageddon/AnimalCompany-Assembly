namespace Nakama;

public interface IPartyJoinRequest
{

	public string PartyId
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Presences
	{
		 get { } //Length: 0
	}

	public string get_PartyId() { }

	public IEnumerable<IUserPresence> get_Presences() { }

}

