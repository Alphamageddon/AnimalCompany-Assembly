namespace Oculus.Platform.Models;

public class HttpTransferUpdate
{
	public readonly ulong ID; //Field offset: 0x10
	public readonly Byte[] Payload; //Field offset: 0x18
	public readonly bool IsCompleted; //Field offset: 0x20

	public HttpTransferUpdate(IntPtr o) { }

}

