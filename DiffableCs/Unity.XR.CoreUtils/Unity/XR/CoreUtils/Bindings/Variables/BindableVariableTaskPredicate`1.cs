namespace Unity.XR.CoreUtils.Bindings.Variables;

internal struct BindableVariableTaskPredicate
{
	private readonly TaskCompletionSource<T> m_Tcs; //Field offset: 0x0
	private readonly Func<T, Boolean> m_AwaitPredicate; //Field offset: 0x0
	private readonly IReadOnlyBindableVariable<T> m_BindableVariable; //Field offset: 0x0

	public Task<T> Task
	{
		 get { } //Length: 44
	}

	public BindableVariableTaskPredicate`1(IReadOnlyBindableVariable<T> bindableVariable, Func<T, Boolean> awaitPredicate, CancellationToken cancellationToken = null) { }

	private void Await(T state) { }

	private void Cancelled() { }

	public Task<T> get_Task() { }

}

