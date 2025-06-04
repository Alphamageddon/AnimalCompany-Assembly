namespace Nakama;

public interface IStreamPresenceEvent
{

	public IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 0
	}

	public IStream Stream
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> get_Joins() { }

	public IEnumerable<IUserPresence> get_Leaves() { }

	public IStream get_Stream() { }

}

