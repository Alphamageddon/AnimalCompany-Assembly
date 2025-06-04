namespace Oculus.Platform;

public class MessageWithAchievementProgressList : Message<AchievementProgressList>
{

	public MessageWithAchievementProgressList(IntPtr c_message) { }

	public virtual AchievementProgressList GetAchievementProgressList() { }

	protected virtual AchievementProgressList GetDataFromMessage(IntPtr c_message) { }

}

