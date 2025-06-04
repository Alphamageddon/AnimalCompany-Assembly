namespace SpatialSys.ObservableState;

[DefaultMember("Item")]
public sealed class StatePrimitiveArray : StateObjectBase, IStatePrimitiveArray, IStatePrimitive, IStateObject, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
{
	internal class Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private StatePrimitiveArray<T> _arr; //Field offset: 0x0
		private int _position; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 188
		}

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			private get { } //Length: 156
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 160
		}

		public Enumerator(StatePrimitiveArray<T> array) { }

		public override void Dispose() { }

		public T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private static T[] EMPTY_ARRAY; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Type <valueType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <valueTypeID>k__BackingField; //Field offset: 0x0
	private List<T> _value; //Field offset: 0x0
	private byte _syncRate; //Field offset: 0x0

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
		 get { } //Length: 180
	}

	public override int Length
	{
		 get { } //Length: 40
	}

	private override object SpatialSys.ObservableState.IStatePrimitiveArray.Item
	{
		private get { } //Length: 184
	}

	public override byte syncRate
	{
		 get { } //Length: 8
		 set { } //Length: 320
	}

	private override int System.Collections.Generic.IReadOnlyCollection<T>.Count
	{
		private get { } //Length: 40
	}

	public IReadOnlyList<T> value
	{
		 get { } //Length: 8
		 set { } //Length: 20
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

	private static StatePrimitiveArray`1() { }

	public StatePrimitiveArray`1(IStateObject parent, string stateName) { }

	public StatePrimitiveArray`1() { }

	public override IStateOperation AllocateSetOperationWithCurrentValue(StateOperationPool pool) { }

	public virtual void ApplyOperation(IStateOperation operation) { }

	public override string ContentsToString() { }

	public override string ContentsToString(object value) { }

	public virtual void CopyTo(IStateObject other) { }

	public virtual void FromJSON(JSONNode json) { }

	public virtual int get_childCount() { }

	public virtual IEnumerable<IStateObject> get_childStateObjects() { }

	public virtual bool get_isDerivedState() { }

	public virtual bool get_isIndexedCollection() { }

	public virtual bool get_isLeafObject() { }

	public T get_Item(int index) { }

	public override int get_Length() { }

	public override byte get_syncRate() { }

	public IReadOnlyList<T> get_value() { }

	[CompilerGenerated]
	public override Type get_valueType() { }

	[CompilerGenerated]
	public override int get_valueTypeID() { }

	internal virtual void InternalInitialize(IStateObject parent, string stateName, bool serialize) { }

	public virtual void Reset(bool recursively = true) { }

	public override void set_syncRate(byte value) { }

	public void set_value(IReadOnlyList<T> value) { }

	[CompilerGenerated]
	private void set_valueTypeID(int value) { }

	private void SetValueInternal(IReadOnlyList<T> newValue) { }

	private override object SpatialSys.ObservableState.IStatePrimitive.GetValue() { }

	private override void SpatialSys.ObservableState.IStatePrimitive.SetValue(object value) { }

	private override object SpatialSys.ObservableState.IStatePrimitiveArray.get_Item(int index) { }

	private override object SpatialSys.ObservableState.IStatePrimitiveArray.GetValueAsArray() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override int System.Collections.Generic.IReadOnlyCollection<T>.get_Count() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual JSONNode ToJSON(Predicate<IStateObject> filter = null, bool includeSyncRate = true) { }

	public virtual string ToString() { }

	public virtual bool TryFindChild(object childObjectKey, out IStateObject result) { }

	public override bool ValueEquals(IStatePrimitiveArray other) { }

}

