namespace Oculus.Platform.Models;

public class UserCapability
{
	public readonly string Description; //Field offset: 0x10
	public readonly bool IsEnabled; //Field offset: 0x18
	public readonly string Name; //Field offset: 0x20
	public readonly string ReasonCode; //Field offset: 0x28

	public UserCapability(IntPtr o) { }

}

