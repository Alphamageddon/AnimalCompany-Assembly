namespace Oculus.Platform;

public static class Achievements
{

	public static Request<AchievementUpdate> AddCount(string name, ulong count) { }

	public static Request<AchievementUpdate> AddFields(string name, string fields) { }

	public static Request<AchievementDefinitionList> GetAllDefinitions() { }

	public static Request<AchievementProgressList> GetAllProgress() { }

	public static Request<AchievementDefinitionList> GetDefinitionsByName(String[] names) { }

	public static Request<AchievementDefinitionList> GetNextAchievementDefinitionListPage(AchievementDefinitionList list) { }

	public static Request<AchievementProgressList> GetNextAchievementProgressListPage(AchievementProgressList list) { }

	public static Request<AchievementProgressList> GetProgressByName(String[] names) { }

	public static Request<AchievementUpdate> Unlock(string name) { }

}

