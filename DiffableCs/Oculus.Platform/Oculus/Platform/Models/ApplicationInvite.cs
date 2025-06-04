namespace Oculus.Platform.Models;

public class ApplicationInvite
{
	public readonly Destination DestinationOptional; //Field offset: 0x10
	[Obsolete("Deprecated in favor of DestinationOptional")]
	public readonly Destination Destination; //Field offset: 0x18
	public readonly ulong ID; //Field offset: 0x20
	public readonly bool IsActive; //Field offset: 0x28
	public readonly string LobbySessionId; //Field offset: 0x30
	public readonly string MatchSessionId; //Field offset: 0x38
	public readonly User RecipientOptional; //Field offset: 0x40
	[Obsolete("Deprecated in favor of RecipientOptional")]
	public readonly User Recipient; //Field offset: 0x48

	public ApplicationInvite(IntPtr o) { }

}

