namespace Fusion.Internal;

public abstract class UnityLinkedListSurrogate : UnitySurrogateBase
{
	private static IElementReaderWriter<T> _readerWriter; //Field offset: 0x0

	public abstract T[] DataProperty
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	private static UnityLinkedListSurrogate`2() { }

	protected UnityLinkedListSurrogate`2() { }

	public abstract T[] get_DataProperty() { }

	public virtual void Init(int capacity) { }

	public virtual void Read(Int32* data, int capacity) { }

	public abstract void set_DataProperty(T[] value) { }

	public virtual void Write(Int32* data, int capacity) { }

}

