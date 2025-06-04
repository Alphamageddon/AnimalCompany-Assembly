namespace SpatialSys.ObservableState;

[DefaultMember("Item")]
public sealed class StateDictionary : StateObjectBase, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IStateKeyedCollection<TKey>, IStateDictionary, IStateObject, IStateDictionary<TKey>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0
		public static Func<TValue> <>9__38_0; //Field offset: 0x0
		public static Func<TValue> <>9__39_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TValue <.ctor>b__38_0() { }

		internal TValue <.ctor>b__39_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public Predicate<IStateObject> filter; //Field offset: 0x0

		public <>c__DisplayClass53_0() { }

		internal bool <ToJSON>b__0(KeyValuePair<TKey, TValue> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public HashSet<TKey> keysInDictionary; //Field offset: 0x0

		public <>c__DisplayClass54_0() { }

		internal bool <FromJSON>b__0(TKey k) { }

	}

	[CompilerGenerated]
	private sealed class <get_childStateObjects>d__3 : IEnumerable<IStateObject>, IEnumerable, IEnumerator<IStateObject>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private IStateObject <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public StateDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		private Enumerator<TKey, TValue> <>7__wrap1; //Field offset: 0x0

		private override IStateObject System.Collections.Generic.IEnumerator<SpatialSys.ObservableState.IStateObject>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <get_childStateObjects>d__3(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<IStateObject> System.Collections.Generic.IEnumerable<SpatialSys.ObservableState.IStateObject>.GetEnumerator() { }

		[DebuggerHidden]
		private override IStateObject System.Collections.Generic.IEnumerator<SpatialSys.ObservableState.IStateObject>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private readonly Type <keyType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <keyTypeID>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Type <valueType>k__BackingField; //Field offset: 0x0
	private Func<TValue> _valueInstanceActivator; //Field offset: 0x0
	private Dictionary<TKey, TValue> _dict; //Field offset: 0x0

	public virtual int childCount
	{
		 get { } //Length: 36
	}

	public virtual IEnumerable<IStateObject> childStateObjects
	{
		[IteratorStateMachine(typeof(<get_childStateObjects>d__3))]
		 get { } //Length: 108
	}

	public int Count
	{
		 get { } //Length: 36
	}

	public virtual bool isDerivedState
	{
		 get { } //Length: 8
	}

	public virtual bool isIndexedCollection
	{
		 get { } //Length: 8
	}

	public virtual bool isLeafObject
	{
		 get { } //Length: 8
	}

	public TValue Item
	{
		 get { } //Length: 36
	}

	public override IStateObject Item
	{
		 get { } //Length: 128
	}

	public KeyCollection<TKey, TValue> Keys
	{
		 get { } //Length: 36
	}

	public override Type keyType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override int keyTypeID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private override ICollection SpatialSys.ObservableState.IStateDictionary.keys
	{
		private get { } //Length: 164
	}

	private override ICollection SpatialSys.ObservableState.IStateDictionary.values
	{
		private get { } //Length: 164
	}

	private override IStateObject SpatialSys.ObservableState.IStateDictionary<TKey>.Item
	{
		private get { } //Length: 36
	}

	public ValueCollection<TKey, TValue> Values
	{
		 get { } //Length: 36
	}

	public override Type valueType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public StateDictionary`2(IStateObject parent, string stateName) { }

	public StateDictionary`2() { }

	[CompilerGenerated]
	private bool <CopyTo>b__58_0(TKey k) { }

	public override IStateObject Add(object key) { }

	public TValue Add(TKey key) { }

	public virtual void ApplyOperation(IStateOperation operation) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	public override bool ContainsKey(object key) { }

	public bool ContainsValue(TValue value) { }

	public virtual void CopyTo(IStateObject other) { }

	public virtual void FromJSON(JSONNode json) { }

	public virtual int get_childCount() { }

	[IteratorStateMachine(typeof(<get_childStateObjects>d__3))]
	public virtual IEnumerable<IStateObject> get_childStateObjects() { }

	public int get_Count() { }

	public virtual bool get_isDerivedState() { }

	public virtual bool get_isIndexedCollection() { }

	public virtual bool get_isLeafObject() { }

	public override IStateObject get_Item(object key) { }

	public TValue get_Item(TKey key) { }

	public KeyCollection<TKey, TValue> get_Keys() { }

	[CompilerGenerated]
	public override Type get_keyType() { }

	[CompilerGenerated]
	public override int get_keyTypeID() { }

	public ValueCollection<TKey, TValue> get_Values() { }

	[CompilerGenerated]
	public override Type get_valueType() { }

	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	public TValue GetOrAddValue(TKey key) { }

	internal virtual void InternalInitialize(IStateObject parent, string stateName, bool serialize) { }

	public override void Remove(object key) { }

	public bool Remove(TKey key) { }

	public void RemoveAll(Predicate<KeyValuePair`2<TKey, TValue>> predicate) { }

	public virtual void Reset(bool recursively = true) { }

	[CompilerGenerated]
	private void set_keyTypeID(int value) { }

	public void SetValueInstanceActivator(Func<TValue> valueActivator) { }

	private override ICollection SpatialSys.ObservableState.IStateDictionary.get_keys() { }

	private override ICollection SpatialSys.ObservableState.IStateDictionary.get_values() { }

	private override IStateObject SpatialSys.ObservableState.IStateDictionary<TKey>.Add(TKey key) { }

	private override IStateObject SpatialSys.ObservableState.IStateDictionary<TKey>.get_Item(TKey key) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual JSONNode ToJSON(Predicate<IStateObject> filter = null, bool includeSyncRate = true) { }

	public virtual bool TryFindChild(object childObjectKey, out IStateObject result) { }

	public override bool TryFindChild(TKey key, out IStateObject child) { }

	public bool TryGetValue(TKey key, out TValue value) { }

	public override bool TryGetValue(object key, out IStateObject value) { }

}

