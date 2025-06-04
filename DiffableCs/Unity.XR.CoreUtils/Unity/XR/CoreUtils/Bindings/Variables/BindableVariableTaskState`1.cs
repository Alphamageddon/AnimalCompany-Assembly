namespace Unity.XR.CoreUtils.Bindings.Variables;

internal struct BindableVariableTaskState
{
	private readonly TaskCompletionSource<T> m_Tcs; //Field offset: 0x0
	private readonly T m_AwaitState; //Field offset: 0x0
	private readonly IReadOnlyBindableVariable<T> m_BindableVariable; //Field offset: 0x0

	public Task<T> task
	{
		 get { } //Length: 44
	}

	public BindableVariableTaskState`1(IReadOnlyBindableVariable<T> bindableVariable, T awaitState, CancellationToken cancellationToken = null) { }

	private void Await(T state) { }

	private void Cancelled() { }

	public Task<T> get_task() { }

}

