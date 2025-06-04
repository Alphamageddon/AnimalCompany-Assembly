namespace Nakama;

public interface IPartyLeader
{

	public string PartyId
	{
		 get { } //Length: 0
	}

	public IUserPresence Presence
	{
		 get { } //Length: 0
	}

	public string get_PartyId() { }

	public IUserPresence get_Presence() { }

}

