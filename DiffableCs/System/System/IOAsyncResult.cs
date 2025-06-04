namespace System;

internal abstract class IOAsyncResult : IAsyncResult
{
	private AsyncCallback async_callback; //Field offset: 0x10
	private object async_state; //Field offset: 0x18
	private ManualResetEvent wait_handle; //Field offset: 0x20
	private bool completed_synchronously; //Field offset: 0x28
	private bool completed; //Field offset: 0x29

	public AsyncCallback AsyncCallback
	{
		 get { } //Length: 8
	}

	public override object AsyncState
	{
		 get { } //Length: 8
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 280
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool IsCompleted
	{
		 get { } //Length: 8
		 set { } //Length: 216
	}

	protected IOAsyncResult() { }

	protected IOAsyncResult(AsyncCallback async_callback, object async_state) { }

	internal abstract void CompleteDisposed() { }

	public AsyncCallback get_AsyncCallback() { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	public override bool get_CompletedSynchronously() { }

	public override bool get_IsCompleted() { }

	protected void Init(AsyncCallback async_callback, object async_state) { }

	protected void set_CompletedSynchronously(bool value) { }

	protected void set_IsCompleted(bool value) { }

}

