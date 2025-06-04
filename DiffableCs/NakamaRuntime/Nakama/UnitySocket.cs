namespace Nakama;

public sealed class UnitySocket : MonoBehaviour, ISocketAdapter
{
	private class QueuedEvent
	{
		private readonly IEnumerable<Delegate> _listeners; //Field offset: 0x10
		private readonly Object[] _eventArgs; //Field offset: 0x18

		public QueuedEvent(IEnumerable<Delegate> listeners, Object[] eventArgs) { }

		public void Dispatch() { }

	}

	private readonly ConcurrentQueue<QueuedEvent> _eventQueue; //Field offset: 0x20
	private readonly List<Action> _connectedHandlers; //Field offset: 0x28
	private readonly List<Action> _closedHandlers; //Field offset: 0x30
	private readonly List<Action`1<Exception>> _errorHandlers; //Field offset: 0x38
	private readonly List<Action`1<ArraySegment`1<Byte>>> _receivedHandlers; //Field offset: 0x40
	private ISocketAdapter _socketAdapter; //Field offset: 0x48

	private override event Action Nakama.ISocketAdapter.Closed
	{
		private add { } //Length: 164
		private remove { } //Length: 88
	}

	private override event Action Nakama.ISocketAdapter.Connected
	{
		private add { } //Length: 164
		private remove { } //Length: 88
	}

	private override event Action<ArraySegment`1<Byte>> Nakama.ISocketAdapter.Received
	{
		private add { } //Length: 164
		private remove { } //Length: 88
	}

	private override event Action<Exception> Nakama.ISocketAdapter.ReceivedError
	{
		private add { } //Length: 164
		private remove { } //Length: 88
	}

	private override bool Nakama.ISocketAdapter.IsConnected
	{
		private get { } //Length: 164
	}

	private override bool Nakama.ISocketAdapter.IsConnecting
	{
		private get { } //Length: 164
	}

	public UnitySocket() { }

	public static UnitySocket Create(ISocketAdapter adapter) { }

	private override void Nakama.ISocketAdapter.add_Closed(Action value) { }

	private override void Nakama.ISocketAdapter.add_Connected(Action value) { }

	private override void Nakama.ISocketAdapter.add_Received(Action<ArraySegment`1<Byte>> value) { }

	private override void Nakama.ISocketAdapter.add_ReceivedError(Action<Exception> value) { }

	private override Task Nakama.ISocketAdapter.CloseAsync() { }

	private override Task Nakama.ISocketAdapter.ConnectAsync(Uri uri, int timeout) { }

	private override bool Nakama.ISocketAdapter.get_IsConnected() { }

	private override bool Nakama.ISocketAdapter.get_IsConnecting() { }

	private override void Nakama.ISocketAdapter.remove_Closed(Action value) { }

	private override void Nakama.ISocketAdapter.remove_Connected(Action value) { }

	private override void Nakama.ISocketAdapter.remove_Received(Action<ArraySegment`1<Byte>> value) { }

	private override void Nakama.ISocketAdapter.remove_ReceivedError(Action<Exception> value) { }

	private override Task Nakama.ISocketAdapter.SendAsync(ArraySegment<Byte> buffer, bool reliable, CancellationToken canceller) { }

	private void OnClosed() { }

	private void OnConnected() { }

	private void OnReceived(ArraySegment<Byte> obj) { }

	private void OnReceivedError(Exception obj) { }

	private void Update() { }

}

