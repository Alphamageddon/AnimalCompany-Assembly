namespace Fusion;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
public struct NetworkLinkedList : IEnumerable<T>, IEnumerable, INetworkLinkedList
{
	public class DebuggerProxy
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public NetworkLinkedList<T> list; //Field offset: 0x0

			public <>c__DisplayClass0_0() { }

			internal T[] <.ctor>b__0() { }

		}

		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		public Lazy<T[]> _items; //Field offset: 0x0

		[DebuggerBrowsable(DebuggerBrowsableState::RootHidden (3))]
		public T[] Items
		{
			 get { } //Length: 60
		}

		public DebuggerProxy(NetworkLinkedList<T> list) { }

		public T[] get_Items() { }

	}

	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private bool _first; //Field offset: 0x0
		private int _head; //Field offset: 0x0
		private NetworkLinkedList<T> _list; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 444
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 292
		}

		internal Enumerator(NetworkLinkedList<T> list) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	public const int ELEMENT_WORDS = 2; //Field offset: 0x0
	public const int META_WORDS = 3; //Field offset: 0x0
	private const int COUNT = 0; //Field offset: 0x0
	private const int HEAD = 1; //Field offset: 0x0
	private const int TAIL = 2; //Field offset: 0x0
	private const int PREV = 0; //Field offset: 0x0
	private const int NEXT = 1; //Field offset: 0x0
	private const int INVALID = 0; //Field offset: 0x0
	private const int OFFSET = 1; //Field offset: 0x0
	private Int32* _data; //Field offset: 0x0
	private int _stride; //Field offset: 0x0
	private int _capacity; //Field offset: 0x0
	private IElementReaderWriter<T> _rw; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 8
	}

	public private int Count
	{
		 get { } //Length: 12
		private set { } //Length: 12
	}

	private int Head
	{
		private get { } //Length: 12
		private set { } //Length: 12
	}

	public T Item
	{
		 get { } //Length: 388
		 set { } //Length: 496
	}

	private int Tail
	{
		private get { } //Length: 12
		private set { } //Length: 12
	}

	public NetworkLinkedList`1(Byte* data, int capacity, IElementReaderWriter<T> rw) { }

	public void Add(T value) { }

	public void Clear() { }

	public bool Contains(T value, IEqualityComparer<T> comparer) { }

	public bool Contains(T value) { }

	private Int32* Entry(int index) { }

	private Int32* FindFreeEntry(out int index) { }

	private override void Fusion.INetworkLinkedList.Add(object item) { }

	public T Get(int index) { }

	public int get_Capacity() { }

	public int get_Count() { }

	private int get_Head() { }

	public T get_Item(int index) { }

	private int get_Tail() { }

	private Int32* GetEntryByListIndex(int listIndex) { }

	public Enumerator<T> GetEnumerator() { }

	public int IndexOf(T value) { }

	public int IndexOf(T value, IEqualityComparer<T> equalityComparer) { }

	private T Read(Int32* entry) { }

	public NetworkLinkedList<T> Remap(Void* list) { }

	public bool Remove(T value) { }

	public bool Remove(T value, IEqualityComparer<T> equalityComparer) { }

	private void RemoveEntry(Int32* entry, int entryIndex) { }

	public T Set(int index, T value) { }

	private void set_Count(int value) { }

	private void set_Head(int value) { }

	public void set_Item(int index, T value) { }

	private void set_Tail(int value) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void Write(Int32* entry, T value) { }

}

