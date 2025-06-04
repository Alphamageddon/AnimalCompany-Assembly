namespace System.Net.Http.Headers;

public class ContentDispositionHeaderValue : ICloneable
{
	private string dispositionType; //Field offset: 0x10
	private List<NameValueHeaderValue> parameters; //Field offset: 0x18

	public ICollection<NameValueHeaderValue> Parameters
	{
		 get { } //Length: 120
	}

	private ContentDispositionHeaderValue() { }

	protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source) { }

	public virtual bool Equals(object obj) { }

	public ICollection<NameValueHeaderValue> get_Parameters() { }

	public virtual int GetHashCode() { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }

}

