namespace Nakama;

internal class ApiReadStorageObjectsRequest : IApiReadStorageObjectsRequest
{
	[CompilerGenerated]
	private List<ApiReadStorageObjectId> <_objectIds>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "object_ids")]
	[Preserve]
	public List<ApiReadStorageObjectId> _objectIds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiReadStorageObjectId> ObjectIds
	{
		 get { } //Length: 120
	}

	public ApiReadStorageObjectsRequest() { }

	[CompilerGenerated]
	public List<ApiReadStorageObjectId> get__objectIds() { }

	public override IEnumerable<IApiReadStorageObjectId> get_ObjectIds() { }

	[CompilerGenerated]
	public void set__objectIds(List<ApiReadStorageObjectId> value) { }

	public virtual string ToString() { }

}

