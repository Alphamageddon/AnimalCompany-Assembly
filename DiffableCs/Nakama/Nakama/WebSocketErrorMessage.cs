namespace Nakama;

internal class WebSocketErrorMessage
{
	[CompilerGenerated]
	private int <Code>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, String> <Context>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "code")]
	[Preserve]
	public int Code
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "context")]
	[Preserve]
	public Dictionary<String, String> Context
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "message")]
	[Preserve]
	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public WebSocketErrorMessage() { }

	[CompilerGenerated]
	public int get_Code() { }

	[CompilerGenerated]
	public Dictionary<String, String> get_Context() { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public void set_Code(int value) { }

	[CompilerGenerated]
	public void set_Context(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

	public virtual string ToString() { }

}

