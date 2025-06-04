namespace Fusion;

public sealed class NetworkObjectSpawnException : Exception
{
	[CompilerGenerated]
	private readonly Nullable<NetworkObjectTypeId> <TypeId>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private readonly NetworkSpawnStatus <Status>k__BackingField; //Field offset: 0x98

	public virtual string Message
	{
		 get { } //Length: 304
	}

	public NetworkSpawnStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Nullable<NetworkObjectTypeId> TypeId
	{
		[CompilerGenerated]
		 get { } //Length: 16
	}

	public NetworkObjectSpawnException(NetworkSpawnStatus status, Nullable<NetworkObjectTypeId> id = null) { }

	public virtual string get_Message() { }

	[CompilerGenerated]
	public NetworkSpawnStatus get_Status() { }

	[CompilerGenerated]
	public Nullable<NetworkObjectTypeId> get_TypeId() { }

}

