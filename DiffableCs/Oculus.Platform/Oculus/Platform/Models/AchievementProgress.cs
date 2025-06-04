namespace Oculus.Platform.Models;

public class AchievementProgress
{
	public readonly string Bitfield; //Field offset: 0x10
	public readonly ulong Count; //Field offset: 0x18
	public readonly bool IsUnlocked; //Field offset: 0x20
	public readonly string Name; //Field offset: 0x28
	public readonly DateTime UnlockTime; //Field offset: 0x30

	public AchievementProgress(IntPtr o) { }

}

