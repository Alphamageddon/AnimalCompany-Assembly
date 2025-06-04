namespace Oculus.Platform.Models;

public class AchievementUpdate
{
	public readonly bool JustUnlocked; //Field offset: 0x10
	public readonly string Name; //Field offset: 0x18

	public AchievementUpdate(IntPtr o) { }

}

