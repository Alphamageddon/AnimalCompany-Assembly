namespace System.Net.Http.Headers;

public class ProductInfoHeaderValue : ICloneable
{
	[CompilerGenerated]
	private string <Comment>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ProductHeaderValue <Product>k__BackingField; //Field offset: 0x18

	public private string Comment
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ProductHeaderValue Product
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public ProductInfoHeaderValue(ProductHeaderValue product) { }

	private ProductInfoHeaderValue() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Comment() { }

	[CompilerGenerated]
	public ProductHeaderValue get_Product() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_Comment(string value) { }

	[CompilerGenerated]
	private void set_Product(ProductHeaderValue value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

}

