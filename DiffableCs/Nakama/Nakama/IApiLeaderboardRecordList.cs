namespace Nakama;

public interface IApiLeaderboardRecordList
{

	public string NextCursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiLeaderboardRecord> OwnerRecords
	{
		 get { } //Length: 0
	}

	public string PrevCursor
	{
		 get { } //Length: 0
	}

	public string RankCount
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiLeaderboardRecord> Records
	{
		 get { } //Length: 0
	}

	public string get_NextCursor() { }

	public IEnumerable<IApiLeaderboardRecord> get_OwnerRecords() { }

	public string get_PrevCursor() { }

	public string get_RankCount() { }

	public IEnumerable<IApiLeaderboardRecord> get_Records() { }

}

