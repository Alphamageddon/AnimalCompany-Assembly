namespace Fusion.Photon.Realtime;

internal class SystemConnectionSummary
{
	private class SCSBitPos
	{
		public const int Version = 28; //Field offset: 0x0
		public const int UsedProtocol = 25; //Field offset: 0x0
		public const int EmptyBit = 24; //Field offset: 0x0
		public const int AppQuits = 23; //Field offset: 0x0
		public const int AppPause = 22; //Field offset: 0x0
		public const int AppPauseRecent = 21; //Field offset: 0x0
		public const int AppOutOfFocus = 20; //Field offset: 0x0
		public const int AppOutOfFocusRecent = 19; //Field offset: 0x0
		public const int NetworkReachable = 18; //Field offset: 0x0
		public const int ErrorCodeFits = 17; //Field offset: 0x0
		public const int ErrorCodeWinSock = 16; //Field offset: 0x0

		public SCSBitPos() { }

	}

	private static readonly String[] ProtocolIdToName; //Field offset: 0x0
	public readonly byte Version; //Field offset: 0x10
	public byte UsedProtocol; //Field offset: 0x11
	public bool AppQuits; //Field offset: 0x12
	public bool AppPause; //Field offset: 0x13
	public bool AppPauseRecent; //Field offset: 0x14
	public bool AppOutOfFocus; //Field offset: 0x15
	public bool AppOutOfFocusRecent; //Field offset: 0x16
	public bool NetworkReachable; //Field offset: 0x17
	public bool ErrorCodeFits; //Field offset: 0x18
	public bool ErrorCodeWinSock; //Field offset: 0x19
	public int SocketErrorCode; //Field offset: 0x1C

	private static SystemConnectionSummary() { }

	public SystemConnectionSummary(LoadBalancingClient client) { }

	public SystemConnectionSummary(int summary) { }

	public static bool GetBit(ref int value, int bitpos) { }

	public static byte GetBits(ref int value, int bitpos, byte mask) { }

	public static void SetBit(ref int value, bool bitval, int bitpos) { }

	public static void SetBits(ref int value, byte bitvals, int bitpos) { }

	public int ToInt() { }

	public virtual string ToString() { }

}

