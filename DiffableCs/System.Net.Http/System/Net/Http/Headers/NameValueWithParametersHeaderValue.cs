namespace System.Net.Http.Headers;

public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable
{
	private List<NameValueHeaderValue> parameters; //Field offset: 0x20

	public ICollection<NameValueHeaderValue> Parameters
	{
		 get { } //Length: 120
	}

	protected NameValueWithParametersHeaderValue(NameValueWithParametersHeaderValue source) { }

	private NameValueWithParametersHeaderValue() { }

	public virtual bool Equals(object obj) { }

	public ICollection<NameValueHeaderValue> get_Parameters() { }

	public virtual int GetHashCode() { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }

}

