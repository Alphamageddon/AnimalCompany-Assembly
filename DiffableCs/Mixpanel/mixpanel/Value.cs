namespace mixpanel;

[DefaultMember("Item")]
public class Value : IEnumerable, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Converter<String, Value> <>9__114_0; //Field offset: 0x8
		public static Converter<String, Value> <>9__115_0; //Field offset: 0x10
		public static Converter<Boolean, Value> <>9__117_0; //Field offset: 0x18
		public static Converter<Boolean, Value> <>9__118_0; //Field offset: 0x20
		public static Converter<Single, Value> <>9__120_0; //Field offset: 0x28
		public static Converter<Single, Value> <>9__121_0; //Field offset: 0x30
		public static Converter<Double, Value> <>9__123_0; //Field offset: 0x38
		public static Converter<Double, Value> <>9__124_0; //Field offset: 0x40
		public static Converter<Decimal, Value> <>9__126_0; //Field offset: 0x48
		public static Converter<Decimal, Value> <>9__127_0; //Field offset: 0x50
		public static Converter<Int16, Value> <>9__129_0; //Field offset: 0x58
		public static Converter<Int16, Value> <>9__130_0; //Field offset: 0x60
		public static Converter<Int32, Value> <>9__132_0; //Field offset: 0x68
		public static Converter<Int32, Value> <>9__133_0; //Field offset: 0x70
		public static Converter<Int64, Value> <>9__135_0; //Field offset: 0x78
		public static Converter<Int64, Value> <>9__136_0; //Field offset: 0x80
		public static Converter<UInt16, Value> <>9__138_0; //Field offset: 0x88
		public static Converter<UInt16, Value> <>9__139_0; //Field offset: 0x90
		public static Converter<UInt32, Value> <>9__141_0; //Field offset: 0x98
		public static Converter<UInt32, Value> <>9__142_0; //Field offset: 0xA0
		public static Converter<UInt64, Value> <>9__144_0; //Field offset: 0xA8
		public static Converter<UInt64, Value> <>9__145_0; //Field offset: 0xB0
		public static Converter<SByte, Value> <>9__147_0; //Field offset: 0xB8
		public static Converter<SByte, Value> <>9__148_0; //Field offset: 0xC0
		public static Converter<Byte, Value> <>9__150_0; //Field offset: 0xC8
		public static Converter<Byte, Value> <>9__151_0; //Field offset: 0xD0
		public static Converter<Uri, Value> <>9__153_0; //Field offset: 0xD8
		public static Converter<Uri, Value> <>9__154_0; //Field offset: 0xE0
		public static Converter<Guid, Value> <>9__156_0; //Field offset: 0xE8
		public static Converter<Guid, Value> <>9__157_0; //Field offset: 0xF0
		public static Converter<DateTime, Value> <>9__159_0; //Field offset: 0xF8
		public static Converter<DateTime, Value> <>9__160_0; //Field offset: 0x100
		public static Converter<DateTimeOffset, Value> <>9__162_0; //Field offset: 0x108
		public static Converter<DateTimeOffset, Value> <>9__163_0; //Field offset: 0x110
		public static Converter<TimeSpan, Value> <>9__165_0; //Field offset: 0x118
		public static Converter<TimeSpan, Value> <>9__166_0; //Field offset: 0x120
		public static Converter<Color, Value> <>9__168_0; //Field offset: 0x128
		public static Converter<Color, Value> <>9__169_0; //Field offset: 0x130
		public static Converter<Color32, Value> <>9__171_0; //Field offset: 0x138
		public static Converter<Color32, Value> <>9__172_0; //Field offset: 0x140
		public static Converter<Vector2, Value> <>9__174_0; //Field offset: 0x148
		public static Converter<Vector2, Value> <>9__175_0; //Field offset: 0x150
		public static Converter<Vector3, Value> <>9__177_0; //Field offset: 0x158
		public static Converter<Vector3, Value> <>9__178_0; //Field offset: 0x160
		public static Converter<Vector4, Value> <>9__180_0; //Field offset: 0x168
		public static Converter<Vector4, Value> <>9__181_0; //Field offset: 0x170
		public static Converter<Quaternion, Value> <>9__183_0; //Field offset: 0x178
		public static Converter<Quaternion, Value> <>9__184_0; //Field offset: 0x180
		public static Converter<Bounds, Value> <>9__186_0; //Field offset: 0x188
		public static Converter<Bounds, Value> <>9__187_0; //Field offset: 0x190
		public static Converter<Rect, Value> <>9__189_0; //Field offset: 0x198
		public static Converter<Rect, Value> <>9__190_0; //Field offset: 0x1A0
		public static Converter<Value, String> <>9__192_0; //Field offset: 0x1A8
		public static Converter<Value, String> <>9__193_0; //Field offset: 0x1B0
		public static Converter<Value, Boolean> <>9__195_0; //Field offset: 0x1B8
		public static Converter<Value, Boolean> <>9__196_0; //Field offset: 0x1C0
		public static Converter<Value, Single> <>9__198_0; //Field offset: 0x1C8
		public static Converter<Value, Single> <>9__199_0; //Field offset: 0x1D0
		public static Converter<Value, Double> <>9__201_0; //Field offset: 0x1D8
		public static Converter<Value, Double> <>9__202_0; //Field offset: 0x1E0
		public static Converter<Value, Decimal> <>9__204_0; //Field offset: 0x1E8
		public static Converter<Value, Decimal> <>9__205_0; //Field offset: 0x1F0
		public static Converter<Value, Int16> <>9__207_0; //Field offset: 0x1F8
		public static Converter<Value, Int16> <>9__208_0; //Field offset: 0x200
		public static Converter<Value, Int32> <>9__210_0; //Field offset: 0x208
		public static Converter<Value, Int32> <>9__211_0; //Field offset: 0x210
		public static Converter<Value, Int64> <>9__213_0; //Field offset: 0x218
		public static Converter<Value, Int64> <>9__214_0; //Field offset: 0x220
		public static Converter<Value, UInt16> <>9__216_0; //Field offset: 0x228
		public static Converter<Value, UInt16> <>9__217_0; //Field offset: 0x230
		public static Converter<Value, UInt32> <>9__219_0; //Field offset: 0x238
		public static Converter<Value, UInt32> <>9__220_0; //Field offset: 0x240
		public static Converter<Value, UInt64> <>9__222_0; //Field offset: 0x248
		public static Converter<Value, UInt64> <>9__223_0; //Field offset: 0x250
		public static Converter<Value, SByte> <>9__225_0; //Field offset: 0x258
		public static Converter<Value, SByte> <>9__226_0; //Field offset: 0x260
		public static Converter<Value, Byte> <>9__228_0; //Field offset: 0x268
		public static Converter<Value, Byte> <>9__229_0; //Field offset: 0x270
		public static Converter<Value, Uri> <>9__231_0; //Field offset: 0x278
		public static Converter<Value, Uri> <>9__232_0; //Field offset: 0x280
		public static Converter<Value, Guid> <>9__234_0; //Field offset: 0x288
		public static Converter<Value, Guid> <>9__235_0; //Field offset: 0x290
		public static Converter<Value, DateTime> <>9__237_0; //Field offset: 0x298
		public static Converter<Value, DateTime> <>9__238_0; //Field offset: 0x2A0
		public static Converter<Value, DateTimeOffset> <>9__240_0; //Field offset: 0x2A8
		public static Converter<Value, DateTimeOffset> <>9__241_0; //Field offset: 0x2B0
		public static Converter<Value, TimeSpan> <>9__243_0; //Field offset: 0x2B8
		public static Converter<Value, TimeSpan> <>9__244_0; //Field offset: 0x2C0
		public static Converter<Value, Color> <>9__246_0; //Field offset: 0x2C8
		public static Converter<Value, Color> <>9__247_0; //Field offset: 0x2D0
		public static Converter<Value, Color32> <>9__249_0; //Field offset: 0x2D8
		public static Converter<Value, Color32> <>9__250_0; //Field offset: 0x2E0
		public static Converter<Value, Vector2> <>9__252_0; //Field offset: 0x2E8
		public static Converter<Value, Vector2> <>9__253_0; //Field offset: 0x2F0
		public static Converter<Value, Vector3> <>9__255_0; //Field offset: 0x2F8
		public static Converter<Value, Vector3> <>9__256_0; //Field offset: 0x300
		public static Converter<Value, Vector4> <>9__258_0; //Field offset: 0x308
		public static Converter<Value, Vector4> <>9__259_0; //Field offset: 0x310
		public static Converter<Value, Quaternion> <>9__261_0; //Field offset: 0x318
		public static Converter<Value, Quaternion> <>9__262_0; //Field offset: 0x320
		public static Converter<Value, Bounds> <>9__264_0; //Field offset: 0x328
		public static Converter<Value, Bounds> <>9__265_0; //Field offset: 0x330
		public static Converter<Value, Rect> <>9__267_0; //Field offset: 0x338
		public static Converter<Value, Rect> <>9__268_0; //Field offset: 0x340

		private static <>c() { }

		public <>c() { }

		internal Value <op_Implicit>b__114_0(string x) { }

		internal Value <op_Implicit>b__115_0(string x) { }

		internal Value <op_Implicit>b__117_0(bool x) { }

		internal Value <op_Implicit>b__118_0(bool x) { }

		internal Value <op_Implicit>b__120_0(float x) { }

		internal Value <op_Implicit>b__121_0(float x) { }

		internal Value <op_Implicit>b__123_0(double x) { }

		internal Value <op_Implicit>b__124_0(double x) { }

		internal Value <op_Implicit>b__126_0(decimal x) { }

		internal Value <op_Implicit>b__127_0(decimal x) { }

		internal Value <op_Implicit>b__129_0(short x) { }

		internal Value <op_Implicit>b__130_0(short x) { }

		internal Value <op_Implicit>b__132_0(int x) { }

		internal Value <op_Implicit>b__133_0(int x) { }

		internal Value <op_Implicit>b__135_0(long x) { }

		internal Value <op_Implicit>b__136_0(long x) { }

		internal Value <op_Implicit>b__138_0(ushort x) { }

		internal Value <op_Implicit>b__139_0(ushort x) { }

		internal Value <op_Implicit>b__141_0(uint x) { }

		internal Value <op_Implicit>b__142_0(uint x) { }

		internal Value <op_Implicit>b__144_0(ulong x) { }

		internal Value <op_Implicit>b__145_0(ulong x) { }

		internal Value <op_Implicit>b__147_0(sbyte x) { }

		internal Value <op_Implicit>b__148_0(sbyte x) { }

		internal Value <op_Implicit>b__150_0(byte x) { }

		internal Value <op_Implicit>b__151_0(byte x) { }

		internal Value <op_Implicit>b__153_0(Uri x) { }

		internal Value <op_Implicit>b__154_0(Uri x) { }

		internal Value <op_Implicit>b__156_0(Guid x) { }

		internal Value <op_Implicit>b__157_0(Guid x) { }

		internal Value <op_Implicit>b__159_0(DateTime x) { }

		internal Value <op_Implicit>b__160_0(DateTime x) { }

		internal Value <op_Implicit>b__162_0(DateTimeOffset x) { }

		internal Value <op_Implicit>b__163_0(DateTimeOffset x) { }

		internal Value <op_Implicit>b__165_0(TimeSpan x) { }

		internal Value <op_Implicit>b__166_0(TimeSpan x) { }

		internal Value <op_Implicit>b__168_0(Color x) { }

		internal Value <op_Implicit>b__169_0(Color x) { }

		internal Value <op_Implicit>b__171_0(Color32 x) { }

		internal Value <op_Implicit>b__172_0(Color32 x) { }

		internal Value <op_Implicit>b__174_0(Vector2 x) { }

		internal Value <op_Implicit>b__175_0(Vector2 x) { }

		internal Value <op_Implicit>b__177_0(Vector3 x) { }

		internal Value <op_Implicit>b__178_0(Vector3 x) { }

		internal Value <op_Implicit>b__180_0(Vector4 x) { }

		internal Value <op_Implicit>b__181_0(Vector4 x) { }

		internal Value <op_Implicit>b__183_0(Quaternion x) { }

		internal Value <op_Implicit>b__184_0(Quaternion x) { }

		internal Value <op_Implicit>b__186_0(Bounds x) { }

		internal Value <op_Implicit>b__187_0(Bounds x) { }

		internal Value <op_Implicit>b__189_0(Rect x) { }

		internal Value <op_Implicit>b__190_0(Rect x) { }

		internal string <op_Implicit>b__192_0(Value x) { }

		internal string <op_Implicit>b__193_0(Value x) { }

		internal bool <op_Implicit>b__195_0(Value x) { }

		internal bool <op_Implicit>b__196_0(Value x) { }

		internal float <op_Implicit>b__198_0(Value x) { }

		internal float <op_Implicit>b__199_0(Value x) { }

		internal double <op_Implicit>b__201_0(Value x) { }

		internal double <op_Implicit>b__202_0(Value x) { }

		internal decimal <op_Implicit>b__204_0(Value x) { }

		internal decimal <op_Implicit>b__205_0(Value x) { }

		internal short <op_Implicit>b__207_0(Value x) { }

		internal short <op_Implicit>b__208_0(Value x) { }

		internal int <op_Implicit>b__210_0(Value x) { }

		internal int <op_Implicit>b__211_0(Value x) { }

		internal long <op_Implicit>b__213_0(Value x) { }

		internal long <op_Implicit>b__214_0(Value x) { }

		internal ushort <op_Implicit>b__216_0(Value x) { }

		internal ushort <op_Implicit>b__217_0(Value x) { }

		internal uint <op_Implicit>b__219_0(Value x) { }

		internal uint <op_Implicit>b__220_0(Value x) { }

		internal ulong <op_Implicit>b__222_0(Value x) { }

		internal ulong <op_Implicit>b__223_0(Value x) { }

		internal sbyte <op_Implicit>b__225_0(Value x) { }

		internal sbyte <op_Implicit>b__226_0(Value x) { }

		internal byte <op_Implicit>b__228_0(Value x) { }

		internal byte <op_Implicit>b__229_0(Value x) { }

		internal Uri <op_Implicit>b__231_0(Value x) { }

		internal Uri <op_Implicit>b__232_0(Value x) { }

		internal Guid <op_Implicit>b__234_0(Value x) { }

		internal Guid <op_Implicit>b__235_0(Value x) { }

		internal DateTime <op_Implicit>b__237_0(Value x) { }

		internal DateTime <op_Implicit>b__238_0(Value x) { }

		internal DateTimeOffset <op_Implicit>b__240_0(Value x) { }

		internal DateTimeOffset <op_Implicit>b__241_0(Value x) { }

		internal TimeSpan <op_Implicit>b__243_0(Value x) { }

		internal TimeSpan <op_Implicit>b__244_0(Value x) { }

		internal Color <op_Implicit>b__246_0(Value x) { }

		internal Color <op_Implicit>b__247_0(Value x) { }

		internal Color32 <op_Implicit>b__249_0(Value x) { }

		internal Color32 <op_Implicit>b__250_0(Value x) { }

		internal Vector2 <op_Implicit>b__252_0(Value x) { }

		internal Vector2 <op_Implicit>b__253_0(Value x) { }

		internal Vector3 <op_Implicit>b__255_0(Value x) { }

		internal Vector3 <op_Implicit>b__256_0(Value x) { }

		internal Vector4 <op_Implicit>b__258_0(Value x) { }

		internal Vector4 <op_Implicit>b__259_0(Value x) { }

		internal Quaternion <op_Implicit>b__261_0(Value x) { }

		internal Quaternion <op_Implicit>b__262_0(Value x) { }

		internal Bounds <op_Implicit>b__264_0(Value x) { }

		internal Bounds <op_Implicit>b__265_0(Value x) { }

		internal Rect <op_Implicit>b__267_0(Value x) { }

		internal Rect <op_Implicit>b__268_0(Value x) { }

	}

	private enum DataTypes
	{
		UNDEFINED = 0,
		PRIMITIVE = 1,
		CONTAINER = 2,
		URI = 3,
		GUID = 4,
		DATE_TIME = 5,
		DATE_TIME_OFFSET = 6,
		TIME_SPAN = 7,
		COLOR = 8,
		VECTOR = 9,
		QUATERNION = 10,
		BOUNDS = 11,
		RECT = 12,
	}

	private enum Token
	{
		NONE = 0,
		CURLY_OPEN = 1,
		CURLY_CLOSE = 2,
		SQUARED_OPEN = 3,
		SQUARED_CLOSE = 4,
		COLON = 5,
		COMMA = 6,
		STRING = 7,
		NUMBER = 8,
		TRUE = 9,
		FALSE = 10,
		NULL = 11,
	}

	private enum ValueTypes
	{
		UNDEFINED = 0,
		NULL = 1,
		STRING = 2,
		BOOLEAN = 3,
		NUMBER = 4,
		ARRAY = 5,
		OBJECT = 6,
	}

	private const string WhiteSpace = " 	
