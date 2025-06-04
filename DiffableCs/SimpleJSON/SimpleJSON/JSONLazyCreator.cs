namespace SimpleJSON;

[DefaultMember("Item")]
internal class JSONLazyCreator : JSONNode
{
	private JSONNode m_Node; //Field offset: 0x10
	private string m_Key; //Field offset: 0x18

	public virtual JSONArray AsArray
	{
		 get { } //Length: 120
	}

	public virtual bool AsBool
	{
		 get { } //Length: 132
		 set { } //Length: 128
	}

	public virtual double AsDouble
	{
		 get { } //Length: 132
		 set { } //Length: 136
	}

	public virtual float AsFloat
	{
		 get { } //Length: 132
		 set { } //Length: 136
	}

	public virtual int AsInt
	{
		 get { } //Length: 132
		 set { } //Length: 128
	}

	public virtual long AsLong
	{
		 get { } //Length: 260
		 set { } //Length: 296
	}

	public virtual JSONObject AsObject
	{
		 get { } //Length: 120
	}

	public virtual ulong AsULong
	{
		 get { } //Length: 260
		 set { } //Length: 296
	}

	public virtual JSONNode Item
	{
		 get { } //Length: 88
		 set { } //Length: 152
	}

	public virtual JSONNode Item
	{
		 get { } //Length: 104
		 set { } //Length: 168
	}

	public virtual JSONNodeType Tag
	{
		 get { } //Length: 8
	}

	public JSONLazyCreator(JSONNode aNode) { }

	public JSONLazyCreator(JSONNode aNode, string aKey) { }

	public virtual void Add(JSONNode aItem) { }

	public virtual void Add(string aKey, JSONNode aItem) { }

	public virtual bool Equals(object obj) { }

	public virtual JSONArray get_AsArray() { }

	public virtual bool get_AsBool() { }

	public virtual double get_AsDouble() { }

	public virtual float get_AsFloat() { }

	public virtual int get_AsInt() { }

	public virtual long get_AsLong() { }

	public virtual JSONObject get_AsObject() { }

	public virtual ulong get_AsULong() { }

	public virtual JSONNode get_Item(int aIndex) { }

	public virtual JSONNode get_Item(string aKey) { }

	public virtual JSONNodeType get_Tag() { }

	public virtual Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(JSONLazyCreator a, object b) { }

	public static bool op_Inequality(JSONLazyCreator a, object b) { }

	public virtual void SerializeBinary(BinaryWriter aWriter) { }

	private T Set(T aVal) { }

	public virtual void set_AsBool(bool value) { }

	public virtual void set_AsDouble(double value) { }

	public virtual void set_AsFloat(float value) { }

	public virtual void set_AsInt(int value) { }

	public virtual void set_AsLong(long value) { }

	public virtual void set_AsULong(ulong value) { }

	public virtual void set_Item(string aKey, JSONNode value) { }

	public virtual void set_Item(int aIndex, JSONNode value) { }

	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

