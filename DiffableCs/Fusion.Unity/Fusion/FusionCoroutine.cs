namespace Fusion;

public sealed class FusionCoroutine : ICoroutine, IAsyncOperation, IEnumerator, IDisposable
{
	private readonly IEnumerator _inner; //Field offset: 0x10
	private Action<IAsyncOperation> _completed; //Field offset: 0x18
	private float _progress; //Field offset: 0x20
	private Action _activateAsync; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsDone>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ExceptionDispatchInfo <Error>k__BackingField; //Field offset: 0x38

	public override event Action<IAsyncOperation> Completed
	{
		 add { } //Length: 204
		 remove { } //Length: 168
	}

	public private override ExceptionDispatchInfo Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override bool IsDone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 164
	}

	public FusionCoroutine(IEnumerator inner) { }

	public override void add_Completed(Action<IAsyncOperation> value) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public override ExceptionDispatchInfo get_Error() { }

	[CompilerGenerated]
	public override bool get_IsDone() { }

	public override void remove_Completed(Action<IAsyncOperation> value) { }

	[CompilerGenerated]
	private void set_Error(ExceptionDispatchInfo value) { }

	[CompilerGenerated]
	private void set_IsDone(bool value) { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

}

