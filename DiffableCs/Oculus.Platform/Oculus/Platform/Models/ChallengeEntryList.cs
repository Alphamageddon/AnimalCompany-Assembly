namespace Oculus.Platform.Models;

public class ChallengeEntryList : DeserializableList<ChallengeEntry>
{
	public readonly ulong TotalCount; //Field offset: 0x28

	public ChallengeEntryList(IntPtr a) { }

}

