namespace Photon.Realtime;

public class ErrorInfo
{
	public readonly string Info; //Field offset: 0x10

	public ErrorInfo(EventData eventData) { }

	public virtual string ToString() { }

}

