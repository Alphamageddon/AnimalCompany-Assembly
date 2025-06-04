namespace Fusion.Photon.Realtime;

internal class ErrorCode
{
	public const int Ok = 0; //Field offset: 0x0
	public const int OperationLimitReached = 32743; //Field offset: 0x0
	public const int ExternalHttpCallFailed = 32744; //Field offset: 0x0
	public const int HttpLimitReached = 32745; //Field offset: 0x0
	public const int JoinFailedFoundActiveJoiner = 32746; //Field offset: 0x0
	public const int JoinFailedFoundExcludedUserId = 32747; //Field offset: 0x0
	public const int JoinFailedWithRejoinerNotFound = 32748; //Field offset: 0x0
	public const int JoinFailedFoundInactiveJoiner = 32749; //Field offset: 0x0
	public const int JoinFailedPeerAlreadyJoined = 32750; //Field offset: 0x0
	public const int PluginMismatch = 32751; //Field offset: 0x0
	public const int PluginReportedError = 32752; //Field offset: 0x0
	public const int AuthenticationTicketExpired = 32753; //Field offset: 0x0
	public const int CustomAuthenticationFailed = 32755; //Field offset: 0x0
	public const int InvalidRegion = 32756; //Field offset: 0x0
	public const int MaxCcuReached = 32757; //Field offset: 0x0
	public const int GameDoesNotExist = 32758; //Field offset: 0x0
	public const int NoRandomMatchFound = 32760; //Field offset: 0x0
	public const int UserBlocked = 32761; //Field offset: 0x0
	public const int ServerFull = 32762; //Field offset: 0x0
	[Obsolete("No longer used, cause random matchmaking is no longer a process.")]
	public const int AlreadyMatched = 32763; //Field offset: 0x0
	public const int GameClosed = 32764; //Field offset: 0x0
	public const int GameFull = 32765; //Field offset: 0x0
	public const int GameIdAlreadyExists = 32766; //Field offset: 0x0
	public const int InvalidAuthentication = 32767; //Field offset: 0x0
	public const int InternalServerError = -1; //Field offset: 0x0
	public const int InvalidOperation = -2; //Field offset: 0x0
	[Obsolete("Use InvalidOperation.")]
	public const int InvalidOperationCode = -2; //Field offset: 0x0
	public const int OperationNotAllowedInCurrentState = -3; //Field offset: 0x0
	public const int SlotError = 32742; //Field offset: 0x0
	public const int InvalidEncryptionParameters = 32741; //Field offset: 0x0

	public ErrorCode() { }

}

