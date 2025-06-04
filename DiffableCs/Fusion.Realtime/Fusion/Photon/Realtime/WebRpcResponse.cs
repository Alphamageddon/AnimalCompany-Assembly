namespace Fusion.Photon.Realtime;

internal class WebRpcResponse
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ResultCode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Message>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Dictionary<String, Object> <Parameters>k__BackingField; //Field offset: 0x28

	[Obsolete("Use Message instead")]
	public string DebugMessage
	{
		 get { } //Length: 8
	}

	public private string Message
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Dictionary<String, Object> Parameters
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int ResultCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Obsolete("Use ResultCode instead")]
	public int ReturnCode
	{
		 get { } //Length: 8
	}

	public WebRpcResponse(OperationResponse response) { }

	public string get_DebugMessage() { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public Dictionary<String, Object> get_Parameters() { }

	[CompilerGenerated]
	public int get_ResultCode() { }

	public int get_ReturnCode() { }

	[CompilerGenerated]
	private void set_Message(string value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	[CompilerGenerated]
	private void set_Parameters(Dictionary<String, Object> value) { }

	[CompilerGenerated]
	private void set_ResultCode(int value) { }

	public string ToStringFull() { }

}

