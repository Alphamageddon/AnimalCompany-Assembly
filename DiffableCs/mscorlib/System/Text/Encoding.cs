namespace System.Text;

[ComVisible(True)]
public abstract class Encoding : ICloneable
{
	public class DefaultDecoder : Decoder, ISerializable, IObjectReference
	{
		private Encoding m_encoding; //Field offset: 0x20
		private bool m_hasInitializedEncoding; //Field offset: 0x28

		public DefaultDecoder(Encoding encoding) { }

		internal DefaultDecoder(SerializationInfo info, StreamingContext context) { }

		public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

		public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

		public virtual int GetCharCount(Byte* bytes, int count, bool flush) { }

		public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

		public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

		public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

		public override object GetRealObject(StreamingContext context) { }

		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	public class DefaultEncoder : Encoder, ISerializable, IObjectReference
	{
		private Encoding m_encoding; //Field offset: 0x20
		private bool m_hasInitializedEncoding; //Field offset: 0x28
		internal char charLeftOver; //Field offset: 0x2A

		public DefaultEncoder(Encoding encoding) { }

		internal DefaultEncoder(SerializationInfo info, StreamingContext context) { }

		public virtual int GetByteCount(Char[] chars, int index, int count, bool flush) { }

		public virtual int GetByteCount(Char* chars, int count, bool flush) { }

		public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

		public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

		public override object GetRealObject(StreamingContext context) { }

		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	public class EncodingByteBuffer
	{
		private Byte* bytes; //Field offset: 0x10
		private Byte* byteStart; //Field offset: 0x18
		private Byte* byteEnd; //Field offset: 0x20
		private Char* chars; //Field offset: 0x28
		private Char* charStart; //Field offset: 0x30
		private Char* charEnd; //Field offset: 0x38
		private int byteCountResult; //Field offset: 0x40
		private Encoding enc; //Field offset: 0x48
		private EncoderNLS encoder; //Field offset: 0x50
		internal EncoderFallbackBuffer fallbackBuffer; //Field offset: 0x58

		internal int CharsUsed
		{
			internal get { } //Length: 24
		}

		internal int Count
		{
			internal get { } //Length: 8
		}

		internal bool MoreData
		{
			internal get { } //Length: 72
		}

		internal EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, Byte* inByteStart, int inByteCount, Char* inCharStart, int inCharCount) { }

		internal bool AddByte(byte b, int moreBytesExpected) { }

		internal bool AddByte(byte b1) { }

		internal bool AddByte(byte b1, byte b2) { }

		internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

		internal int get_CharsUsed() { }

		internal int get_Count() { }

		internal bool get_MoreData() { }

		internal char GetNextChar() { }

		internal void MovePrevious(bool bThrow) { }

	}

	public class EncodingCharBuffer
	{
		private Char* chars; //Field offset: 0x10
		private Char* charStart; //Field offset: 0x18
		private Char* charEnd; //Field offset: 0x20
		private int charCountResult; //Field offset: 0x28
		private Encoding enc; //Field offset: 0x30
		private DecoderNLS decoder; //Field offset: 0x38
		private Byte* byteStart; //Field offset: 0x40
		private Byte* byteEnd; //Field offset: 0x48
		private Byte* bytes; //Field offset: 0x50
		private DecoderFallbackBuffer fallbackBuffer; //Field offset: 0x58

		internal int BytesUsed
		{
			internal get { } //Length: 16
		}

		internal int Count
		{
			internal get { } //Length: 8
		}

		internal bool MoreData
		{
			internal get { } //Length: 16
		}

		internal EncodingCharBuffer(Encoding enc, DecoderNLS decoder, Char* charStart, int charCount, Byte* byteStart, int byteCount) { }

		internal bool AddChar(char ch, int numBytes) { }

		internal bool AddChar(char ch) { }

		internal void AdjustBytes(int count) { }

		internal bool Fallback(byte fallbackByte) { }

		internal bool Fallback(Byte[] byteBuffer) { }

		internal int get_BytesUsed() { }

		internal int get_Count() { }

		internal bool get_MoreData() { }

		internal byte GetNextByte() { }

	}

