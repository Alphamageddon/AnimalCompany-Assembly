namespace Fusion;

public interface IAsyncOperation
{

	public event Action<IAsyncOperation> Completed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public ExceptionDispatchInfo Error
	{
		 get { } //Length: 0
	}

	public bool IsDone
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Completed(Action<IAsyncOperation> value) { }

	public ExceptionDispatchInfo get_Error() { }

	public bool get_IsDone() { }

	[CompilerGenerated]
	public void remove_Completed(Action<IAsyncOperation> value) { }

}

