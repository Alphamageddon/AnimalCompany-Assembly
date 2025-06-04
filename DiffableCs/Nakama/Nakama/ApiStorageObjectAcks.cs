namespace Nakama;

internal class ApiStorageObjectAcks : IApiStorageObjectAcks
{
	[CompilerGenerated]
	private List<ApiStorageObjectAck> <_acks>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "acks")]
	[Preserve]
	public List<ApiStorageObjectAck> _acks
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiStorageObjectAck> Acks
	{
		 get { } //Length: 120
	}

	public ApiStorageObjectAcks() { }

	[CompilerGenerated]
	public List<ApiStorageObjectAck> get__acks() { }

	public override IEnumerable<IApiStorageObjectAck> get_Acks() { }

	[CompilerGenerated]
	public void set__acks(List<ApiStorageObjectAck> value) { }

	public virtual string ToString() { }

}

