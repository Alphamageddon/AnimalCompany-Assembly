namespace SimpleJSON;

public class JSONString : JSONNode
{
	private string m_Data; //Field offset: 0x10

	public virtual bool IsString
	{
		 get { } //Length: 8
	}

	public virtual JSONNodeType Tag
	{
		 get { } //Length: 8
	}

	public virtual string Value
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public JSONString(string aData) { }

	public virtual void Clear() { }

	public virtual JSONNode Clone() { }

	public virtual bool Equals(object obj) { }

	public virtual bool get_IsString() { }

	public virtual JSONNodeType get_Tag() { }

	public virtual string get_Value() { }

	public virtual Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public virtual void SerializeBinary(BinaryWriter aWriter) { }

	public virtual void set_Value(string value) { }

	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

