namespace Nakama;

public interface IMatchState
{

	public string MatchId
	{
		 get { } //Length: 0
	}

	public long OpCode
	{
		 get { } //Length: 0
	}

	public Byte[] State
	{
		 get { } //Length: 0
	}

	public IUserPresence UserPresence
	{
		 get { } //Length: 0
	}

	public string get_MatchId() { }

	public long get_OpCode() { }

	public Byte[] get_State() { }

	public IUserPresence get_UserPresence() { }

}

