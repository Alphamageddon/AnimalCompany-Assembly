namespace Nakama.Console;

internal class ProtobufAny : IProtobufAny
{
	[CompilerGenerated]
	private string <TypeUrl>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "type_url")]
	public override string TypeUrl
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "value")]
	public override string Value
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ProtobufAny() { }

	[CompilerGenerated]
	public override string get_TypeUrl() { }

	[CompilerGenerated]
	public override string get_Value() { }

	[CompilerGenerated]
	public void set_TypeUrl(string value) { }

	[CompilerGenerated]
	public void set_Value(string value) { }

	public virtual string ToString() { }

}

