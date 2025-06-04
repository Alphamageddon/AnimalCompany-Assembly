namespace Fusion.Sockets;

internal struct NetCommandDisconnect
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <TokenData>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	public const int TOKEN_MAX_LENGTH_BYTES = 128; //Field offset: 0x0
	public NetCommandHeader Header; //Field offset: 0x0
	public NetDisconnectReason Reason; //Field offset: 0x2
	public int TokenLength; //Field offset: 0x4
	[FixedBuffer(typeof(byte, 128)]
	public <TokenData>e__FixedBuffer TokenData; //Field offset: 0x8

	public static NetCommandDisconnect Create(NetDisconnectReason reason, Byte[] token) { }

	public static NetCommandDisconnect Create(NetDisconnectReason reason, Byte* token, int tokenLength) { }

}

