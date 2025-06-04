namespace Fusion;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct NetworkLinkedListReadOnly
{
	private const int COUNT = 0; //Field offset: 0x0
	private const int HEAD = 1; //Field offset: 0x0
	private const int TAIL = 2; //Field offset: 0x0
	private const int PREV = 0; //Field offset: 0x0
	private const int NEXT = 1; //Field offset: 0x0
	private const int INVALID = 0; //Field offset: 0x0
	private const int OFFSET = 1; //Field offset: 0x0
	public const int ELEMENT_WORDS = 2; //Field offset: 0x0
	public const int META_WORDS = 3; //Field offset: 0x0
	private Int32* _data; //Field offset: 0x0
	private int _stride; //Field offset: 0x0
	private int _capacity; //Field offset: 0x0
	private IElementReaderWriter<T> _rw; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 8
	}

	public int Count
	{
		 get { } //Length: 12
	}

	private int Head
	{
		private get { } //Length: 12
	}

	public T Item
	{
		 get { } //Length: 388
	}

	private int Tail
	{
		private get { } //Length: 12
	}

	internal NetworkLinkedListReadOnly`1(Byte* data, int capacity, IElementReaderWriter<T> rw) { }

	public bool Contains(T value) { }

	public bool Contains(T value, IEqualityComparer<T> comparer) { }

	private Int32* Entry(int index) { }

	public T Get(int index) { }

	public int get_Capacity() { }

	public int get_Count() { }

	private int get_Head() { }

	public T get_Item(int index) { }

	private int get_Tail() { }

	private Int32* GetEntryByListIndex(int listIndex) { }

	public int IndexOf(T value) { }

	public int IndexOf(T value, IEqualityComparer<T> equalityComparer) { }

	private T Read(Int32* entry) { }

}

