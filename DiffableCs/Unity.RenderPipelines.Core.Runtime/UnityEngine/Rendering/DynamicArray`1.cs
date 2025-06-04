namespace UnityEngine.Rendering;

[DebuggerDisplay("Size = {size} Capacity = {capacity}")]
[DefaultMember("Item")]
public class DynamicArray
{
	internal struct Iterator
	{
		private readonly DynamicArray<T> owner; //Field offset: 0x0
		private int index; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 72
		}

		public Iterator(DynamicArray<T> setOwner) { }

		public T get_Current() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	internal struct RangeEnumerable
	{
		internal struct RangeIterator
		{
			private readonly DynamicArray<T> owner; //Field offset: 0x0
			private int index; //Field offset: 0x0
			private int first; //Field offset: 0x0
			private int last; //Field offset: 0x0

			public T Current
			{
				 get { } //Length: 72
			}

			public RangeIterator(DynamicArray<T> setOwner, int first, int numItems) { }

			public T get_Current() { }

			public bool MoveNext() { }

			public void Reset() { }

		}

		public RangeIterator<T> iterator; //Field offset: 0x0

		public RangeIterator<T> GetEnumerator() { }

	}

	private T[] m_Array; //Field offset: 0x0
	[CompilerGenerated]
	private int <size>k__BackingField; //Field offset: 0x0

	public int capacity
	{
		 get { } //Length: 28
	}

	public T Item
	{
		 get { } //Length: 48
	}

	public private int size
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public DynamicArray`1() { }

	public DynamicArray`1(int size) { }

	public int Add(in T value) { }

	public void AddRange(DynamicArray<T> array) { }

	internal void BumpVersion() { }

	public void Clear() { }

	public bool Contains(T item) { }

	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	public int get_capacity() { }

	public T get_Item(int index) { }

	[CompilerGenerated]
	public int get_size() { }

	public Iterator<T> GetEnumerator() { }

	public int IndexOf(T item, int index, int count) { }

	public int IndexOf(T item, int index) { }

	public int IndexOf(T item) { }

	public static T[] op_Implicit(DynamicArray<T> array) { }

	public bool Remove(T item) { }

	public void RemoveAt(int index) { }

	public void RemoveRange(int index, int count) { }

	public void Reserve(int newCapacity, bool keepContent = false) { }

	public void Resize(int newSize, bool keepContent = false) { }

	[CompilerGenerated]
	private void set_size(int value) { }

	public RangeEnumerable<T> SubRange(int first, int numItems) { }

}

