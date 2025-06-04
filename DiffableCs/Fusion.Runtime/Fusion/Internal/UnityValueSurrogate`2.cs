namespace Fusion.Internal;

public abstract class UnityValueSurrogate : UnitySurrogateBase, IUnityValueSurrogate<T>, IUnitySurrogate
{

	public abstract T DataProperty
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected UnityValueSurrogate`2() { }

	public abstract T get_DataProperty() { }

	public virtual void Init(int capacity) { }

	public virtual void Read(Int32* data, int capacity) { }

	public abstract void set_DataProperty(T value) { }

	public virtual void Write(Int32* data, int capacity) { }

}

