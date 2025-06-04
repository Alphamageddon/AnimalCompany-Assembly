namespace SpatialSys.ObservableState;

public sealed class StatePrimitiveSet : StateObjectBase, IEnumerable<T>, IEnumerable, IStatePrimitiveSet, IStateObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public Predicate<T> match; //Field offset: 0x0

		public <>c__DisplayClass36_0() { }

		internal bool <RemoveWhere>b__0(T x) { }

	}

	[CompilerGenerated]
	private readonly Type <elementType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <elementTypeID>k__BackingField; //Field offset: 0x0
	private HashSet<T> _items; //Field offset: 0x0

	public virtual int childCount
	{
		 get { } //Length: 28
	}

	public virtual IEnumerable<IStateObject> childStateObjects
	{
		 get { } //Length: 140
	}

	public int Count
	{
		 get { } //Length: 28
	}

	public override Type elementType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override int elementTypeID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
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

	public StatePrimitiveSet`1() { }

	public StatePrimitiveSet`1(IStateObject parent, string stateName) { }

	public override void Add(object value) { }

	public bool Add(T item) { }

	public virtual void ApplyOperation(IStateOperation operation) { }

	public bool AssignValues(IReadOnlyList<T> values) { }

	public override void Clear() { }

	public override bool Contains(object value) { }

	public bool Contains(T item) { }

	public virtual void CopyTo(IStateObject other) { }

	public virtual void FromJSON(JSONNode json) { }

	public virtual int get_childCount() { }

	public virtual IEnumerable<IStateObject> get_childStateObjects() { }

	public int get_Count() { }

	[CompilerGenerated]
	public override Type get_elementType() { }

	[CompilerGenerated]
	public override int get_elementTypeID() { }

	public virtual bool get_isDerivedState() { }

	public virtual bool get_isIndexedCollection() { }

	public virtual bool get_isLeafObject() { }

	internal virtual void InternalInitialize(IStateObject parent, string stateName, bool serialize) { }

	public bool IsProperSubsetOf(IEnumerable<T> other) { }

	public bool IsProperSupersetOf(IEnumerable<T> other) { }

	public bool IsSubsetOf(IEnumerable<T> other) { }

	public bool IsSupersetOf(IEnumerable<T> other) { }

	public bool Overlaps(IEnumerable<T> other) { }

	public override void Remove(object value) { }

	public bool Remove(T item) { }

	public int RemoveWhere(Predicate<T> match) { }

	public virtual void Reset(bool recursively = true) { }

	[CompilerGenerated]
	private void set_elementTypeID(int value) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public T[] ToArray() { }

	public virtual JSONNode ToJSON(Predicate<IStateObject> filter = null, bool includeSyncRate = true) { }

	public virtual string ToString() { }

	public virtual bool TryFindChild(object childObjectKey, out IStateObject result) { }

	public string ValuesToString() { }

}

