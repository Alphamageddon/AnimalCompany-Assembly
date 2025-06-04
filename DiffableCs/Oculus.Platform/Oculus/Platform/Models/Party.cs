namespace Oculus.Platform.Models;

public class Party
{
	public readonly ulong ID; //Field offset: 0x10
	public readonly UserList InvitedUsersOptional; //Field offset: 0x18
	[Obsolete("Deprecated in favor of InvitedUsersOptional")]
	public readonly UserList InvitedUsers; //Field offset: 0x20
	public readonly User LeaderOptional; //Field offset: 0x28
	[Obsolete("Deprecated in favor of LeaderOptional")]
	public readonly User Leader; //Field offset: 0x30
	public readonly UserList UsersOptional; //Field offset: 0x38
	[Obsolete("Deprecated in favor of UsersOptional")]
	public readonly UserList Users; //Field offset: 0x40

	public Party(IntPtr o) { }

}

