namespace Oculus.Platform.Models;

public class Challenge
{
	public readonly ChallengeCreationType CreationType; //Field offset: 0x10
	public readonly string Description; //Field offset: 0x18
	public readonly DateTime EndDate; //Field offset: 0x20
	public readonly ulong ID; //Field offset: 0x28
	public readonly UserList InvitedUsersOptional; //Field offset: 0x30
	[Obsolete("Deprecated in favor of InvitedUsersOptional")]
	public readonly UserList InvitedUsers; //Field offset: 0x38
	public readonly Leaderboard Leaderboard; //Field offset: 0x40
	public readonly UserList ParticipantsOptional; //Field offset: 0x48
	[Obsolete("Deprecated in favor of ParticipantsOptional")]
	public readonly UserList Participants; //Field offset: 0x50
	public readonly DateTime StartDate; //Field offset: 0x58
	public readonly string Title; //Field offset: 0x60
	public readonly ChallengeVisibility Visibility; //Field offset: 0x68

	public Challenge(IntPtr o) { }

}

