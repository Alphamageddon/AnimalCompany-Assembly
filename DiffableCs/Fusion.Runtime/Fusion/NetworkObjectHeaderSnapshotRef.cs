namespace Fusion;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct NetworkObjectHeaderSnapshotRef
{
	private NetworkObjectHeaderSnapshot _snapshot; //Field offset: 0x0

	public int Bytes
	{
		 get { } //Length: 28
	}

	public NetworkObjectHeader Header
	{
		 get { } //Length: 36
	}

	public ulong SnapshotCRC
	{
		 get { } //Length: 24
	}

	public Tick Tick
	{
		 get { } //Length: 28
	}

	internal NetworkObjectHeader* UnsafePointer
	{
		internal get { } //Length: 28
	}

	public bool Valid
	{
		 get { } //Length: 16
	}

	internal NetworkObjectHeaderSnapshotRef(NetworkObjectHeaderSnapshot snapshot) { }

	public void CopyFrom(NetworkObjectHeader* target) { }

	public void CopyFrom(NetworkObjectHeaderSnapshotRef target) { }

	public void CopyTo(NetworkObjectHeader* target) { }

	public void CopyTo(NetworkObjectHeaderSnapshotRef target) { }

	public int get_Bytes() { }

	public NetworkObjectHeader get_Header() { }

	public ulong get_SnapshotCRC() { }

	public Tick get_Tick() { }

	internal NetworkObjectHeader* get_UnsafePointer() { }

	public bool get_Valid() { }

	internal Int32* GetBehaviourPtr(NetworkBehaviour behaviour) { }

	internal int GetChangedTickForBehaviour(int index) { }

}

