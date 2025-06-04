namespace Oculus.Platform.Models;

public class SdkAccount
{
	public readonly SdkAccountType AccountType; //Field offset: 0x10
	public readonly ulong UserId; //Field offset: 0x18

	public SdkAccount(IntPtr o) { }

}