	private static Encoding defaultEncoding; //Field offset: 0x0
	private const int ChineseHZ = 52936; //Field offset: 0x0
	private const int DuplicateEUCCN = 51936; //Field offset: 0x0
	private const int EUCCN = 936; //Field offset: 0x0
	private const int EUCKR = 51949; //Field offset: 0x0
	internal const int CodePageASCII = 20127; //Field offset: 0x0
	internal const int ISO_8859_1 = 28591; //Field offset: 0x0
	private const int ISCIIAssemese = 57006; //Field offset: 0x0
	private const int ISCIIBengali = 57003; //Field offset: 0x0
	private const int ISCIIDevanagari = 57002; //Field offset: 0x0
	private const int ISCIIGujarathi = 57010; //Field offset: 0x0
	private const int ISCIIKannada = 57008; //Field offset: 0x0
	private const int ISOSimplifiedCN = 50227; //Field offset: 0x0
	private const int ISCIIMalayalam = 57009; //Field offset: 0x0
	private const int ISCIIPanjabi = 57011; //Field offset: 0x0
	private const int ISCIITamil = 57004; //Field offset: 0x0
	private const int ISCIITelugu = 57005; //Field offset: 0x0
	private const int GB18030 = 54936; //Field offset: 0x0
	private const int ISO_8859_8I = 38598; //Field offset: 0x0
	private const int ISO_8859_8_Visual = 28598; //Field offset: 0x0
	private const int ENC50229 = 50229; //Field offset: 0x0
	private const int CodePageUTF7 = 65000; //Field offset: 0x0
	private const int CodePageUTF8 = 65001; //Field offset: 0x0
	private const int CodePageUTF32 = 12000; //Field offset: 0x0
	private const int CodePageUTF32BE = 12001; //Field offset: 0x0
	private const int ISCIIOriya = 57007; //Field offset: 0x0
	private const int ISOKorean = 50225; //Field offset: 0x0
	private const int EUCJP = 51932; //Field offset: 0x0
	private const int ISO2022JPESC = 50221; //Field offset: 0x0
	private const int MIMECONTF_MAILNEWS = 1; //Field offset: 0x0
	private const int MIMECONTF_BROWSER = 2; //Field offset: 0x0
	private const int ISO2022JPSISO = 50222; //Field offset: 0x0
	private const int MIMECONTF_SAVABLE_BROWSER = 512; //Field offset: 0x0
	private const int CodePageDefault = 0; //Field offset: 0x0
	private const int CodePageNoOEM = 1; //Field offset: 0x0
	private const int CodePageNoMac = 2; //Field offset: 0x0
	private const int CodePageNoThread = 3; //Field offset: 0x0
	private const int CodePageNoSymbol = 42; //Field offset: 0x0
	private const int MIMECONTF_SAVABLE_MAILNEWS = 256; //Field offset: 0x0
	private const int CodePageBigEndian = 1201; //Field offset: 0x0
	private const int CodePageWindows1252 = 1252; //Field offset: 0x0
	private const int CodePageMacGB2312 = 10008; //Field offset: 0x0
	private const int CodePageGB2312 = 20936; //Field offset: 0x0
	private const int CodePageMacKorean = 10003; //Field offset: 0x0
	private const int CodePageDLLKorean = 20949; //Field offset: 0x0
	private const int ISO2022JP = 50220; //Field offset: 0x0
	private const int CodePageUnicode = 1200; //Field offset: 0x0
	private static Encoding unicodeEncoding; //Field offset: 0x8
	private static Encoding bigEndianUnicode; //Field offset: 0x10
	private static Encoding utf7Encoding; //Field offset: 0x18
	private static Encoding utf8Encoding; //Field offset: 0x20
	private static Encoding utf32Encoding; //Field offset: 0x28
	private static Encoding asciiEncoding; //Field offset: 0x30
	private static Encoding latin1Encoding; //Field offset: 0x38
	private static Dictionary<Int32, Encoding> encodings; //Field offset: 0x40
	private static object s_InternalSyncObject; //Field offset: 0x48
	internal int m_codePage; //Field offset: 0x10
	internal CodePageDataItem dataItem; //Field offset: 0x18
	internal bool m_deserializedFromEverett; //Field offset: 0x20
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; //Field offset: 0x21
	[OptionalField(VersionAdded = 2)]
	internal EncoderFallback encoderFallback; //Field offset: 0x28
	[OptionalField(VersionAdded = 2)]
	internal DecoderFallback decoderFallback; //Field offset: 0x30

	public static Encoding ASCII
	{
		 get { } //Length: 160
	}

