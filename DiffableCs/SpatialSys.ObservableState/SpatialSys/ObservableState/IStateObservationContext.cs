namespace SpatialSys.ObservableState;

public interface IStateObservationContext
{

	public bool allowChanges
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public List<IStateOperation> observedOperations
	{
		 get { } //Length: 0
	}

	public void ClearObservedChanges() { }

	public void DeregisterObserver(ObserverDelegate observer) { }

	public bool get_allowChanges() { }

	public List<IStateOperation> get_observedOperations() { }

	public void NotifyObserversAndReset(bool logObservers = true, bool rethrowObserverExceptions = false) { }

	public void RegisterAddOperation(IStateDictionary dict, TKey key, int keyTypeID) { }

	public void RegisterAddOperation(IStatePrimitiveSet set, T value, int valueTypeID) { }

	public void RegisterDeleteOperation(IStateList list, int index) { }

	public void RegisterDerivedStateKeyObserver(IStateObject derivedState, ObserverDelegate observer, object key, ObservationScope scope, IStateObject[] state) { }

	public void RegisterDerivedStateObserver(IStateObject derivedState, ObserverDelegate observer, ObservationScope scope, IStateObject[] state) { }

	public void RegisterDisposeOperation(IStateObject state) { }

	public void RegisterInsertOperation(IStateList list, int index) { }

	public void RegisterKeyObserver(ObserverDelegate observer, object key, ObservationScope scope, IStateDictionary[] dictionaries) { }

	public void RegisterMathAddOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	public void RegisterMathMultiplyOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	public void RegisterObserver(ObserverDelegate observer, ObservationScope scope, IStateObject[] state) { }

	public void RegisterRemoveOperation(IStatePrimitiveSet set, T value, int valueTypeID) { }

	public void RegisterRemoveOperation(IStateDictionary dict, TKey key, int keyTypeID) { }

	public void RegisterSetOperation(IStatePrimitive prim, IReadOnlyList<T> value, int valueTypeID) { }

	public void RegisterSetOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	public void RegisterSetSyncRateOperation(IStatePrimitive prim, byte syncRate) { }

	public void set_allowChanges(bool value) { }

}

