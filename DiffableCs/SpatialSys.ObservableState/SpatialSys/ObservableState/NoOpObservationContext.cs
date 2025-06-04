namespace SpatialSys.ObservableState;

public class NoOpObservationContext : IStateObservationContext
{
	[CompilerGenerated]
	private bool <allowChanges>k__BackingField; //Field offset: 0x10

	public override bool allowChanges
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override List<IStateOperation> observedOperations
	{
		 get { } //Length: 104
	}

	public NoOpObservationContext() { }

	public override void ClearObservedChanges() { }

	public override void DeregisterObserver(ObserverDelegate observer) { }

	[CompilerGenerated]
	public override bool get_allowChanges() { }

	public override List<IStateOperation> get_observedOperations() { }

	public override void NotifyObserversAndReset(bool logObservers = true, bool rethrowObserverExceptions = false) { }

	public override void RegisterAddOperation(IStateDictionary dict, TKey key, int keyTypeID) { }

	public override void RegisterAddOperation(IStatePrimitiveSet set, T value, int valueTypeID) { }

	public override void RegisterDeleteOperation(IStateList list, int index) { }

	public override void RegisterDerivedStateKeyObserver(IStateObject derivedState, ObserverDelegate observer, object key, ObservationScope scope, IStateObject[] state) { }

	public override void RegisterDerivedStateObserver(IStateObject derivedState, ObserverDelegate observer, ObservationScope scope, IStateObject[] state) { }

	public override void RegisterDisposeOperation(IStateObject state) { }

	public override void RegisterInsertOperation(IStateList list, int index) { }

	public override void RegisterKeyObserver(ObserverDelegate observer, object key, ObservationScope scope, IStateDictionary[] dictionaries) { }

	public override void RegisterMathAddOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	public override void RegisterMathMultiplyOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	public override void RegisterObserver(ObserverDelegate observer, ObservationScope scope, IStateObject[] state) { }

	public override void RegisterRemoveOperation(IStateDictionary dict, TKey key, int keyTypeID) { }

	public override void RegisterRemoveOperation(IStatePrimitiveSet set, T value, int valueTypeID) { }

	public override void RegisterSetOperation(IStatePrimitive prim, IReadOnlyList<T> value, int valueTypeID) { }

	public override void RegisterSetOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	public override void RegisterSetSyncRateOperation(IStatePrimitive prim, byte syncRate) { }

	[CompilerGenerated]
	public override void set_allowChanges(bool value) { }

}

