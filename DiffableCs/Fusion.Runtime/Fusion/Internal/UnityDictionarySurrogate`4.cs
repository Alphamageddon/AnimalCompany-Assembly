namespace Fusion.Internal;

public abstract class UnityDictionarySurrogate : UnitySurrogateBase
{
	private static IElementReaderWriter<TKeyType> _keyReaderWriter; //Field offset: 0x0
	private static IElementReaderWriter<TValueType> _valReaderWriter; //Field offset: 0x0

	public abstract SerializableDictionary<TKeyType, TValueType> DataProperty
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	private static UnityDictionarySurrogate`4() { }

	protected UnityDictionarySurrogate`4() { }

	public abstract SerializableDictionary<TKeyType, TValueType> get_DataProperty() { }

	public virtual void Init(int capacity) { }

	public virtual void Read(Int32* data, int capacity) { }

	public abstract void set_DataProperty(SerializableDictionary<TKeyType, TValueType> value) { }

	public virtual void Write(Int32* data, int capacity) { }

}

