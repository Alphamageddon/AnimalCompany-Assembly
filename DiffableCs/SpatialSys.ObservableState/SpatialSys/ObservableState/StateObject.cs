namespace SpatialSys.ObservableState;

public abstract class StateObject : StateObjectBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CustomAttributeData, Boolean> <>9__13_3; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"name", "instance"}])]
		public static Func<ValueTuple`2<String, IStateObject>, String> <>9__13_1; //Field offset: 0x10
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"name", "instance"}])]
		public static Func<ValueTuple`2<String, IStateObject>, IStateObject> <>9__13_2; //Field offset: 0x18
		public static Func<IStateObject, Boolean> <>9__18_0; //Field offset: 0x20
		public static Func<IStateObject, Boolean> <>9__18_1; //Field offset: 0x28
		public static Func<PropertyInfo, Boolean> <>9__20_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <GetChildStatePropertyInfo>b__20_0(PropertyInfo p) { }

		internal string <InternalInitialize>b__13_1(ValueTuple<String, IStateObject> p) { }

		internal IStateObject <InternalInitialize>b__13_2(ValueTuple<String, IStateObject> p) { }

		internal bool <InternalInitialize>b__13_3(CustomAttributeData x) { }

		internal bool <Reset>b__18_0(IStateObject x) { }

		internal bool <Reset>b__18_1(IStateObject x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public StateObject <>4__this; //Field offset: 0x10
		public bool serialize; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal ValueTuple<String, IStateObject> <InternalInitialize>b__0(PropertyInfo p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Predicate<IStateObject> filter; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <ToJSON>b__0(IStateObject x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public JSONNode json; //Field offset: 0x10
		public Func<KeyValuePair`2<String, IStateObject>, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal bool <FromJSON>b__0(KeyValuePair<String, IStateObject> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_1
	{
		public KeyValuePair<String, IStateObject> x; //Field offset: 0x10

		public <>c__DisplayClass16_1() { }

		internal bool <FromJSON>b__1(KeyValuePair<String, JSONNode> y) { }

	}

	[CompilerGenerated]
	private sealed class <get_childStateObjects>d__3 : IEnumerable<IStateObject>, IEnumerable, IEnumerator<IStateObject>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IStateObject <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public StateObject <>4__this; //Field offset: 0x28
		private Enumerator<String, IStateObject> <>7__wrap1; //Field offset: 0x30

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

	protected Dictionary<String, IStateObject> _childStateProperties; //Field offset: 0x40

	public virtual int childCount
	{
		 get { } //Length: 80
	}

	public virtual IEnumerable<IStateObject> childStateObjects
	{
		[IteratorStateMachine(typeof(<get_childStateObjects>d__3))]
		 get { } //Length: 112
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

	protected StateObject() { }

	protected StateObject(IStateObject parent, string stateName) { }

	public virtual void ApplyOperation(IStateOperation operation) { }

	public virtual void CopyTo(IStateObject other) { }

	public virtual void FromJSON(JSONNode json) { }

	public virtual int get_childCount() { }

	[IteratorStateMachine(typeof(<get_childStateObjects>d__3))]
	public virtual IEnumerable<IStateObject> get_childStateObjects() { }

	public virtual bool get_isDerivedState() { }

	public virtual bool get_isIndexedCollection() { }

	public virtual bool get_isLeafObject() { }

	public static IEnumerable<PropertyInfo> GetChildStatePropertyInfo(Type stateObjectType) { }

	internal virtual void InternalInitialize(IStateObject parent, string stateName, bool serialize) { }

	public virtual void Reset(bool recursively = true) { }

	public virtual JSONNode ToJSON(Predicate<IStateObject> filter = null, bool includeSyncRate = true) { }

	public virtual bool TryFindChild(object childObjectKey, out IStateObject result) { }

}

