namespace SimpleJSON;

public class JSONBool : JSONNode
{
	private bool m_Data; //Field offset: 0x10

	public virtual bool AsBool
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public virtual bool IsBoolean
	{
		 get { } //Length: 8
	}

	public virtual JSONNodeType Tag
	{
		 get { } //Length: 8
	}

	public virtual string Value
	{
		 get { } //Length: 88
		 set { } //Length: 124
	}

	public JSONBool(bool aData) { }

	public JSONBool(string aData) { }

	public virtual void Clear() { }

	public virtual JSONNode Clone() { }

	public virtual bool Equals(object obj) { }

	public virtual bool get_AsBool() { }

	public virtual bool get_IsBoolean() { }

	public virtual JSONNodeType get_Tag() { }

	public virtual string get_Value() { }

	public virtual Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public virtual void SerializeBinary(BinaryWriter aWriter) { }

	public virtual void set_AsBool(bool value) { }

	public virtual void set_Value(string value) { }

	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

