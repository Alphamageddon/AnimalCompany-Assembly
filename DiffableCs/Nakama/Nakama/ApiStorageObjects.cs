namespace Nakama;

internal class ApiStorageObjects : IApiStorageObjects
{
	[CompilerGenerated]
	private List<ApiStorageObject> <_objects>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "objects")]
	[Preserve]
	public List<ApiStorageObject> _objects
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

	public ApiStorageObjects() { }

	[CompilerGenerated]
	public List<ApiStorageObject> get__objects() { }

	public override IEnumerable<IApiStorageObject> get_Objects() { }

	[CompilerGenerated]
	public void set__objects(List<ApiStorageObject> value) { }

	public virtual string ToString() { }

}

