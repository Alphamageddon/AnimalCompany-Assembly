namespace ExitGames.Client.Photon;

public class SocketUdpAsync : IPhotonSocket, IDisposable
{
	private Socket sock; //Field offset: 0x58
	private readonly object syncer; //Field offset: 0x60

	[Preserve]
	public SocketUdpAsync(PeerBase npeer) { }

	public virtual bool Connect() { }

	public virtual bool Disconnect() { }

	public override void Dispose() { }

	internal void DnsAndConnect() { }

	protected virtual void Finalize() { }

	private void OnReceive(IAsyncResult ar) { }

	public virtual PhotonSocketError Receive(out Byte[] data) { }

	public virtual PhotonSocketError Send(Byte[] data, int length) { }

	public void StartReceive() { }

}