	public static Encoding BigEndianUnicode
	{
		 get { } //Length: 168
	}

	public override int CodePage
	{
		 get { } //Length: 8
	}

	[ComVisible(False)]
	public DecoderFallback DecoderFallback
	{
		 get { } //Length: 8
		 set { } //Length: 188
	}

	public static Encoding Default
	{
		 get { } //Length: 124
	}

	[ComVisible(False)]
	public EncoderFallback EncoderFallback
	{
		 get { } //Length: 8
		 set { } //Length: 188
	}

	public override string EncodingName
	{
		 get { } //Length: 12
	}

	public override string HeaderName
	{
		 get { } //Length: 48
	}

	private static object InternalSyncObject
	{
		private get { } //Length: 152
	}

	[ComVisible(False)]
	public bool IsReadOnly
	{
		 get { } //Length: 8
	}

	private static Encoding Latin1
	{
		private get { } //Length: 160
	}

	public override ReadOnlySpan<Byte> Preamble
	{
		 get { } //Length: 84
	}

	public static Encoding Unicode
	{
		 get { } //Length: 168
	}

	public static Encoding UTF32
	{
		 get { } //Length: 168
	}

	public static Encoding UTF7
	{
		 get { } //Length: 160
	}

	public static Encoding UTF8
	{
		 get { } //Length: 164
	}

	public override string WebName
	{
		 get { } //Length: 48
	}

	protected Encoding() { }

	protected Encoding(int codePage) { }

	[ComVisible(False)]
	public override object Clone() { }

	private static Encoding CreateDefaultEncoding() { }

	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	public virtual bool Equals(object value) { }

	public static Encoding get_ASCII() { }

	public static Encoding get_BigEndianUnicode() { }

	public override int get_CodePage() { }

	public DecoderFallback get_DecoderFallback() { }

	public static Encoding get_Default() { }

	public EncoderFallback get_EncoderFallback() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	private static object get_InternalSyncObject() { }

	public bool get_IsReadOnly() { }

	private static Encoding get_Latin1() { }

	public override ReadOnlySpan<Byte> get_Preamble() { }

	public static Encoding get_Unicode() { }

	public static Encoding get_UTF32() { }

	public static Encoding get_UTF7() { }

	public static Encoding get_UTF8() { }

	public override string get_WebName() { }

	internal override Char[] GetBestFitBytesToUnicodeData() { }

	internal override Char[] GetBestFitUnicodeToBytesData() { }

	public abstract int GetByteCount(Char[] chars, int index, int count) { }

	internal override int GetByteCount(Char* chars, int count, EncoderNLS encoder) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	public override int GetByteCount(Char* chars, int count) { }

	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	public override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	internal override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	public override Byte[] GetBytes(string s) { }

	public abstract int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public override int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public override Byte[] GetBytes(Char[] chars) { }

	public override Byte[] GetBytes(Char[] chars, int index, int count) { }

	public override int GetBytes(ReadOnlySpan<Char> chars, Span<Byte> bytes) { }

	public abstract int GetCharCount(Byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	public override int GetCharCount(Byte* bytes, int count) { }

	internal override int GetCharCount(Byte* bytes, int count, DecoderNLS decoder) { }

	public override Char[] GetChars(Byte[] bytes, int index, int count) { }

	public abstract int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	public override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	internal override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS decoder) { }

	public override int GetChars(ReadOnlySpan<Byte> bytes, Span<Char> chars) { }

	private void GetDataItem() { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public static Encoding GetEncoding(int codepage) { }

	public static Encoding GetEncoding(string name) { }

	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	public virtual int GetHashCode() { }

	public abstract int GetMaxByteCount(int charCount) { }

	public abstract int GetMaxCharCount(int byteCount) { }

	public override Byte[] GetPreamble() { }

	public string GetString(ReadOnlySpan<Byte> bytes) { }

	public override string GetString(Byte[] bytes) { }

	public override string GetString(Byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	public string GetString(Byte* bytes, int byteCount) { }

	internal void OnDeserialized() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	internal void OnDeserializing() { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	public void set_DecoderFallback(DecoderFallback value) { }

	public void set_EncoderFallback(EncoderFallback value) { }

	internal override void SetDefaultFallbacks() { }

	internal void setReadOnly(bool value = true) { }

	internal void ThrowBytesOverflow() { }

	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

	internal void ThrowCharsOverflow() { }

}

