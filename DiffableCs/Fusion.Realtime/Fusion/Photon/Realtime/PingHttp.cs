namespace Fusion.Photon.Realtime;

internal class PingHttp : PhotonPing
{
	private UnityWebRequest webRequest; //Field offset: 0x30

	public PingHttp() { }

	public virtual void Dispose() { }

	public virtual bool Done() { }

	public virtual bool StartPing(string address) { }

}

