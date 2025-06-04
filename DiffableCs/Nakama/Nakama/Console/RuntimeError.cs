namespace Nakama.Console;

internal class RuntimeError : IRuntimeError
{
	[CompilerGenerated]
	private int <Code>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ProtobufAny> <_details>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x28

	[DataMember(Name = "details")]
	public List<ProtobufAny> _details
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "code")]
	public override int Code
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IProtobufAny> Details
	{
		 get { } //Length: 120
	}

	[DataMember(Name = "error")]
	public override string Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "message")]
	public override string Message
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RuntimeError() { }

	[CompilerGenerated]
	public List<ProtobufAny> get__details() { }

	[CompilerGenerated]
	public override int get_Code() { }

	public override IEnumerable<IProtobufAny> get_Details() { }

	[CompilerGenerated]
	public override string get_Error() { }

	[CompilerGenerated]
	public override string get_Message() { }

	[CompilerGenerated]
	public void set__details(List<ProtobufAny> value) { }

	[CompilerGenerated]
	public void set_Code(int value) { }

	[CompilerGenerated]
	public void set_Error(string value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

	public virtual string ToString() { }

}

