namespace Fusion.Photon.Realtime;

internal class ErrorInfo
{
	public readonly string Info; //Field offset: 0x10

	public ErrorInfo(EventData eventData) { }

	public virtual string ToString() { }

}

