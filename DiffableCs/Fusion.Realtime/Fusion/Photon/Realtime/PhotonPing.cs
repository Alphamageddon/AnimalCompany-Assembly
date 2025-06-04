namespace Fusion.Photon.Realtime;

internal abstract class PhotonPing : IDisposable
{
	private static readonly Random RandomIdProvider; //Field offset: 0x0
	public string DebugString; //Field offset: 0x10
	public bool Successful; //Field offset: 0x18
	protected private bool GotResult; //Field offset: 0x19
	protected private int PingLength; //Field offset: 0x1C
	protected private Byte[] PingBytes; //Field offset: 0x20
	protected private byte PingId; //Field offset: 0x28

	private static PhotonPing() { }

	protected PhotonPing() { }

	public override void Dispose() { }

	public override bool Done() { }

	protected private void Init() { }

	public override bool StartPing(string ip) { }

}

