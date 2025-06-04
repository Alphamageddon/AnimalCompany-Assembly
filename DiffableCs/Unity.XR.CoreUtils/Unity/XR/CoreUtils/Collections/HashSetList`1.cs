namespace Unity.XR.CoreUtils.Collections;

[DefaultMember("Item")]
public class HashSetList : ICollection<T>, IEnumerable<T>, IEnumerable, ISerializable, IDeserializationCallback, ISet<T>, IReadOnlyCollection<T>
{
	private readonly List<T> m_InternalList; //Field offset: 0x0
	private readonly HashSet<T> m_InternalHashSet; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 28
	}

	public T Item
	{
		 get { } //Length: 36
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 8
	}

	public HashSetList`1(int capacity = 0) { }

	public override bool Add(T item) { }

	public IReadOnlyList<T> AsList() { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public override void ExceptWith(IEnumerable<T> other) { }

	public override int get_Count() { }

	public T get_Item(int index) { }

	public Enumerator<T> GetEnumerator() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void IntersectWith(IEnumerable<T> other) { }

	public override bool IsProperSubsetOf(IEnumerable<T> other) { }

	public override bool IsProperSupersetOf(IEnumerable<T> other) { }

	public override bool IsSubsetOf(IEnumerable<T> other) { }

	public override bool IsSupersetOf(IEnumerable<T> other) { }

	public override void OnDeserialization(object sender) { }

	public override bool Overlaps(IEnumerable<T> other) { }

	private void RefreshList() { }

	public override bool Remove(T item) { }

	public override bool SetEquals(IEnumerable<T> other) { }

	public override void SymmetricExceptWith(IEnumerable<T> other) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override void UnionWith(IEnumerable<T> other) { }

}

