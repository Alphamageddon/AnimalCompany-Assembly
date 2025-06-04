namespace Nakama;

public interface IMatch
{

	public bool Authoritative
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public string Label
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

	public int Size
	{
		 get { } //Length: 0
	}

	public bool get_Authoritative() { }

	public string get_Id() { }

	public string get_Label() { }

	public IEnumerable<IUserPresence> get_Presences() { }

	public IUserPresence get_Self() { }

	public int get_Size() { }

	public void UpdatePresences(IMatchPresenceEvent presenceEvent) { }

}

