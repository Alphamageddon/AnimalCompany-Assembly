namespace Unity.XR.CoreUtils.Bindings.Variables;

public abstract class BindableVariableBase : IReadOnlyBindableVariable<T>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public BindableVariableBase<T> <>4__this; //Field offset: 0x0
		public Action<T> callbackReference; //Field offset: 0x0

		public <>c__DisplayClass14_0() { }

		internal void <Subscribe>b__0() { }

		internal void <Subscribe>b__1() { }

	}

	[CompilerGenerated]
	private Action<T> valueUpdated; //Field offset: 0x0
	private T m_InternalValue; //Field offset: 0x0
	private readonly bool m_CheckEquality; //Field offset: 0x0
	private bool m_IsInitialized; //Field offset: 0x0
	private readonly Func<T, T, Boolean> m_EqualityMethod; //Field offset: 0x0
	private int m_BindingCount; //Field offset: 0x0

	private event Action<T> valueUpdated
	{
		[CompilerGenerated]
		private add { } //Length: 172
		[CompilerGenerated]
		private remove { } //Length: 172
	}

	public override int BindingCount
	{
		 get { } //Length: 8
	}

	public override T Value
	{
		 get { } //Length: 8
		 set { } //Length: 72
	}

	protected BindableVariableBase`1(T initialValue = null, bool checkEquality = true, Func<T, T, Boolean> equalityMethod = null, bool startInitialized = false) { }

	[CompilerGenerated]
	private void add_valueUpdated(Action<T> value) { }

	public void BroadcastValue() { }

	private void DecrementReferenceCount() { }

	public override int get_BindingCount() { }

	public override T get_Value() { }

	private void IncrementReferenceCount() { }

	[CompilerGenerated]
	private void remove_valueUpdated(Action<T> value) { }

	public void set_Value(T value) { }

	public bool SetValueWithoutNotify(T value) { }

	public override IEventBinding Subscribe(Action<T> callback) { }

	public override IEventBinding SubscribeAndUpdate(Action<T> callback) { }

	public override Task<T> Task(Func<T, Boolean> awaitPredicate, CancellationToken token = null) { }

	public override Task<T> Task(T awaitState, CancellationToken token = null) { }

	public override void Unsubscribe(Action<T> callback) { }

	public override bool ValueEquals(T other) { }

}

