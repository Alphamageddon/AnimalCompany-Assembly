namespace Unity.XR.CoreUtils.Bindings.Variables;

public interface IReadOnlyBindableVariable
{

	public int BindingCount
	{
		 get { } //Length: 0
	}

	public T Value
	{
		 get { } //Length: 0
	}

	public int get_BindingCount() { }

	public T get_Value() { }

	public IEventBinding Subscribe(Action<T> callback) { }

	public IEventBinding SubscribeAndUpdate(Action<T> callback) { }

	public Task<T> Task(Func<T, Boolean> awaitPredicate, CancellationToken token = null) { }

	public Task<T> Task(T awaitState, CancellationToken token = null) { }

	public void Unsubscribe(Action<T> callback) { }

	public bool ValueEquals(T other) { }

}

