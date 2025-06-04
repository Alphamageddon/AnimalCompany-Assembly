namespace Nakama;

public interface IStreamState
{

	public IUserPresence Sender
	{
		 get { } //Length: 0
	}

	public string State
	{
		 get { } //Length: 0
	}

	public IStream Stream
	{
		 get { } //Length: 0
	}

	public IUserPresence get_Sender() { }

	public string get_State() { }

	public IStream get_Stream() { }

}

