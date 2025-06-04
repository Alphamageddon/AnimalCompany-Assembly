namespace Oculus.Platform.Models;

public class LinkedAccount
{
	public readonly string AccessToken; //Field offset: 0x10
	public readonly ServiceProvider ServiceProvider; //Field offset: 0x18
	public readonly string UserId; //Field offset: 0x20

	public LinkedAccount(IntPtr o) { }

}

