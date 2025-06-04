namespace SpatialSys.ObservableState;

public class StateObservationContext : IStateObservationContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IStateObject, Boolean> <>9__30_0; //Field offset: 0x8
		public static Func<IStateObject, String> <>9__30_1; //Field offset: 0x10
		public static Func<ObserverData, Int64> <>9__30_2; //Field offset: 0x18
		public static Func<IStateObject, Boolean> <>9__30_3; //Field offset: 0x20
		public static Func<IStateObject, String> <>9__30_4; //Field offset: 0x28
		public static Func<IStateObject, String> <>9__49_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal string <NotifyObserversAndReset>b__49_0(IStateObject s) { }

		internal bool <RegisterObserver>b__30_0(IStateObject s) { }

		internal string <RegisterObserver>b__30_1(IStateObject s) { }

		internal long <RegisterObserver>b__30_2(ObserverData o) { }

		internal bool <RegisterObserver>b__30_3(IStateObject s) { }

		internal string <RegisterObserver>b__30_4(IStateObject s) { }

	}

	private class ObserverData
	{
		[CompilerGenerated]
		private ObserverDelegate <observerMethod>k__BackingField; //Field offset: 0x10
		public ObservationScope scope; //Field offset: 0x18
		public long order; //Field offset: 0x20
		public bool isKeyObserver; //Field offset: 0x28
		public object key; //Field offset: 0x30
		public bool isDerivedStateObserver; //Field offset: 0x38
		public IStateObject derivedState; //Field offset: 0x40
		[CompilerGenerated]
		private HashSet<IStateObject> <observedState>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private HashSet<IStateObject> <inheritedObservedState>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private List<IStateOperation> <pendingOperations>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private bool <disposed>k__BackingField; //Field offset: 0x60

		public private bool disposed
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private HashSet<IStateObject> inheritedObservedState
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public private HashSet<IStateObject> observedState
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public private ObserverDelegate observerMethod
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public private List<IStateOperation> pendingOperations
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public ObserverData(ObserverDelegate observerMethod) { }

		public void Dispose() { }

		[CompilerGenerated]
		public bool get_disposed() { }

		[CompilerGenerated]
		public HashSet<IStateObject> get_inheritedObservedState() { }

		[CompilerGenerated]
		public HashSet<IStateObject> get_observedState() { }

		[CompilerGenerated]
		public ObserverDelegate get_observerMethod() { }

		[CompilerGenerated]
		public List<IStateOperation> get_pendingOperations() { }

		[CompilerGenerated]
		private void set_disposed(bool value) { }

		[CompilerGenerated]
		private void set_inheritedObservedState(HashSet<IStateObject> value) { }

		[CompilerGenerated]
		private void set_observedState(HashSet<IStateObject> value) { }

		[CompilerGenerated]
		private void set_observerMethod(ObserverDelegate value) { }

		[CompilerGenerated]
		private void set_pendingOperations(List<IStateOperation> value) { }

	}

	private class ObserverDataOrderComparer : IComparer<ObserverData>
	{

		public ObserverDataOrderComparer() { }

		public override int Compare(ObserverData x, ObserverData y) { }

	}

	public static int MAX_LOG_LENGTH; //Field offset: 0x0
	[CompilerGenerated]
	private bool <allowChanges>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly List<IStateOperation> <observedOperations>k__BackingField; //Field offset: 0x18
	private HashSet<IStateObject> _changedState; //Field offset: 0x20
	private Dictionary<IStateObject, HashSet`1<ObserverData>> _objectObserverLookup; //Field offset: 0x28
	private Dictionary<ObserverDelegate, ObserverData> _observerDataLookup; //Field offset: 0x30
	private long _observerRegisterOrder; //Field offset: 0x38
	private SortedSet<ObserverData> _pendingObservers; //Field offset: 0x40
	private IReadOnlyList<IStateOperation> _initializeOperations; //Field offset: 0x48
	private StateOperationPool _operationPool; //Field offset: 0x50
	private int _byteTypeID; //Field offset: 0x58
	private int _intTypeID; //Field offset: 0x5C
	private bool _allowChangesToDerivedState; //Field offset: 0x60
	private Queue<SortedSet`1<ObserverData>> _pendingDerivedStateObserverBufferPool; //Field offset: 0x68
	private ILogger _logger; //Field offset: 0x70
	private StringBuilder _logStringBuilder; //Field offset: 0x78

	public override bool allowChanges
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override List<IStateOperation> observedOperations
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	private static StateObservationContext() { }

	public StateObservationContext() { }

	public StateObservationContext(IStateTypeIDManifest typeIDManifest) { }

	public StateObservationContext(IStateTypeIDManifest typeIDManifest, ILogger logger) { }

	private void AddObserverToScope(IStateObject state, ObserverData observer, ObservationScope scope, bool inherited) { }

	private SortedSet<ObserverData> AllocateDerivedStateObserverBuffer() { }

	public override void ClearObservedChanges() { }

	private void DeallocateDerivedStateObserverBuffer(SortedSet<ObserverData> derivedStateObserverBuffer) { }

	public override void DeregisterObserver(ObserverDelegate observer) { }

	[CompilerGenerated]
	public override bool get_allowChanges() { }

	[CompilerGenerated]
	public override List<IStateOperation> get_observedOperations() { }

	public override void NotifyObserversAndReset(bool logObservers = true, bool rethrowObserverExceptions = false) { }

	public override void RegisterAddOperation(IStateDictionary dict, TKey key, int keyTypeID) { }

	public override void RegisterAddOperation(IStatePrimitiveSet set, TKey value, int valueTypeID) { }

	private void RegisterChange(IStateObject state, OperationType opType, T param1, int param1TypeID) { }

	public override void RegisterDeleteOperation(IStateList list, int index) { }

	public override void RegisterDerivedStateKeyObserver(IStateObject derivedState, ObserverDelegate observer, object key, ObservationScope scope, IStateObject[] state) { }

	public override void RegisterDerivedStateObserver(IStateObject derivedState, ObserverDelegate observer, ObservationScope scope, IStateObject[] state) { }

	public override void RegisterDisposeOperation(IStateObject state) { }

	public override void RegisterInsertOperation(IStateList list, int index) { }

	public override void RegisterKeyObserver(ObserverDelegate observer, object key, ObservationScope scope, IStateDictionary[] dictionaries) { }

	public override void RegisterMathAddOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	public override void RegisterMathMultiplyOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	private void RegisterObserver(ObserverDelegate observer, bool isKeyObserver, object key, ObservationScope scope, IStateObject[] state, bool isDerivedStateObserver = false, IStateObject derivedState = null) { }

	public override void RegisterObserver(ObserverDelegate observer, ObservationScope scope, IStateObject[] state) { }

	private void RegisterObserversForNewState(IStateObject parentState, T param1) { }

	public override void RegisterRemoveOperation(IStateDictionary dict, TKey key, int keyTypeID) { }

	public override void RegisterRemoveOperation(IStatePrimitiveSet set, TKey value, int valueTypeID) { }

	public override void RegisterSetOperation(IStatePrimitive prim, IReadOnlyList<T> value, int valueTypeID) { }

	public override void RegisterSetOperation(IStatePrimitive prim, T value, int valueTypeID) { }

	public override void RegisterSetSyncRateOperation(IStatePrimitive prim, byte syncRate) { }

	[CompilerGenerated]
	public override void set_allowChanges(bool value) { }

}

