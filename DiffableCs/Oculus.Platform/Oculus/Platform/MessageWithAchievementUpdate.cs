namespace Oculus.Platform;

public class MessageWithAchievementUpdate : Message<AchievementUpdate>
{

	public MessageWithAchievementUpdate(IntPtr c_message) { }

	public virtual AchievementUpdate GetAchievementUpdate() { }

	protected virtual AchievementUpdate GetDataFromMessage(IntPtr c_message) { }

}

