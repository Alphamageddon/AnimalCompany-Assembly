namespace Nakama;

public interface IParty
{

	public string Id
	{
		 get { } //Length: 0
	}

	public IUserPresence Leader
	{
		 get { } //Length: 0
	}

	public int MaxSize
	{
		 get { } //Length: 0
	}

	public bool Open
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Presences
	{
		 get { } //Length: 0
	}

	public IUserPresence Self
	{
		 get { } //Length: 0
	}

	public string get_Id() { }

	public IUserPresence get_Leader() { }

	public int get_MaxSize() { }

	public bool get_Open() { }

	public IEnumerable<IUserPresence> get_Presences() { }

	public IUserPresence get_Self() { }

	public void UpdatePresences(IPartyPresenceEvent presenceEvent) { }

}

