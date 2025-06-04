namespace Fusion;

public struct NetworkInput
{
	private UInt32* _ptr; //Field offset: 0x0
	private int _wordCount; //Field offset: 0x8

	public UInt32* Data
	{
		 get { } //Length: 20
	}

	public bool IsValid
	{
		 get { } //Length: 16
	}

	internal UInt32* Ptr
	{
		internal get { } //Length: 8
	}

	public Type Type
	{
		 get { } //Length: 32
	}

	internal int TypeKey
	{
		internal get { } //Length: 24
		internal set { } //Length: 16
	}

	public int WordCount
	{
		 get { } //Length: 8
	}

	public bool Convert() { }

	public bool Convert(Type type) { }

	internal static NetworkInput FromRaw(Int32* ptr, int wordCount) { }

	internal static NetworkInput FromRaw(UInt32* ptr, int wordCount) { }

	public T Get() { }

	public UInt32* get_Data() { }

	public bool get_IsValid() { }

	internal UInt32* get_Ptr() { }

	public Type get_Type() { }

	internal int get_TypeKey() { }

	public int get_WordCount() { }

	public bool Is() { }

	public bool Set(T value) { }

	internal bool Set(Type type, Void* value) { }

	internal void set_TypeKey(int value) { }

	public bool TryGet(out T input) { }

	public bool TrySet(T input) { }

}

