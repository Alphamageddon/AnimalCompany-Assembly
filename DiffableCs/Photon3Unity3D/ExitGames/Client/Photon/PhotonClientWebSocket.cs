namespace ExitGames.Client.Photon;

public class PhotonClientWebSocket : IPhotonSocket
{
	private ClientWebSocket clientWebSocket; //Field offset: 0x58
	private Task sendTask; //Field offset: 0x60

	[Preserve]
	public PhotonClientWebSocket(PeerBase peerBase) { }

	private void AsyncConnectAndReceive() { }

	public virtual bool Connect() { }

	public virtual bool Disconnect() { }

	public virtual PhotonSocketError Receive(out Byte[] data) { }

	public virtual PhotonSocketError Send(Byte[] data, int length) { }

}

