namespace Nakama.Ninja.WebSockets;

public class WebSocketHttpContext
{
	[CompilerGenerated]
	private bool <IsWebSocketRequest>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IList<String> <WebSocketRequestedProtocols>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <HttpHeader>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Path>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Stream <Stream>k__BackingField; //Field offset: 0x30

	public private string HttpHeader
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private bool IsWebSocketRequest
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private string Path
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Stream Stream
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private IList<String> WebSocketRequestedProtocols
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public WebSocketHttpContext(bool isWebSocketRequest, IList<String> webSocketRequestedProtocols, string httpHeader, string path, Stream stream) { }

	[CompilerGenerated]
	public string get_HttpHeader() { }

	[CompilerGenerated]
	public bool get_IsWebSocketRequest() { }

	[CompilerGenerated]
	public string get_Path() { }

	[CompilerGenerated]
	public Stream get_Stream() { }

	[CompilerGenerated]
	public IList<String> get_WebSocketRequestedProtocols() { }

	[CompilerGenerated]
	private void set_HttpHeader(string value) { }

	[CompilerGenerated]
	private void set_IsWebSocketRequest(bool value) { }

	[CompilerGenerated]
	private void set_Path(string value) { }

	[CompilerGenerated]
	private void set_Stream(Stream value) { }

	[CompilerGenerated]
	private void set_WebSocketRequestedProtocols(IList<String> value) { }

}

