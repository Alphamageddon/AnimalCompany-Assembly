namespace Nakama;

public interface IStatus
{

	public IEnumerable<IUserPresence> Presences
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserPresence> get_Presences() { }

}

