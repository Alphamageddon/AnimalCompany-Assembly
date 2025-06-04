namespace Fusion;

internal class NetworkObjectHeaderSnapshot
{
	internal NetworkObjectHeaderSnapshot Prev; //Field offset: 0x10
	internal NetworkObjectHeaderSnapshot Next; //Field offset: 0x18
	private readonly Allocator* _allocator; //Field offset: 0x20
	public Tick Tick; //Field offset: 0x28
	public int Bytes; //Field offset: 0x2C
	public NetworkObjectHeader* Ptr; //Field offset: 0x30

	public NetworkObjectHeaderSnapshot(Allocator* allocator) { }

	internal ulong BuildCRC() { }

	public NetworkObjectHeaderSnapshot Clone(Simulation simulation) { }

	public void CopyFrom(NetworkObjectHeader* header) { }

	public void CopyFrom(NetworkObjectHeaderSnapshot target) { }

	public void CopyFrom(NetworkObjectHeaderSnapshotRef target) { }

	public void CopyTo(NetworkObjectHeader* header) { }

	public void CopyTo(NetworkObjectHeaderSnapshot target) { }

	public void CopyTo(NetworkObjectHeaderSnapshotRef target) { }

	internal Int32* GetBehaviourPtr(NetworkBehaviour behaviour) { }

	public void Init(NetworkObjectHeader* header, bool copyData) { }

	public void Init(int bytes) { }

	public void Release() { }

}

