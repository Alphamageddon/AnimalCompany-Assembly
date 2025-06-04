namespace System.Net.Http.Headers;

public class TransferCodingHeaderValue : ICloneable
{
	internal string value; //Field offset: 0x10
	internal List<NameValueHeaderValue> parameters; //Field offset: 0x18

	public ICollection<NameValueHeaderValue> Parameters
	{
		 get { } //Length: 120
	}

	public string Value
	{
		 get { } //Length: 8
	}

	protected TransferCodingHeaderValue(TransferCodingHeaderValue source) { }

	internal TransferCodingHeaderValue() { }

	public virtual bool Equals(object obj) { }

	public ICollection<NameValueHeaderValue> get_Parameters() { }

	public string get_Value() { }

	public virtual int GetHashCode() { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }

}

