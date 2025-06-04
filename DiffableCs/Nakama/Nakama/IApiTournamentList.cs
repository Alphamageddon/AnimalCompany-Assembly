namespace Nakama;

public interface IApiTournamentList
{

	public string Cursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiTournament> Tournaments
	{
		 get { } //Length: 0
	}

	public string get_Cursor() { }

	public IEnumerable<IApiTournament> get_Tournaments() { }

}

