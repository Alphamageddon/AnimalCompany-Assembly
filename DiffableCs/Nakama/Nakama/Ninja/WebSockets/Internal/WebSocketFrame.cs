namespace Nakama.Ninja.WebSockets.Internal;

internal class WebSocketFrame
{
	[CompilerGenerated]
	private bool <IsFinBitSet>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private WebSocketOpCode <OpCode>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable<WebSocketCloseStatus> <CloseStatus>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private string <CloseStatusDescription>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ArraySegment<Byte> <MaskKey>k__BackingField; //Field offset: 0x30

	public private Nullable<WebSocketCloseStatus> CloseStatus
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string CloseStatusDescription
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int Count
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private bool IsFinBitSet
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private ArraySegment<Byte> MaskKey
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private WebSocketOpCode OpCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public WebSocketFrame(bool isFinBitSet, WebSocketOpCode webSocketOpCode, int count, ArraySegment<Byte> maskKey) { }

	public WebSocketFrame(bool isFinBitSet, WebSocketOpCode webSocketOpCode, int count, WebSocketCloseStatus closeStatus, string closeStatusDescription, ArraySegment<Byte> maskKey) { }

	[CompilerGenerated]
	public Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	[CompilerGenerated]
	public string get_CloseStatusDescription() { }

	[CompilerGenerated]
	public int get_Count() { }

	[CompilerGenerated]
	public bool get_IsFinBitSet() { }

	[CompilerGenerated]
	public ArraySegment<Byte> get_MaskKey() { }

	[CompilerGenerated]
	public WebSocketOpCode get_OpCode() { }

	[CompilerGenerated]
	private void set_CloseStatus(Nullable<WebSocketCloseStatus> value) { }

	[CompilerGenerated]
	private void set_CloseStatusDescription(string value) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

	[CompilerGenerated]
	private void set_IsFinBitSet(bool value) { }

	[CompilerGenerated]
	private void set_MaskKey(ArraySegment<Byte> value) { }

	[CompilerGenerated]
	private void set_OpCode(WebSocketOpCode value) { }

}

