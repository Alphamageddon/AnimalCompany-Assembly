namespace Nakama;

internal class ApiDeleteStorageObjectsRequest : IApiDeleteStorageObjectsRequest
{
	[CompilerGenerated]
	private List<ApiDeleteStorageObjectId> <_objectIds>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "object_ids")]
	[Preserve]
	public List<ApiDeleteStorageObjectId> _objectIds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiDeleteStorageObjectId> ObjectIds
	{
		 get { } //Length: 120
	}

	public ApiDeleteStorageObjectsRequest() { }

	[CompilerGenerated]
	public List<ApiDeleteStorageObjectId> get__objectIds() { }

	public override IEnumerable<IApiDeleteStorageObjectId> get_ObjectIds() { }

	[CompilerGenerated]
	public void set__objectIds(List<ApiDeleteStorageObjectId> value) { }

	public virtual string ToString() { }

}

