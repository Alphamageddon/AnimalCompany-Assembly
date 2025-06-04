namespace SimpleJSON;

public class JSONNumber : JSONNode
{
	private double m_Data; //Field offset: 0x10

	public virtual double AsDouble
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public virtual long AsLong
	{
		 get { } //Length: 32
		 set { } //Length: 12
	}

	public virtual ulong AsULong
	{
		 get { } //Length: 24
		 set { } //Length: 12
	}

	public virtual bool IsNumber
	{
		 get { } //Length: 8
	}

	public virtual JSONNodeType Tag
	{
		 get { } //Length: 8
	}

	public virtual string Value
	{
		 get { } //Length: 104
		 set { } //Length: 168
	}

	public JSONNumber(string aData) { }

	public JSONNumber(double aData) { }

	public virtual void Clear() { }

	public virtual JSONNode Clone() { }

	public virtual bool Equals(object obj) { }

	public virtual double get_AsDouble() { }

	public virtual long get_AsLong() { }

	public virtual ulong get_AsULong() { }

	public virtual bool get_IsNumber() { }

	public virtual JSONNodeType get_Tag() { }

	public virtual string get_Value() { }

	public virtual Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	private static bool IsNumeric(object value) { }

	public virtual void SerializeBinary(BinaryWriter aWriter) { }

	public virtual void set_AsDouble(double value) { }

	public virtual void set_AsLong(long value) { }

	public virtual void set_AsULong(ulong value) { }

	public virtual void set_Value(string value) { }

	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

