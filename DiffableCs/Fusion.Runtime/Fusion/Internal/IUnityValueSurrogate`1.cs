namespace Fusion.Internal;

public interface IUnityValueSurrogate : IUnitySurrogate
{

	public T DataProperty
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public T get_DataProperty() { }

	public void set_DataProperty(T value) { }

}

