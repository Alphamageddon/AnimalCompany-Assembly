namespace Oculus.Platform;

public class MessageWithAchievementDefinitions : Message<AchievementDefinitionList>
{

	public MessageWithAchievementDefinitions(IntPtr c_message) { }

	public virtual AchievementDefinitionList GetAchievementDefinitions() { }

	protected virtual AchievementDefinitionList GetDataFromMessage(IntPtr c_message) { }

}

