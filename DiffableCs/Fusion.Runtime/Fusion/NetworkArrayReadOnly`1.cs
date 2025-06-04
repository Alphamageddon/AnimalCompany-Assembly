namespace Fusion;

[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct NetworkArrayReadOnly
{
	private readonly Byte* _array; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0
	private readonly IElementReaderWriter<T> _readerWriter; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 232
	}

	public int Length
	{
		 get { } //Length: 8
	}

	internal NetworkArrayReadOnly`1(Byte* array, int length, IElementReaderWriter<T> readerWriter) { }

	public T get_Item(int index) { }

	public int get_Length() { }

}

