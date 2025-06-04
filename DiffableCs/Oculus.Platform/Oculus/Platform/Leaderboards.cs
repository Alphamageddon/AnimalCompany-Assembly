namespace Oculus.Platform;

public static class Leaderboards
{

	public static Request<LeaderboardList> Get(string leaderboardName) { }

	public static Request<LeaderboardEntryList> GetEntries(string leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt) { }

	public static Request<LeaderboardEntryList> GetEntriesAfterRank(string leaderboardName, int limit, ulong afterRank) { }

	public static Request<LeaderboardEntryList> GetEntriesByIds(string leaderboardName, int limit, LeaderboardStartAt startAt, UInt64[] userIDs) { }

	public static Request<LeaderboardEntryList> GetNextEntries(LeaderboardEntryList list) { }

	public static Request<LeaderboardList> GetNextLeaderboardListPage(LeaderboardList list) { }

	public static Request<LeaderboardEntryList> GetPreviousEntries(LeaderboardEntryList list) { }

	public static Request<Boolean> WriteEntry(string leaderboardName, long score, Byte[] extraData = null, bool forceUpdate = false) { }

	public static Request<Boolean> WriteEntryWithSupplementaryMetric(string leaderboardName, long score, long supplementaryMetric, Byte[] extraData = null, bool forceUpdate = false) { }

}