"; //Field offset: 0x0
	private const string WordBreak = " 	
{}[],:""; //Field offset: 0x0
	[SerializeField]
	private ValueTypes _valueType; //Field offset: 0x10
	[SerializeField]
	private DataTypes _dataType; //Field offset: 0x14
	[SerializeField]
	private string _string; //Field offset: 0x18
	[SerializeField]
	private bool _bool; //Field offset: 0x20
	[SerializeField]
	private double _number; //Field offset: 0x28
	private List<Value> _array; //Field offset: 0x30
	[SerializeField]
	private String[] _arrayData; //Field offset: 0x38
	private Dictionary<String, Value> _container; //Field offset: 0x40
	[SerializeField]
	private String[] _containerKeys; //Field offset: 0x48
	[SerializeField]
	private String[] _containerValues; //Field offset: 0x50

	public static Value Array
	{
		 get { } //Length: 88
	}

	private bool Bool
	{
		private get { } //Length: 8
		private set { } //Length: 24
	}

	private Bounds Bounds
	{
		private get { } //Length: 196
		private set { } //Length: 276
	}

	private Color Color
	{
		private get { } //Length: 240
		private set { } //Length: 388
	}

	private Color32 Color32
	{
		private get { } //Length: 252
		private set { } //Length: 380
	}

	public int Count
	{
		 get { } //Length: 188
	}

	private DateTime DateTime
	{
		private get { } //Length: 104
		private set { } //Length: 192
	}

	private DateTimeOffset DateTimeOffset
	{
		private get { } //Length: 92
		private set { } //Length: 176
	}

	private Guid Guid
	{
		private get { } //Length: 12
		private set { } //Length: 56
	}

	public bool IsArray
	{
		 get { } //Length: 16
	}

	public bool IsNull
	{
		 get { } //Length: 16
	}

	public bool IsObject
	{
		 get { } //Length: 16
	}

	public Value Item
	{
		 get { } //Length: 224
		 set { } //Length: 116
	}

	public Value Item
	{
		 get { } //Length: 88
		 set { } //Length: 116
	}

	public static Value Null
	{
		 get { } //Length: 88
	}

	private double Number
	{
		private get { } //Length: 8
		private set { } //Length: 20
	}

	public static Value Object
	{
		 get { } //Length: 88
	}

	private Quaternion Quaternion
	{
		private get { } //Length: 240
		private set { } //Length: 388
	}

	private Rect Rect
	{
		private get { } //Length: 240
		private set { } //Length: 388
	}

	private string String
	{
		private get { } //Length: 8
		private set { } //Length: 20
	}

	private TimeSpan TimeSpan
	{
		private get { } //Length: 32
		private set { } //Length: 112
	}

	private Uri Uri
	{
		private get { } //Length: 96
		private set { } //Length: 52
	}

	public IEnumerable<Value> Values
	{
		 get { } //Length: 168
	}

	private Vector2 Vector2
	{
		private get { } //Length: 144
		private set { } //Length: 268
	}

	private Vector3 Vector3
	{
		private get { } //Length: 188
		private set { } //Length: 328
	}

	private Vector4 Vector4
	{
		private get { } //Length: 240
		private set { } //Length: 388
	}

	public Value(Vector2 value) { }

	public Value(DateTime value) { }

	public Value(DateTimeOffset value) { }

	public Value(TimeSpan value) { }

	public Value(double value) { }

	public Value(Color value) { }

	public Value(Color32 value) { }

	public Value(bool value) { }

	public Value(Vector3 value) { }

	public Value(Vector4 value) { }

	public Value(Quaternion value) { }

	public Value(Bounds value) { }

	public Value(Guid value) { }

	public Value(Uri value) { }

	public Value(string value) { }

	public Value(Rect value) { }

	public Value(IEnumerable<Value> data) { }

	public Value(IDictionary<String, Value> data) { }

	private Value(ValueTypes valueType, DataTypes dataTypes) { }

	public Value() { }

	public void Add(string key, Value value) { }

	public void Add(Value value) { }

	public bool Contains(int index) { }

	public bool ContainsKey(string key) { }

	public static Value Deserialize(string json) { }

	private void DeserializeDictionary() { }

	private void DeserializeList() { }

	private static void EatWhitespace(StringReader reader) { }

	private static Value FromSerialization(Value valueType, Value dataType, Value value) { }

	public static Value get_Array() { }

	private bool get_Bool() { }

	private Bounds get_Bounds() { }

	private Color get_Color() { }

	private Color32 get_Color32() { }

	public int get_Count() { }

	private DateTime get_DateTime() { }

	private DateTimeOffset get_DateTimeOffset() { }

	private Guid get_Guid() { }

	public bool get_IsArray() { }

	public bool get_IsNull() { }

	public bool get_IsObject() { }

	public Value get_Item(string key) { }

	public Value get_Item(int index) { }

	public static Value get_Null() { }

	private double get_Number() { }

	public static Value get_Object() { }

	private Quaternion get_Quaternion() { }

	private Rect get_Rect() { }

	private string get_String() { }

	private TimeSpan get_TimeSpan() { }

	private Uri get_Uri() { }

	public IEnumerable<Value> get_Values() { }

	private Vector2 get_Vector2() { }

	private Vector3 get_Vector3() { }

	private Vector4 get_Vector4() { }

	public override IEnumerator GetEnumerator() { }

	public void Merge(Value other) { }

	private static char NextChar(StringReader reader) { }

	private static Token NextToken(StringReader reader) { }

	private static string NextWord(StringReader reader) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void OnRecycle() { }

	public static List<UInt16> op_Implicit(Value value) { }

	public static Int16[] op_Implicit(Value value) { }

	public static List<Int16> op_Implicit(Value value) { }

	public static int op_Implicit(Value value) { }

	public static Int32[] op_Implicit(Value value) { }

	public static List<Int32> op_Implicit(Value value) { }

	public static List<UInt64> op_Implicit(Value value) { }

	public static UInt64[] op_Implicit(Value value) { }

	public static ulong op_Implicit(Value value) { }

	public static long op_Implicit(Value value) { }

	public static Int64[] op_Implicit(Value value) { }

	public static List<UInt32> op_Implicit(Value value) { }

	public static List<Int64> op_Implicit(Value value) { }

	public static sbyte op_Implicit(Value value) { }

	public static UInt32[] op_Implicit(Value value) { }

	public static UInt16[] op_Implicit(Value value) { }

	public static short op_Implicit(Value value) { }

	public static uint op_Implicit(Value value) { }

	public static ushort op_Implicit(Value value) { }

	public static List<Single> op_Implicit(Value value) { }

	public static Decimal[] op_Implicit(Value value) { }

	public static Value op_Implicit(List<Bounds> value) { }

	public static Value op_Implicit(Rect value) { }

	public static Value op_Implicit(Rect[] value) { }

	public static Value op_Implicit(List<Rect> value) { }

	public static string op_Implicit(Value value) { }

	public static String[] op_Implicit(Value value) { }

	public static List<String> op_Implicit(Value value) { }

	public static bool op_Implicit(Value value) { }

	public static Boolean[] op_Implicit(Value value) { }

	public static List<Boolean> op_Implicit(Value value) { }

	public static float op_Implicit(Value value) { }

	public static Single[] op_Implicit(Value value) { }

	public static SByte[] op_Implicit(Value value) { }

	public static double op_Implicit(Value value) { }

	public static Double[] op_Implicit(Value value) { }

	public static List<Double> op_Implicit(Value value) { }

	public static decimal op_Implicit(Value value) { }

	public static List<Decimal> op_Implicit(Value value) { }

	public static List<SByte> op_Implicit(Value value) { }

	public static DateTime[] op_Implicit(Value value) { }

	public static Byte[] op_Implicit(Value value) { }

	public static Vector2 op_Implicit(Value value) { }

	public static Vector2[] op_Implicit(Value value) { }

	public static List<Vector2> op_Implicit(Value value) { }

	public static Vector3 op_Implicit(Value value) { }

	public static Vector3[] op_Implicit(Value value) { }

	public static List<Vector3> op_Implicit(Value value) { }

	public static Vector4 op_Implicit(Value value) { }

	public static Vector4[] op_Implicit(Value value) { }

	public static List<Color32> op_Implicit(Value value) { }

	public static List<Vector4> op_Implicit(Value value) { }

	public static Quaternion[] op_Implicit(Value value) { }

	public static List<Quaternion> op_Implicit(Value value) { }

	public static Bounds op_Implicit(Value value) { }

	public static Bounds[] op_Implicit(Value value) { }

	public static List<Bounds> op_Implicit(Value value) { }

	public static Rect op_Implicit(Value value) { }

	public static Rect[] op_Implicit(Value value) { }

	public static List<Rect> op_Implicit(Value value) { }

	public static Quaternion op_Implicit(Value value) { }

	public static byte op_Implicit(Value value) { }

	public static Color32[] op_Implicit(Value value) { }

	public static List<Color> op_Implicit(Value value) { }

	public static List<Byte> op_Implicit(Value value) { }

	public static Uri op_Implicit(Value value) { }

	public static Uri[] op_Implicit(Value value) { }

	public static List<Uri> op_Implicit(Value value) { }

	public static Guid op_Implicit(Value value) { }

	public static Guid[] op_Implicit(Value value) { }

	public static List<Guid> op_Implicit(Value value) { }

	public static DateTime op_Implicit(Value value) { }

	public static Color32 op_Implicit(Value value) { }

	public static Value op_Implicit(Bounds[] value) { }

	public static DateTimeOffset op_Implicit(Value value) { }

	public static DateTimeOffset[] op_Implicit(Value value) { }

	public static List<DateTimeOffset> op_Implicit(Value value) { }

	public static TimeSpan op_Implicit(Value value) { }

	public static TimeSpan[] op_Implicit(Value value) { }

	public static List<TimeSpan> op_Implicit(Value value) { }

	public static Color op_Implicit(Value value) { }

	public static Color[] op_Implicit(Value value) { }

	public static List<DateTime> op_Implicit(Value value) { }

	public static Value op_Implicit(Bounds value) { }

	public static Value op_Implicit(Quaternion[] value) { }

	public static Value op_Implicit(int value) { }

	public static Value op_Implicit(List<Quaternion> value) { }

	public static Value op_Implicit(Int32[] value) { }

	public static Value op_Implicit(List<Int32> value) { }

	public static Value op_Implicit(long value) { }

	public static Value op_Implicit(Int64[] value) { }

	public static Value op_Implicit(List<Int64> value) { }

	public static Value op_Implicit(List<Int16> value) { }

	public static Value op_Implicit(ushort value) { }

	public static Value op_Implicit(List<UInt16> value) { }

	public static Value op_Implicit(uint value) { }

	public static Value op_Implicit(UInt32[] value) { }

	public static Value op_Implicit(List<UInt32> value) { }

	public static Value op_Implicit(ulong value) { }

	public static Value op_Implicit(UInt64[] value) { }

	public static Value op_Implicit(UInt16[] value) { }

	public static Value op_Implicit(List<UInt64> value) { }

	public static Value op_Implicit(Int16[] value) { }

	public static Value op_Implicit(List<Decimal> value) { }

	public static Value op_Implicit(string value) { }

	public static Value op_Implicit(String[] value) { }

	public static Value op_Implicit(List<String> value) { }

	public static Value op_Implicit(bool value) { }

	public static Value op_Implicit(Boolean[] value) { }

	public static Value op_Implicit(List<Boolean> value) { }

	public static Value op_Implicit(short value) { }

	public static Value op_Implicit(float value) { }

	public static Value op_Implicit(List<Single> value) { }

	public static Value op_Implicit(double value) { }

	public static Value op_Implicit(Double[] value) { }

	public static Value op_Implicit(List<Double> value) { }

	public static Value op_Implicit(decimal value) { }

	public static Value op_Implicit(Decimal[] value) { }

	public static Value op_Implicit(Single[] value) { }

	public static Value op_Implicit(sbyte value) { }

	public static Value op_Implicit(List<DateTimeOffset> value) { }

	public static Value op_Implicit(List<SByte> value) { }

	public static Value op_Implicit(List<Color> value) { }

	public static Value op_Implicit(Color32 value) { }

	public static Value op_Implicit(Color32[] value) { }

	public static Value op_Implicit(List<Color32> value) { }

	public static Value op_Implicit(Vector2 value) { }

	public static Value op_Implicit(Vector2[] value) { }

	public static Value op_Implicit(Color[] value) { }

	public static Value op_Implicit(List<Vector2> value) { }

	public static Value op_Implicit(Vector3[] value) { }

	public static Value op_Implicit(List<Vector3> value) { }

	public static Value op_Implicit(Vector4 value) { }

	public static Value op_Implicit(Vector4[] value) { }

	public static Value op_Implicit(List<Vector4> value) { }

	public static Value op_Implicit(SByte[] value) { }

	public static Value op_Implicit(Vector3 value) { }

	public static Value op_Implicit(Color value) { }

	public static Value op_Implicit(Quaternion value) { }

	public static Value op_Implicit(TimeSpan[] value) { }

	public static Value op_Implicit(List<TimeSpan> value) { }

	public static Value op_Implicit(Byte[] value) { }

	public static Value op_Implicit(List<Byte> value) { }

	public static Value op_Implicit(Uri value) { }

	public static Value op_Implicit(Uri[] value) { }

	public static Value op_Implicit(List<Uri> value) { }

	public static Value op_Implicit(Guid value) { }

	public static Value op_Implicit(byte value) { }

	public static Value op_Implicit(List<Guid> value) { }

	public static Value op_Implicit(DateTime value) { }

	public static Value op_Implicit(DateTime[] value) { }

	public static Value op_Implicit(List<DateTime> value) { }

	public static Value op_Implicit(DateTimeOffset value) { }

	public static Value op_Implicit(DateTimeOffset[] value) { }

	public static Value op_Implicit(TimeSpan value) { }

	public static Value op_Implicit(Guid[] value) { }

	private static Value ParseArray(StringReader reader) { }

	private static Value ParseByToken(StringReader reader, Token token) { }

	private static double ParseNumber(StringReader reader) { }

	private static Value ParseObject(StringReader reader) { }

	private static string ParseString(StringReader reader) { }

	private static Value ParseValue(StringReader reader) { }

	private static char PeekChar(StringReader reader) { }

	public void Remove(int index) { }

	public void Remove(string key) { }

	public static string SanitizeStringForJson(string s) { }

	private void SerializeDictionary() { }

	private void SerializeList() { }

	private void set_Bool(bool value) { }

	private void set_Bounds(Bounds value) { }

	private void set_Color(Color value) { }

	private void set_Color32(Color32 value) { }

	private void set_DateTime(DateTime value) { }

	private void set_DateTimeOffset(DateTimeOffset value) { }

	private void set_Guid(Guid value) { }

	public void set_Item(int index, Value value) { }

	public void set_Item(string key, Value value) { }

	private void set_Number(double value) { }

	private void set_Quaternion(Quaternion value) { }

	private void set_Rect(Rect value) { }

	private void set_String(string value) { }

	private void set_TimeSpan(TimeSpan value) { }

	private void set_Uri(Uri value) { }

	private void set_Vector2(Vector2 value) { }

	private void set_Vector3(Vector3 value) { }

	private void set_Vector4(Vector4 value) { }

	public virtual string ToString() { }

	public bool TryGetValue(string key, out Value value) { }

	private void Write(StringWriter writer, bool includeTypeInfo = false) { }

}

