namespace Nakama;

internal class PartyCreate
{
	[CompilerGenerated]
	private bool <Open>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <MaxSize>k__BackingField; //Field offset: 0x14

	[DataMember(Name = "max_size")]
	[Preserve]
	public int MaxSize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "open")]
	[Preserve]
	public bool Open
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public PartyCreate() { }

	[CompilerGenerated]
	public int get_MaxSize() { }

	[CompilerGenerated]
	public bool get_Open() { }

	[CompilerGenerated]
	public void set_MaxSize(int value) { }

	[CompilerGenerated]
	public void set_Open(bool value) { }

	public virtual string ToString() { }

}

