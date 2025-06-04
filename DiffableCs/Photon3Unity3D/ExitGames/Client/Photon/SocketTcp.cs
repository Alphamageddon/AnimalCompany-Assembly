namespace ExitGames.Client.Photon;

public class SocketTcp : IPhotonSocket, IDisposable
{
	private Socket sock; //Field offset: 0x58
	private readonly object syncer; //Field offset: 0x60

	[Preserve]
	public SocketTcp(PeerBase npeer) { }

	public virtual bool Connect() { }

	public virtual bool Disconnect() { }

	public override void Dispose() { }

	internal void DnsAndConnect() { }

	protected virtual void Finalize() { }

	public virtual PhotonSocketError Receive(out Byte[] data) { }

	public void ReceiveLoop() { }

	public virtual PhotonSocketError Send(Byte[] data, int length) { }

}

