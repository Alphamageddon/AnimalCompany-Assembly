namespace Nakama;

internal class ApiStorageObjectList : IApiStorageObjectList
{
	[CompilerGenerated]
	private string <Cursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiStorageObject> <_objects>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "objects")]
	[Preserve]
	public List<ApiStorageObject> _objects
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "cursor")]
	[Preserve]
	public override string Cursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiStorageObject> Objects
	{
		 get { } //Length: 120
	}

	public ApiStorageObjectList() { }

	[CompilerGenerated]
	public List<ApiStorageObject> get__objects() { }

	[CompilerGenerated]
	public override string get_Cursor() { }

	public override IEnumerable<IApiStorageObject> get_Objects() { }

	[CompilerGenerated]
	public void set__objects(List<ApiStorageObject> value) { }

	[CompilerGenerated]
	public void set_Cursor(string value) { }

	public virtual string ToString() { }

}

