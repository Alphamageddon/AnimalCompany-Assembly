namespace Nakama.Ninja.WebSockets;

public class WebSocketServerOptions
{
	[CompilerGenerated]
	private TimeSpan <KeepAliveInterval>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IncludeExceptionInCloseResponse>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <SubProtocol>k__BackingField; //Field offset: 0x20

	public bool IncludeExceptionInCloseResponse
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public TimeSpan KeepAliveInterval
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string SubProtocol
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public WebSocketServerOptions() { }

	[CompilerGenerated]
	public bool get_IncludeExceptionInCloseResponse() { }

	[CompilerGenerated]
	public TimeSpan get_KeepAliveInterval() { }

	[CompilerGenerated]
	public string get_SubProtocol() { }

	[CompilerGenerated]
	public void set_IncludeExceptionInCloseResponse(bool value) { }

	[CompilerGenerated]
	public void set_KeepAliveInterval(TimeSpan value) { }

	[CompilerGenerated]
	public void set_SubProtocol(string value) { }

}

