namespace Nakama;

public interface IMatchmakerMatched
{

	public string MatchId
	{
		 get { } //Length: 0
	}

	public IMatchmakerUser Self
	{
		 get { } //Length: 0
	}

	public string Ticket
	{
		 get { } //Length: 0
	}

	public string Token
	{
		 get { } //Length: 0
	}

	public IEnumerable<IMatchmakerUser> Users
	{
		 get { } //Length: 0
	}

	public string get_MatchId() { }

	public IMatchmakerUser get_Self() { }

	public string get_Ticket() { }

	public string get_Token() { }

	public IEnumerable<IMatchmakerUser> get_Users() { }

}

