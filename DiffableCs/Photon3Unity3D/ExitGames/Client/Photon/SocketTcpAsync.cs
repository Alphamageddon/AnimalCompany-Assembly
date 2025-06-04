namespace ExitGames.Client.Photon;

public class SocketTcpAsync : IPhotonSocket, IDisposable
{
	private class ReceiveContext
	{
		public Socket workSocket; //Field offset: 0x10
		public int ReceivedHeaderBytes; //Field offset: 0x18
		public Byte[] HeaderBuffer; //Field offset: 0x20
		public int ExpectedMessageBytes; //Field offset: 0x28
		public int ReceivedMessageBytes; //Field offset: 0x2C
		public Byte[] MessageBuffer; //Field offset: 0x30

		public Byte[] CurrentBuffer
		{
			 get { } //Length: 28
		}

		public int CurrentExpected
		{
			 get { } //Length: 20
		}

		public int CurrentOffset
		{
			 get { } //Length: 28
		}

		public bool ReadingHeader
		{
			 get { } //Length: 16
		}

		public bool ReadingMessage
		{
			 get { } //Length: 16
		}

		public ReceiveContext(Socket socket, Byte[] headerBuffer, Byte[] messageBuffer) { }

		public Byte[] get_CurrentBuffer() { }

		public int get_CurrentExpected() { }

		public int get_CurrentOffset() { }

		public bool get_ReadingHeader() { }

		public bool get_ReadingMessage() { }

		public void Reset() { }

	}

	private Socket sock; //Field offset: 0x58
	private readonly object syncer; //Field offset: 0x60

	[Preserve]
	public SocketTcpAsync(PeerBase npeer) { }

	public virtual bool Connect() { }

	public virtual bool Disconnect() { }

	public override void Dispose() { }

	internal void DnsAndConnect() { }

	protected virtual void Finalize() { }

	public virtual PhotonSocketError Receive(out Byte[] data) { }

	private void ReceiveAsync(ReceiveContext context = null) { }

	private void ReceiveAsync(IAsyncResult ar) { }

	public virtual PhotonSocketError Send(Byte[] data, int length) { }

}

