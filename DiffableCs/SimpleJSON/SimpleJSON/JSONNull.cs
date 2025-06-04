namespace SimpleJSON;

public class JSONNull : JSONNode
{
	private static JSONNull m_StaticInstance; //Field offset: 0x0
	public static bool reuseSameInstance; //Field offset: 0x8

	public virtual bool AsBool
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public virtual bool IsNull
	{
		 get { } //Length: 8
	}

	public virtual JSONNodeType Tag
	{
		 get { } //Length: 8
	}

	public virtual string Value
	{
		 get { } //Length: 64
		 set { } //Length: 4
	}

	private static JSONNull() { }

	private JSONNull() { }

	public virtual JSONNode Clone() { }

	public static JSONNull CreateOrGet() { }

	public virtual bool Equals(object obj) { }

	public virtual bool get_AsBool() { }

	public virtual bool get_IsNull() { }

	public virtual JSONNodeType get_Tag() { }

	public virtual string get_Value() { }

	public virtual Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public virtual void SerializeBinary(BinaryWriter aWriter) { }

	public virtual void set_AsBool(bool value) { }

	public virtual void set_Value(string value) { }

	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

