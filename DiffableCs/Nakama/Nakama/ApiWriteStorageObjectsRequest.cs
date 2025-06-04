namespace Nakama;

internal class ApiWriteStorageObjectsRequest : IApiWriteStorageObjectsRequest
{
	[CompilerGenerated]
	private List<ApiWriteStorageObject> <_objects>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "objects")]
	[Preserve]
	public List<ApiWriteStorageObject> _objects
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiWriteStorageObject> Objects
	{
		 get { } //Length: 120
	}

	public ApiWriteStorageObjectsRequest() { }

	[CompilerGenerated]
	public List<ApiWriteStorageObject> get__objects() { }

	public override IEnumerable<IApiWriteStorageObject> get_Objects() { }

	[CompilerGenerated]
	public void set__objects(List<ApiWriteStorageObject> value) { }

	public virtual string ToString() { }

}

