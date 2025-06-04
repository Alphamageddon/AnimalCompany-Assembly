namespace Fusion.Sockets;

internal struct NetCommandConnect
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <TokenData>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <UniqueId>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	public const int TOKEN_MAX_LENGTH_BYTES = 128; //Field offset: 0x0
	public const int UNIQUE_ID_LENGTH_BYTES = 8; //Field offset: 0x0
	public const int SIZE_BYTES = 152; //Field offset: 0x0
	public const int SIZE_BITS = 1216; //Field offset: 0x0
	public NetCommandHeader Header; //Field offset: 0x0
	public int TokenLength; //Field offset: 0x4
	public NetConnectionId ConnectionId; //Field offset: 0x8
	[FixedBuffer(typeof(byte, 128)]
	public <TokenData>e__FixedBuffer TokenData; //Field offset: 0x10
	[FixedBuffer(typeof(byte, 8)]
	public <UniqueId>e__FixedBuffer UniqueId; //Field offset: 0x90

	public static int ClampTokenLength(int tokenLength) { }

	public static NetCommandConnect Create(NetConnectionId id, Byte* token = null, int tokenLength = 0, Byte* uniqueId = null) { }

	public static Byte[] GetTokenDataAsArray(NetCommandConnect command) { }

	public static Byte[] GetUniqueIdAsArray(NetCommandConnect command) { }

}

