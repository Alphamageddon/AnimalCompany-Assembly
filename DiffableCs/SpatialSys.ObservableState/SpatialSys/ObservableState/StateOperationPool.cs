namespace SpatialSys.ObservableState;

public class StateOperationPool
{
	private List<Queue`1<IStateOperation>> _unallocatedStateOperations; //Field offset: 0x10
	private List<HashSet`1<IStateOperation>> _allocatedStateOperations; //Field offset: 0x18
	private IStateTypeIDManifest _typeIDManifest; //Field offset: 0x20

	public StateOperationPool(IStateTypeIDManifest typeIDManifest) { }

	public IStateOperation AllocateCopy(IStateOperation operation) { }

	public IStateOperation AllocateInstance(IStateObject state, OperationType opType, T param1, int param1TypeID) { }

	public void DeallocateAll() { }

	public void DeallocateInstance(IStateOperation operation) { }

	private void GetPoolForType(int typeID, out Queue<IStateOperation>& unallocatedQueue) { }

}

