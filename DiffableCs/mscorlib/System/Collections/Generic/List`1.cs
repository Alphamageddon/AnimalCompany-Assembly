namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
public class List : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private List<T> _list; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private T _current; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 136
		}

		internal Enumerator(List<T> list) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private bool MoveNextRare() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private const int DefaultCapacity = 4; //Field offset: 0x0
	private static readonly T[] s_emptyArray; //Field offset: 0x0
	private T[] _items; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 28
		 set { } //Length: 236
	}

	public override int Count
	{
		 get { } //Length: 8
	}

	public override T Item
	{
		 get { } //Length: 84
		 set { } //Length: 100
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 8
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 8
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 112
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 8
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 8
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 52
		private set { } //Length: 344
	}

	private static List`1() { }

	public List`1(IEnumerable<T> collection) { }

	public List`1() { }

	public List`1(int capacity) { }

	public override void Add(T item) { }

	private void AddEnumerable(IEnumerable<T> enumerable) { }

	public void AddRange(IEnumerable<T> collection) { }

	private void AddWithResize(T item) { }

	public ReadOnlyCollection<T> AsReadOnly() { }

	public int BinarySearch(T item) { }

	public int BinarySearch(T item, IComparer<T> comparer) { }

	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public List<TOutput> ConvertAll(Converter<T, TOutput> converter) { }

	public void CopyTo(T[] array) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	private void EnsureCapacity(int min) { }

	public bool Exists(Predicate<T> match) { }

	public T Find(Predicate<T> match) { }

	public List<T> FindAll(Predicate<T> match) { }

	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	public int FindIndex(int startIndex, Predicate<T> match) { }

	public int FindIndex(Predicate<T> match) { }

	public T FindLast(Predicate<T> match) { }

	public int FindLastIndex(int startIndex, int count, Predicate<T> match) { }

	public int FindLastIndex(int startIndex, Predicate<T> match) { }

	public int FindLastIndex(Predicate<T> match) { }

	public void ForEach(Action<T> action) { }

	public int get_Capacity() { }

	public override int get_Count() { }

	public override T get_Item(int index) { }

	public Enumerator<T> GetEnumerator() { }

	public List<T> GetRange(int index, int count) { }

	public int IndexOf(T item, int index, int count) { }

	public int IndexOf(T item, int index) { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	public void InsertRange(int index, IEnumerable<T> collection) { }

	private static bool IsCompatibleObject(object value) { }

	public int LastIndexOf(T item, int index, int count) { }

	public int LastIndexOf(T item, int index) { }

	public int LastIndexOf(T item) { }

	public override bool Remove(T item) { }

	public int RemoveAll(Predicate<T> match) { }

	public override void RemoveAt(int index) { }

	public void RemoveRange(int index, int count) { }

	public void Reverse(int index, int count) { }

	public void Reverse() { }

	public void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	public void Sort(Comparison<T> comparison) { }

	public void Sort(int index, int count, IComparer<T> comparer) { }

	public void Sort(IComparer<T> comparer) { }

	public void Sort() { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object item) { }

	private override bool System.Collections.IList.Contains(object item) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object item) { }

	private override void System.Collections.IList.Insert(int index, object item) { }

	private override void System.Collections.IList.Remove(object item) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	public T[] ToArray() { }

}

