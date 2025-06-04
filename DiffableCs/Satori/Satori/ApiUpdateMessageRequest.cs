namespace Satori;

internal class ApiUpdateMessageRequest : IApiUpdateMessageRequest
{
	[CompilerGenerated]
	private string <ConsumeTime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <ReadTime>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "consume_time")]
	[Preserve]
	public override string ConsumeTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "read_time")]
	[Preserve]
	public override string ReadTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiUpdateMessageRequest() { }

	[CompilerGenerated]
	public override string get_ConsumeTime() { }

	[CompilerGenerated]
	public override string get_ReadTime() { }

	[CompilerGenerated]
	public void set_ConsumeTime(string value) { }

	[CompilerGenerated]
	public void set_ReadTime(string value) { }

	public virtual string ToString() { }

}

