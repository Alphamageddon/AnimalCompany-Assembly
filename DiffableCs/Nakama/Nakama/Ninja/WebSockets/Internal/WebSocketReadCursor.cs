namespace Nakama.Ninja.WebSockets.Internal;

internal class WebSocketReadCursor
{
	[CompilerGenerated]
	private WebSocketFrame <WebSocketFrame>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <NumBytesRead>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <NumBytesLeftToRead>k__BackingField; //Field offset: 0x1C

	public private int NumBytesLeftToRead
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int NumBytesRead
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private WebSocketFrame WebSocketFrame
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public WebSocketReadCursor(WebSocketFrame frame, int numBytesRead, int numBytesLeftToRead) { }

	[CompilerGenerated]
	public int get_NumBytesLeftToRead() { }

	[CompilerGenerated]
	public int get_NumBytesRead() { }

	[CompilerGenerated]
	public WebSocketFrame get_WebSocketFrame() { }

	[CompilerGenerated]
	private void set_NumBytesLeftToRead(int value) { }

	[CompilerGenerated]
	private void set_NumBytesRead(int value) { }

	[CompilerGenerated]
	private void set_WebSocketFrame(WebSocketFrame value) { }

}

