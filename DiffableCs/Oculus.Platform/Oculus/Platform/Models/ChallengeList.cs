namespace Oculus.Platform.Models;

public class ChallengeList : DeserializableList<Challenge>
{
	public readonly ulong TotalCount; //Field offset: 0x28

	public ChallengeList(IntPtr a) { }

}

