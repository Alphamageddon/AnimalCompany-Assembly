namespace SimpleJSON;

[DefaultMember("Item")]
public abstract class JSONNode
{
	[CompilerGenerated]
	private sealed class <get_Children>d__43 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private JSONNode <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <get_Children>d__43(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator() { }

		[DebuggerHidden]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_DeepChildren>d__45 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private JSONNode <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public JSONNode <>4__this; //Field offset: 0x28
		private IEnumerator<JSONNode> <>7__wrap1; //Field offset: 0x30
		private IEnumerator<JSONNode> <>7__wrap2; //Field offset: 0x38

		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <get_DeepChildren>d__45(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator() { }

		[DebuggerHidden]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct Enumerator
	{
		private enum Type
		{
			None = 0,
			Array = 1,
			Object = 2,
		}

		private Type type; //Field offset: 0x0
		private Enumerator<String, JSONNode> m_Object; //Field offset: 0x8
		private Enumerator<JSONNode> m_Array; //Field offset: 0x30

		public KeyValuePair<String, JSONNode> Current
		{
			 get { } //Length: 208
		}

		public bool IsValid
		{
			 get { } //Length: 16
		}

		public Enumerator(Enumerator<JSONNode> aArrayEnum) { }

		public Enumerator(Enumerator<String, JSONNode> aDictEnum) { }

		public KeyValuePair<String, JSONNode> get_Current() { }

		public bool get_IsValid() { }

		public bool MoveNext() { }

	}

	internal struct KeyEnumerator
	{
		private Enumerator m_Enumerator; //Field offset: 0x0

		public string Current
		{
			 get { } //Length: 60
		}

		public KeyEnumerator(Enumerator<JSONNode> aArrayEnum) { }

		public KeyEnumerator(Enumerator<String, JSONNode> aDictEnum) { }

		public KeyEnumerator(Enumerator aEnumerator) { }

		public string get_Current() { }

		public KeyEnumerator GetEnumerator() { }

		public bool MoveNext() { }

	}

	internal class LinqEnumerator : IEnumerator<KeyValuePair`2<String, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair`2<String, JSONNode>>, IEnumerable
	{
		private JSONNode m_Node; //Field offset: 0x10
		private Enumerator m_Enumerator; //Field offset: 0x18

		public override KeyValuePair<String, JSONNode> Current
		{
			 get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 100
		}

		internal LinqEnumerator(JSONNode aNode) { }

		public override void Dispose() { }

		public override KeyValuePair<String, JSONNode> get_Current() { }

		public override IEnumerator<KeyValuePair`2<String, JSONNode>> GetEnumerator() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal struct ValueEnumerator
	{
		private Enumerator m_Enumerator; //Field offset: 0x0

		public JSONNode Current
		{
			 get { } //Length: 68
		}

		public ValueEnumerator(Enumerator<JSONNode> aArrayEnum) { }

		public ValueEnumerator(Enumerator<String, JSONNode> aDictEnum) { }

		public ValueEnumerator(Enumerator aEnumerator) { }

		public JSONNode get_Current() { }

		public ValueEnumerator GetEnumerator() { }

		public bool MoveNext() { }

	}

	[ThreadStatic]
	private static StringBuilder m_EscapeBuilder; //Field offset: 0x80000000
	public static bool forceASCII; //Field offset: 0x0
	public static bool longAsString; //Field offset: 0x1
	public static bool allowLineComments; //Field offset: 0x2
	public static byte Color32DefaultAlpha; //Field offset: 0x3
	public static float ColorDefaultAlpha; //Field offset: 0x4
	public static JSONContainerType VectorContainerType; //Field offset: 0x8
	public static JSONContainerType QuaternionContainerType; //Field offset: 0xC
	public static JSONContainerType RectContainerType; //Field offset: 0x10
	public static JSONContainerType ColorContainerType; //Field offset: 0x14

	public override JSONArray AsArray
	{
		 get { } //Length: 120
	}

	public override bool AsBool
	{
		 get { } //Length: 184
		 set { } //Length: 120
	}

	public override byte AsByte
	{
		 get { } //Length: 28
		 set { } //Length: 20
	}

	public override Byte[] AsByteArray
	{
		 get { } //Length: 272
		 set { } //Length: 236
	}

	public override List<Byte> AsByteList
	{
		 get { } //Length: 376
		 set { } //Length: 268
	}

	public override char AsChar
	{
		 get { } //Length: 156
		 set { } //Length: 212
	}

	public override DateTime AsDateTime
	{
		 get { } //Length: 232
		 set { } //Length: 180
	}

	public override decimal AsDecimal
	{
		 get { } //Length: 188
		 set { } //Length: 164
	}

	public override double AsDouble
	{
		 get { } //Length: 164
		 set { } //Length: 136
	}

	public override float AsFloat
	{
		 get { } //Length: 32
		 set { } //Length: 20
	}

	public override Guid AsGuid
	{
		 get { } //Length: 52
		 set { } //Length: 60
	}

	public override int AsInt
	{
		 get { } //Length: 52
		 set { } //Length: 24
	}

	public override long AsLong
	{
		 get { } //Length: 52
		 set { } //Length: 60
	}

	public override JSONObject AsObject
	{
		 get { } //Length: 120
	}

	public override sbyte AsSByte
	{
		 get { } //Length: 28
		 set { } //Length: 20
	}

	public override short AsShort
	{
		 get { } //Length: 28
		 set { } //Length: 20
	}

	public override String[] AsStringArray
	{
		 get { } //Length: 268
		 set { } //Length: 236
	}

	public override List<String> AsStringList
	{
		 get { } //Length: 372
		 set { } //Length: 268
	}

	public override TimeSpan AsTimeSpan
	{
		 get { } //Length: 220
		 set { } //Length: 124
	}

	public override uint AsUInt
	{
		 get { } //Length: 44
		 set { } //Length: 24
	}

	public override ulong AsULong
	{
		 get { } //Length: 52
		 set { } //Length: 60
	}

	public override ushort AsUShort
	{
		 get { } //Length: 28
		 set { } //Length: 20
	}

	public override IEnumerable<JSONNode> Children
	{
		[IteratorStateMachine(typeof(<get_Children>d__43))]
		 get { } //Length: 104
	}

	public override int Count
	{
		 get { } //Length: 8
	}

	public IEnumerable<JSONNode> DeepChildren
	{
		[IteratorStateMachine(typeof(<get_DeepChildren>d__45))]
		 get { } //Length: 112
	}

	internal static StringBuilder EscapeBuilder
	{
		internal get { } //Length: 196
	}

	public override bool Inline
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public override bool IsArray
	{
		 get { } //Length: 8
	}

	public override bool IsBoolean
	{
		 get { } //Length: 8
	}

	public override bool IsNull
	{
		 get { } //Length: 8
	}

	public override bool IsNumber
	{
		 get { } //Length: 8
	}

	public override bool IsObject
	{
		 get { } //Length: 8
	}

	public override bool IsString
	{
		 get { } //Length: 8
	}

	public override JSONNode Item
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public override JSONNode Item
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public KeyEnumerator Keys
	{
		 get { } //Length: 60
	}

	public IEnumerable<KeyValuePair`2<String, JSONNode>> Linq
	{
		 get { } //Length: 88
	}

	public abstract JSONNodeType Tag
	{
		 get { } //Length: 0
	}

	public override string Value
	{
		 get { } //Length: 64
		 set { } //Length: 4
	}

	public ValueEnumerator Values
	{
		 get { } //Length: 60
	}

	private static JSONNode() { }

	protected JSONNode() { }

	public override void Add(JSONNode aItem) { }

	public override void Add(string aKey, JSONNode aItem) { }

	public override void Clear() { }

	public override JSONNode Clone() { }

	public static JSONNode DeserializeBinary(BinaryReader aReader) { }

	public virtual bool Equals(object obj) { }

	internal static string Escape(string aText) { }

	public override JSONArray get_AsArray() { }

	public override bool get_AsBool() { }

	public override byte get_AsByte() { }

	public override Byte[] get_AsByteArray() { }

	public override List<Byte> get_AsByteList() { }

	public override char get_AsChar() { }

	public override DateTime get_AsDateTime() { }

	public override decimal get_AsDecimal() { }

	public override double get_AsDouble() { }

	public override float get_AsFloat() { }

	public override Guid get_AsGuid() { }

	public override int get_AsInt() { }

	public override long get_AsLong() { }

	public override JSONObject get_AsObject() { }

	public override sbyte get_AsSByte() { }

	public override short get_AsShort() { }

	public override String[] get_AsStringArray() { }

	public override List<String> get_AsStringList() { }

	public override TimeSpan get_AsTimeSpan() { }

	public override uint get_AsUInt() { }

	public override ulong get_AsULong() { }

	public override ushort get_AsUShort() { }

	[IteratorStateMachine(typeof(<get_Children>d__43))]
	public override IEnumerable<JSONNode> get_Children() { }

	public override int get_Count() { }

	[IteratorStateMachine(typeof(<get_DeepChildren>d__45))]
	public IEnumerable<JSONNode> get_DeepChildren() { }

	internal static StringBuilder get_EscapeBuilder() { }

	public override bool get_Inline() { }

	public override bool get_IsArray() { }

	public override bool get_IsBoolean() { }

	public override bool get_IsNull() { }

	public override bool get_IsNumber() { }

	public override bool get_IsObject() { }

	public override bool get_IsString() { }

	public override JSONNode get_Item(string aKey) { }

	public override JSONNode get_Item(int aIndex) { }

	public KeyEnumerator get_Keys() { }

	public IEnumerable<KeyValuePair`2<String, JSONNode>> get_Linq() { }

	public abstract JSONNodeType get_Tag() { }

	public override string get_Value() { }

	public ValueEnumerator get_Values() { }

	private static JSONNode GetContainer(JSONContainerType aType) { }

	public abstract Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault) { }

	public override bool HasKey(string aKey) { }

	public static JSONNode LoadFromBinaryBase64(string aBase64) { }

	public static JSONNode LoadFromBinaryFile(string aFileName) { }

	public static JSONNode LoadFromBinaryStream(Stream aData) { }

	public static JSONNode LoadFromCompressedBase64(string aBase64) { }

	public static JSONNode LoadFromCompressedFile(string aFileName) { }

	public static JSONNode LoadFromCompressedStream(Stream aData) { }

	public static bool op_Equality(JSONNode a, object b) { }

	public static JSONNode op_Implicit(List<String> aStringList) { }

	public static String[] op_Implicit(JSONNode aNode) { }

	public static List<String> op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(String[] aStringArray) { }

	public static JSONNode op_Implicit(List<Byte> aByteList) { }

	public static Byte[] op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(Byte[] aByteArray) { }

	public static Guid op_Implicit(JSONNode aNode) { }

	public static TimeSpan op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(TimeSpan aTimeSpan) { }

	public static DateTime op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(DateTime aDateTime) { }

	public static ushort op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(ushort aUShort) { }

	public static short op_Implicit(JSONNode aNode) { }

	public static List<Byte> op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(Guid aGuid) { }

	public static JSONNode op_Implicit(Nullable<Single> aValue) { }

	public static Nullable<Int32> op_Implicit(JSONNode aNode) { }

	public static RectOffset op_Implicit(JSONNode aNode) { }

	public static Rect op_Implicit(JSONNode aNode) { }

	public static Quaternion op_Implicit(JSONNode aNode) { }

	public static Color32 op_Implicit(JSONNode aNode) { }

	public static Color op_Implicit(JSONNode aNode) { }

	public static Vector4 op_Implicit(JSONNode aNode) { }

	public static Vector3 op_Implicit(JSONNode aNode) { }

	public static Vector2 op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(RectOffset aRect) { }

	public static JSONNode op_Implicit(Rect aRect) { }

	public static JSONNode op_Implicit(Quaternion aRot) { }

	public static JSONNode op_Implicit(Color32 aCol) { }

	public static JSONNode op_Implicit(Color aCol) { }

	public static JSONNode op_Implicit(Vector4 aVec) { }

	public static JSONNode op_Implicit(Vector3 aVec) { }

	public static JSONNode op_Implicit(Vector2 aVec) { }

	public static Nullable<Int16> op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(Nullable<Int16> aValue) { }

	public static Nullable<Int64> op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(Nullable<Int64> aValue) { }

	public static Nullable<Boolean> op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(Nullable<Boolean> aValue) { }

	public static Nullable<Double> op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(Nullable<Double> aValue) { }

	public static Nullable<Single> op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(Nullable<Int32> aValue) { }

	public static JSONNode op_Implicit(short aShort) { }

	public static JSONNode op_Implicit(byte aByte) { }

	public static sbyte op_Implicit(JSONNode aNode) { }

	public static int op_Implicit(JSONNode d) { }

	public static decimal op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(string s) { }

	public static JSONNode op_Implicit(decimal aDecimal) { }

	public static string op_Implicit(JSONNode d) { }

	public static JSONNode op_Implicit(double n) { }

	public static double op_Implicit(JSONNode d) { }

	public static JSONNode op_Implicit(char aChar) { }

	public static JSONNode op_Implicit(float n) { }

	public static JSONNode op_Implicit(KeyValuePair<String, JSONNode> aKeyValue) { }

	public static bool op_Implicit(JSONNode d) { }

	public static JSONNode op_Implicit(bool b) { }

	public static ulong op_Implicit(JSONNode d) { }

	public static JSONNode op_Implicit(ulong n) { }

	public static long op_Implicit(JSONNode d) { }

	public static JSONNode op_Implicit(long n) { }

	public static float op_Implicit(JSONNode d) { }

	public static char op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(int n) { }

	public static byte op_Implicit(JSONNode aNode) { }

	public static uint op_Implicit(JSONNode aNode) { }

	public static JSONNode op_Implicit(uint aUInt) { }

	public static JSONNode op_Implicit(sbyte aSByte) { }

	public static bool op_Inequality(JSONNode a, object b) { }

	public static JSONNode Parse(string aJSON) { }

	private static JSONNode ParseElement(string token, bool quoted) { }

	public Color ReadColor(Color aDefault) { }

	public Color ReadColor() { }

	public Color32 ReadColor32() { }

	public Color32 ReadColor32(Color32 aDefault) { }

	public Matrix4x4 ReadMatrix() { }

	public Quaternion ReadQuaternion(Quaternion aDefault) { }

	public Quaternion ReadQuaternion() { }

	public Rect ReadRect() { }

	public Rect ReadRect(Rect aDefault) { }

	public RectOffset ReadRectOffset(RectOffset aDefault) { }

	public RectOffset ReadRectOffset() { }

	public Vector2 ReadVector2(Vector2 aDefault) { }

	public Vector2 ReadVector2() { }

	public Vector2 ReadVector2(string aXName, string aYName) { }

	public Vector3 ReadVector3(Vector3 aDefault) { }

	public Vector3 ReadVector3(string aXName, string aYName, string aZName) { }

	public Vector3 ReadVector3() { }

	public Vector4 ReadVector4(Vector4 aDefault) { }

	public Vector4 ReadVector4() { }

	public override JSONNode Remove(int aIndex) { }

	public override JSONNode Remove(JSONNode aNode) { }

	public override JSONNode Remove(string aKey) { }

	public string SaveToBinaryBase64() { }

	public void SaveToBinaryFile(string aFileName) { }

	public void SaveToBinaryStream(Stream aData) { }

	public string SaveToCompressedBase64() { }

	public void SaveToCompressedFile(string aFileName) { }

	public void SaveToCompressedStream(Stream aData) { }

	public abstract void SerializeBinary(BinaryWriter aWriter) { }

	public override void set_AsBool(bool value) { }

	public override void set_AsByte(byte value) { }

	public override void set_AsByteArray(Byte[] value) { }

	public override void set_AsByteList(List<Byte> value) { }

	public override void set_AsChar(char value) { }

	public override void set_AsDateTime(DateTime value) { }

	public override void set_AsDecimal(decimal value) { }

	public override void set_AsDouble(double value) { }

	public override void set_AsFloat(float value) { }

	public override void set_AsGuid(Guid value) { }

	public override void set_AsInt(int value) { }

	public override void set_AsLong(long value) { }

	public override void set_AsSByte(sbyte value) { }

	public override void set_AsShort(short value) { }

	public override void set_AsStringArray(String[] value) { }

	public override void set_AsStringList(List<String> value) { }

	public override void set_AsTimeSpan(TimeSpan value) { }

	public override void set_AsUInt(uint value) { }

	public override void set_AsULong(ulong value) { }

	public override void set_AsUShort(ushort value) { }

	public override void set_Inline(bool value) { }

	public override void set_Item(string aKey, JSONNode value) { }

	public override void set_Item(int aIndex, JSONNode value) { }

	public override void set_Value(string value) { }

	public virtual string ToString() { }

	public override string ToString(int aIndent) { }

	public JSONNode WriteColor(Color aCol) { }

	public JSONNode WriteColor32(Color32 aCol) { }

	public JSONNode WriteMatrix(Matrix4x4 aMatrix) { }

	public JSONNode WriteQuaternion(Quaternion aRot) { }

	public JSONNode WriteRect(Rect aRect) { }

	public JSONNode WriteRectOffset(RectOffset aRect) { }

	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y") { }

	public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z") { }

	public JSONNode WriteVector4(Vector4 aVec) { }

}

