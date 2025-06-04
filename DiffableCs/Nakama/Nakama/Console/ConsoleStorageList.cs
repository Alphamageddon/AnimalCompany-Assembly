namespace Nakama.Console;

internal class ConsoleStorageList : IConsoleStorageList
{
	[CompilerGenerated]
	private List<ApiStorageObject> <_objects>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <TotalCount>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "objects")]
	public List<ApiStorageObject> _objects
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IApiStorageObject> Objects
	{
		 get { } //Length: 120
	}

	[DataMember(Name = "total_count")]
	public override int TotalCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ConsoleStorageList() { }

	[CompilerGenerated]
	public List<ApiStorageObject> get__objects() { }

	public override IEnumerable<IApiStorageObject> get_Objects() { }

	[CompilerGenerated]
	public override int get_TotalCount() { }

	[CompilerGenerated]
	public void set__objects(List<ApiStorageObject> value) { }

	[CompilerGenerated]
	public void set_TotalCount(int value) { }

	public virtual string ToString() { }

}

