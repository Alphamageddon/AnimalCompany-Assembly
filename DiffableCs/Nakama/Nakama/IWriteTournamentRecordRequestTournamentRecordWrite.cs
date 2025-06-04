namespace Nakama;

public interface IWriteTournamentRecordRequestTournamentRecordWrite
{

	public string Metadata
	{
		 get { } //Length: 0
	}

	public ApiOperator Operator
	{
		 get { } //Length: 0
	}

	public string Score
	{
		 get { } //Length: 0
	}

	public string Subscore
	{
		 get { } //Length: 0
	}

	public string get_Metadata() { }

	public ApiOperator get_Operator() { }

	public string get_Score() { }

	public string get_Subscore() { }

}

