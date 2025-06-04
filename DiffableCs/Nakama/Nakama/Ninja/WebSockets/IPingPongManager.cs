namespace Nakama.Ninja.WebSockets;

internal interface IPingPongManager
{

	public event EventHandler<PongEventArgs> Pong
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Pong(EventHandler<PongEventArgs> value) { }

	[CompilerGenerated]
	public void remove_Pong(EventHandler<PongEventArgs> value) { }

	public Task SendPing(ArraySegment<Byte> payload, CancellationToken cancellation) { }

}

