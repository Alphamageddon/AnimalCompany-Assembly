namespace Nakama;

public interface ISocketAdapter
{

	public event Action Closed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action Connected
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<ArraySegment`1<Byte>> Received
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Exception> ReceivedError
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool IsConnected
	{
		 get { } //Length: 0
	}

	public bool IsConnecting
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Closed(Action value) { }

	[CompilerGenerated]
	public void add_Connected(Action value) { }

	[CompilerGenerated]
	public void add_Received(Action<ArraySegment`1<Byte>> value) { }

	[CompilerGenerated]
	public void add_ReceivedError(Action<Exception> value) { }

	public Task CloseAsync() { }

	public Task ConnectAsync(Uri uri, int timeout) { }

	public bool get_IsConnected() { }

	public bool get_IsConnecting() { }

	[CompilerGenerated]
	public void remove_Closed(Action value) { }

	[CompilerGenerated]
	public void remove_Connected(Action value) { }

	[CompilerGenerated]
	public void remove_Received(Action<ArraySegment`1<Byte>> value) { }

	[CompilerGenerated]
	public void remove_ReceivedError(Action<Exception> value) { }

	public Task SendAsync(ArraySegment<Byte> buffer, bool reliable = true, CancellationToken canceller = null) { }

}

