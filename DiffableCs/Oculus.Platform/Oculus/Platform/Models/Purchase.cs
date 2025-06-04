namespace Oculus.Platform.Models;

public class Purchase
{
	public readonly string DeveloperPayload; //Field offset: 0x10
	public readonly DateTime ExpirationTime; //Field offset: 0x18
	public readonly DateTime GrantTime; //Field offset: 0x20
	public readonly string ID; //Field offset: 0x28
	public readonly string ReportingId; //Field offset: 0x30
	public readonly string Sku; //Field offset: 0x38

	public Purchase(IntPtr o) { }

}

