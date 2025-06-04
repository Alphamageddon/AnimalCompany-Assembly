namespace Fusion;

[DebuggerDisplay("{Value}")]
[DefaultMember("Item")]
[NetworkStructWeaved(1, True)]
public struct NetworkString : INetworkString, INetworkStruct, IEquatable<NetworkString`1<TSize>>, IEnumerable<Char>, IEnumerable
{
	[SerializeField]
	internal int _length; //Field offset: 0x0
	[SerializeField]
	internal TSize _data; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 56
	}

	public uint Item
	{
		 get { } //Length: 188
	}

	public int Length
	{
		 get { } //Length: 64
	}

	private int SafeLength
	{
		private get { } //Length: 396
	}

	public string Value
	{
		 get { } //Length: 128
		 set { } //Length: 136
	}

	public NetworkString`1(string value) { }

	public void Assign(string value) { }

	public int Compare(ref NetworkString<TOtherSize>& other) { }

	public int Compare(NetworkString<TOtherSize> other) { }

	public int Compare(ref NetworkString<TSize>& s) { }

	public int Compare(NetworkString<TSize> s) { }

	public int Compare(string s) { }

	public bool Contains(ref NetworkString<TOtherSize>& str) { }

	public bool Contains(string str) { }

	public bool Contains(uint codePoint) { }

	public bool Contains(char c) { }

	public bool Contains(NetworkString<TOtherSize> str) { }

	public bool EndsWith(string s) { }

	public bool EndsWith(ref NetworkString<TOtherSize>& other) { }

	public override bool Equals(ref NetworkString<TOtherSize>& other) { }

	public bool Equals(NetworkString<TOtherSize> other) { }

	public bool Equals(ref NetworkString<TSize>& other) { }

	public override bool Equals(NetworkString<TSize> other) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(string s) { }

	public bool Get(ref string cache) { }

	public int get_Capacity() { }

	public uint get_Item(int index) { }

	public int get_Length() { }

	private int get_SafeLength() { }

	public string get_Value() { }

	public int GetCharCount() { }

	public CharEnumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public int IndexOf(string str, int startIndex, int count) { }

	public int IndexOf(char c, int startIndex = 0) { }

	public int IndexOf(char c, int startIndex, int count) { }

	public int IndexOf(uint codePoint, int startIndex = 0) { }

	public int IndexOf(uint codePoint, int startIndex, int count) { }

	public int IndexOf(string str, int startIndex = 0) { }

	public int IndexOf(NetworkString<TOtherSize> str, int startIndex = 0) { }

	public int IndexOf(ref NetworkString<TOtherSize>& str, int startIndex, int count) { }

	public int IndexOf(ref NetworkString<TOtherSize>& str, int startIndex = 0) { }

	public int IndexOf(NetworkString<TOtherSize> str, int startIndex, int count) { }

	public static bool op_Equality(NetworkString<TSize> a, string b) { }

	public static bool op_Equality(string a, NetworkString<TSize> b) { }

	public static bool op_Equality(NetworkString<TSize> a, NetworkString<TSize> b) { }

	public static string op_Explicit(NetworkString<TSize> str) { }

	public static NetworkString<TSize> op_Implicit(string str) { }

	public static bool op_Inequality(NetworkString<TSize> a, NetworkString<TSize> b) { }

	public static bool op_Inequality(string a, NetworkString<TSize> b) { }

	public static bool op_Inequality(NetworkString<TSize> a, string b) { }

	private int SafeIndex(int index) { }

	public bool Set(string value) { }

	public void set_Value(string value) { }

	public bool StartsWith(string s) { }

	public bool StartsWith(ref NetworkString<TOtherSize>& other) { }

	public NetworkString<TSize> Substring(int startIndex, int length) { }

	public NetworkString<TSize> Substring(int startIndex) { }

	private override IEnumerator<Char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public NetworkString<TSize> ToLower() { }

	public virtual string ToString() { }

	public NetworkString<TSize> ToUpper() { }

}

