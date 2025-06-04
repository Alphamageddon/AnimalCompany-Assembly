namespace Fusion;

[IsReadOnly]
public struct NetworkObjectReleaseContext
{
	public readonly NetworkObject Object; //Field offset: 0x0
	public readonly NetworkObjectTypeId TypeId; //Field offset: 0x8
	public readonly bool IsBeingDestroyed; //Field offset: 0x10
	public readonly bool IsNestedObject; //Field offset: 0x11

	public NetworkObjectReleaseContext(NetworkObject obj, NetworkObjectTypeId typeId, bool isBeingDestroyed, bool isNested) { }

	public virtual string ToString() { }

}

