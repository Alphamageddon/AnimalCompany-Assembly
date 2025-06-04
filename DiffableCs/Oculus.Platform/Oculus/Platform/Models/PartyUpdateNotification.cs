namespace Oculus.Platform.Models;

public class PartyUpdateNotification
{
	public readonly PartyUpdateAction Action; //Field offset: 0x10
	public readonly ulong PartyId; //Field offset: 0x18
	public readonly ulong SenderId; //Field offset: 0x20
	public readonly string UpdateTimestamp; //Field offset: 0x28
	public readonly string UserAlias; //Field offset: 0x30
	public readonly ulong UserId; //Field offset: 0x38
	public readonly string UserName; //Field offset: 0x40

	public PartyUpdateNotification(IntPtr o) { }

}

