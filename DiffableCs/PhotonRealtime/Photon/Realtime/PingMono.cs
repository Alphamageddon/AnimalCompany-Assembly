namespace Photon.Realtime;

public class PingMono : PhotonPing
{
	private Socket sock; //Field offset: 0x30

	public PingMono() { }

	public virtual void Dispose() { }

	public virtual bool Done() { }

	public virtual bool StartPing(string ip) { }

}

