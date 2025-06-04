namespace Fusion;

public static class AuthorityMasks
{
	public const int STATE = 1; //Field offset: 0x0
	public const int INPUT = 2; //Field offset: 0x0
	public const int PROXY = 4; //Field offset: 0x0
	public const int NONE = 0; //Field offset: 0x0
	public const int ALL = 7; //Field offset: 0x0

	internal static int Create(bool state, bool input) { }

}

