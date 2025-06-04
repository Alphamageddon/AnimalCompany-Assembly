namespace AnimalCompany;

public abstract class BaseSetAction : BaseAction
{
	private Func<AppState, StatePrimitive`1<T>> _filter; //Field offset: 0x0
	private T _value; //Field offset: 0x0

	public BaseSetAction`1(Func<AppState, StatePrimitive`1<T>> filter, T value) { }

	public virtual void Execute(AppState state) { }

	public virtual string ToString() { }

}

