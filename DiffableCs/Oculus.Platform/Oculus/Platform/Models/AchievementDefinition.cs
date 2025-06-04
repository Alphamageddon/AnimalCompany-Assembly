namespace Oculus.Platform.Models;

public class AchievementDefinition
{
	public readonly AchievementType Type; //Field offset: 0x10
	public readonly string Name; //Field offset: 0x18
	public readonly uint BitfieldLength; //Field offset: 0x20
	public readonly ulong Target; //Field offset: 0x28

	public AchievementDefinition(IntPtr o) { }

}

