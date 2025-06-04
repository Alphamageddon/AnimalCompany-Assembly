namespace Fusion;

public class DynamicHeapInstance
{
	private DynamicHeap* _heap; //Field offset: 0x10

	public DynamicHeapInstance(Type[] types) { }

	public Void* Allocate(int size) { }

	public Void* AllocateArray(int length) { }

	public Void* AllocateArrayPointers(int length) { }

	public Void* AllocateTracked(bool root = false) { }

	public Void* AllocateTrackedArray(int length, bool root = false) { }

	public Void* AllocateTrackedArrayPointers(int length, bool root = false) { }

	protected virtual void Finalize() { }

	public void Free(Void* ptr) { }

	private void VerifyArrayLength(int length) { }

}

