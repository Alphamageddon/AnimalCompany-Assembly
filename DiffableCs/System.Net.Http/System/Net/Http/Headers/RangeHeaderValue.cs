namespace System.Net.Http.Headers;

public class RangeHeaderValue : ICloneable
{
	private List<RangeItemHeaderValue> ranges; //Field offset: 0x10
	private string unit; //Field offset: 0x18

	public ICollection<RangeItemHeaderValue> Ranges
	{
		 get { } //Length: 120
	}

	public string Unit
	{
		 get { } //Length: 8
	}

	public RangeHeaderValue() { }

	private RangeHeaderValue(RangeHeaderValue source) { }

	public virtual bool Equals(object obj) { }

	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	public string get_Unit() { }

	public virtual int GetHashCode() { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

}

