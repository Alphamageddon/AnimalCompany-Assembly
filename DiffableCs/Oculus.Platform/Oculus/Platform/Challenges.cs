namespace Oculus.Platform;

public static class Challenges
{

	public static Request<Challenge> Create(string leaderboardName, ChallengeOptions challengeOptions) { }

	public static Request<Challenge> DeclineInvite(ulong challengeID) { }

	public static Request Delete(ulong challengeID) { }

	public static Request<Challenge> Get(ulong challengeID) { }

	public static Request<ChallengeEntryList> GetEntries(ulong challengeID, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt) { }

	public static Request<ChallengeEntryList> GetEntriesAfterRank(ulong challengeID, int limit, ulong afterRank) { }

	public static Request<ChallengeEntryList> GetEntriesByIds(ulong challengeID, int limit, LeaderboardStartAt startAt, UInt64[] userIDs) { }

	public static Request<ChallengeList> GetList(ChallengeOptions challengeOptions, int limit) { }

	public static Request<ChallengeList> GetNextChallenges(ChallengeList list) { }

	public static Request<ChallengeEntryList> GetNextEntries(ChallengeEntryList list) { }

	public static Request<ChallengeList> GetPreviousChallenges(ChallengeList list) { }

	public static Request<ChallengeEntryList> GetPreviousEntries(ChallengeEntryList list) { }

	public static Request<Challenge> Join(ulong challengeID) { }

	public static Request<Challenge> Leave(ulong challengeID) { }

	public static Request<Challenge> UpdateInfo(ulong challengeID, ChallengeOptions challengeOptions) { }

}

