namespace Satori;

internal class ApiFlag : IApiFlag
{
	[CompilerGenerated]
	private bool <ConditionChanged>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Value>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "condition_changed")]
	[Preserve]
	public override bool ConditionChanged
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "name")]
	[Preserve]
	public override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "value")]
	[Preserve]
	public override string Value
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiFlag() { }

	[CompilerGenerated]
	public override bool get_ConditionChanged() { }

	[CompilerGenerated]
	public override string get_Name() { }

	[CompilerGenerated]
	public override string get_Value() { }

	[CompilerGenerated]
	public void set_ConditionChanged(bool value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Value(string value) { }

	public virtual string ToString() { }

}

