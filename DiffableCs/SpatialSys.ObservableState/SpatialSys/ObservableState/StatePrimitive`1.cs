namespace SpatialSys.ObservableState;

public sealed class StatePrimitive : StateObjectBase, IStatePrimitive, IStateObject, IDerivableState
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<T, T, Boolean> <>9__30_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <InternalInitialize>b__30_0(T a, T b) { }

	}

	[CompilerGenerated]
	private readonly Type <valueType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <valueTypeID>k__BackingField; //Field offset: 0x0
	private T _value; //Field offset: 0x0
	private byte _syncRate; //Field offset: 0x0
	private Operators<T> _operators; //Field offset: 0x0
	private ObserverDelegate _derivedStateObserver; //Field offset: 0x0

	public virtual int childCount
	{
		 get { } //Length: 8
	}

	public virtual IEnumerable<IStateObject> childStateObjects
	{
		 get { } //Length: 140
	}

	public virtual bool isDerivedState
	{
		 get { } //Length: 16
	}

	public virtual bool isIndexedCollection
	{
		 get { } //Length: 8
	}

	public virtual bool isLeafObject
	{
		 get { } //Length: 8
	}

	public override byte syncRate
	{
		 get { } //Length: 8
		 set { } //Length: 320
	}

	public T value
	{
		 get { } //Length: 8
		 set { } //Length: 396
	}

	public override Type valueType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override int valueTypeID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public StatePrimitive`1(IStateObject parent, string stateName) { }

	public StatePrimitive`1() { }

	public void Add(T value) { }

	public override IStateOperation AllocateSetOperationWithCurrentValue(StateOperationPool pool) { }

	public virtual void ApplyOperation(IStateOperation operation) { }

	public virtual void CopyTo(IStateObject other) { }

	public virtual void FromJSON(JSONNode json) { }

	public virtual int get_childCount() { }

	public virtual IEnumerable<IStateObject> get_childStateObjects() { }

	public virtual bool get_isDerivedState() { }

	public virtual bool get_isIndexedCollection() { }

	public virtual bool get_isLeafObject() { }

	public override byte get_syncRate() { }

	public T get_value() { }

	[CompilerGenerated]
	public override Type get_valueType() { }

	[CompilerGenerated]
	public override int get_valueTypeID() { }

	public override object GetValue() { }

	public virtual void InternalDispose() { }

	internal virtual void InternalInitialize(IStateObject parent, string stateName, bool serialize) { }

	public void Multiply(T value) { }

	public static T op_Implicit(StatePrimitive<T> value) { }

	private void RegisterDerivedState(ObserverDelegate observer, ObservationScope scope, IStateObject[] state) { }

	public override void RegisterDerivedState(ObserverDelegate observer, IStateObject[] state) { }

	public override void RegisterDerivedStateChildren(ObserverDelegate observer, IStateObject[] state) { }

	public override void RegisterDerivedStateSelf(ObserverDelegate observer, IStateObject[] state) { }

	public virtual void Reset(bool recursively = true) { }

	public override void set_syncRate(byte value) { }

	public void set_value(T value) { }

	[CompilerGenerated]
	private void set_valueTypeID(int value) { }

	public override void SetValue(object value) { }

	public virtual JSONNode ToJSON(Predicate<IStateObject> filter = null, bool includeSyncRate = true) { }

	public virtual string ToString() { }

	public virtual bool TryFindChild(object childObjectKey, out IStateObject result) { }

}

