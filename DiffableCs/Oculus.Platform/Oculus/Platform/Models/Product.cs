namespace Oculus.Platform.Models;

public class Product
{
	public readonly string Description; //Field offset: 0x10
	public readonly string FormattedPrice; //Field offset: 0x18
	public readonly string Name; //Field offset: 0x20
	public readonly string Sku; //Field offset: 0x28

	public Product(IntPtr o) { }

}

