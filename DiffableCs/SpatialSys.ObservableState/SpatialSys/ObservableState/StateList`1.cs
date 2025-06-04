namespace SpatialSys.ObservableState;

[DefaultMember("Item")]
public sealed class StateList : StateObjectBase, IEnumerable, IEnumerable<T>, IStateKeyedCollection<Int32>, IStateList, IStateObject
{
	[CompilerGenerated]
	private sealed class <>c__56
	{
		public static readonly <>c__56<T, V> <>9; //Field offset: 0x0
		public static Func<T, V> <>9__56_0; //Field offset: 0x0

		private static <>c__56`1() { }

		public <>c__56`1() { }

		internal V <ToArrayFromPrimitiveValues>b__56_0(T i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public Predicate<IStateObject> filter; //Field offset: 0x0

		public <>c__DisplayClass57_0() { }

		internal bool <ToJSON>b__0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public object value; //Field offset: 0x0

		public <>c__DisplayClass66_0() { }

		internal bool <Contains>b__0(T p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public object value; //Field offset: 0x0

		public <>c__DisplayClass69_0() { }

		internal bool <Remove>b__0(T p) { }

	}

	[CompilerGenerated]
	private sealed class <get_childStateObjects>d__3 : IEnumerable<IStateObject>, IEnumerable, IEnumerator<IStateObject>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private IStateObject <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public StateList<T> <>4__this; //Field offset: 0x0
		private Enumerator<T> <>7__wrap1; //Field offset: 0x0

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

	private List<T> _items; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 36
		 set { } //Length: 36
	}

	public virtual int childCount
	{
		 get { } //Length: 28
	}

	public virtual IEnumerable<IStateObject> childStateObjects
	{
		[IteratorStateMachine(typeof(<get_childStateObjects>d__3))]
		 get { } //Length: 108
	}

	public int Count
	{
		 get { } //Length: 28
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

	public T Item
	{
		 get { } //Length: 36
	}

	private override IStateObject SpatialSys.ObservableState.IStateList.Item
	{
		private get { } //Length: 36
	}

	public StateList`1(IStateObject parent, string stateName) { }

	public StateList`1() { }

	public T Add() { }

	public void AddMany(int count) { }

	public virtual void ApplyOperation(IStateOperation operation) { }

	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) { }

	public int BinarySearch(T item, IComparer<T> comparer) { }

	public override void Clear() { }

	public override bool Contains(object value) { }

	public bool Contains(T item) { }

	public virtual void CopyTo(IStateObject other) { }

	public bool Exists(Predicate<T> match) { }

	public T Find(Predicate<T> match) { }

	public List<T> FindAll(Predicate<T> match) { }

	public int FindIndex(int startIndex, Predicate<T> match) { }

	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	public int FindIndex(Predicate<T> match) { }

	public T FindLast(Predicate<T> match) { }

	public int FindLastIndex(int startIndex, int count, Predicate<T> match) { }

	public int FindLastIndex(Predicate<T> match) { }

	public int FindLastIndex(int startIndex, Predicate<T> match) { }

	public void ForEach(Action<T> action) { }

	public virtual void FromJSON(JSONNode json) { }

	public int get_Capacity() { }

	public virtual int get_childCount() { }

	[IteratorStateMachine(typeof(<get_childStateObjects>d__3))]
	public virtual IEnumerable<IStateObject> get_childStateObjects() { }

	public int get_Count() { }

	public virtual bool get_isDerivedState() { }

	public virtual bool get_isIndexedCollection() { }

	public virtual bool get_isLeafObject() { }

	public T get_Item(int index) { }

	public List<T> GetRange(int index, int count) { }

	public int IndexOf(T item, int index, int count) { }

	public int IndexOf(T item, int index) { }

	public int IndexOf(T item) { }

	public T Insert(int index) { }

	public void InsertMany(int index, int count) { }

	public int LastIndexOf(T item) { }

	public int LastIndexOf(T item, int index) { }

	public int LastIndexOf(T item, int index, int count) { }

	private bool ListStoresPrimsAndCanAssignValue(object value) { }

	public override void Remove(object value) { }

	public bool Remove(T item) { }

	public int RemoveAll(Predicate<T> match) { }

	public override void RemoveAt(int index) { }

	public void RemoveRange(int index, int count) { }

	public virtual void Reset(bool recursively = true) { }

	public void set_Capacity(int value) { }

	private override IStateObject SpatialSys.ObservableState.IStateList.Add() { }

	private override void SpatialSys.ObservableState.IStateList.AddMany(int count) { }

	private override IStateObject SpatialSys.ObservableState.IStateList.get_Item(int index) { }

	private override IStateObject SpatialSys.ObservableState.IStateList.Insert(int index) { }

	private override void SpatialSys.ObservableState.IStateList.InsertMany(int index, int count) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public T[] ToArray() { }

	public V[] ToArrayFromPrimitiveValues() { }

	public virtual JSONNode ToJSON(Predicate<IStateObject> filter = null, bool includeSyncRate = true) { }

	public virtual bool TryFindChild(object childObjectKey, out IStateObject result) { }

	public override bool TryFindChild(int key, out IStateObject result) { }

}

