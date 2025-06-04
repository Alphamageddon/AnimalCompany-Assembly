namespace Oculus.Platform.Models;

public class Destination
{
	public readonly string ApiName; //Field offset: 0x10
	public readonly string DeeplinkMessage; //Field offset: 0x18
	public readonly string DisplayName; //Field offset: 0x20
	public readonly string ShareableUri; //Field offset: 0x28

	public Destination(IntPtr o) { }

}

