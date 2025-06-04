namespace Nakama;

public interface IPartyData
{

	public Byte[] Data
	{
		 get { } //Length: 0
	}

	public long OpCode
	{
		 get { } //Length: 0
	}

	public string PartyId
	{
		 get { } //Length: 0
	}

	public IUserPresence Presence
	{
		 get { } //Length: 0
	}

	public Byte[] get_Data() { }

	public long get_OpCode() { }

	public string get_PartyId() { }

	public IUserPresence get_Presence() { }

}

