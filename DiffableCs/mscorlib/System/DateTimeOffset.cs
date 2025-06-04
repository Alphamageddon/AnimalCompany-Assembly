namespace System;

[IsReadOnly]
public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
{
	public static readonly DateTimeOffset MinValue; //Field offset: 0x0
	public static readonly DateTimeOffset MaxValue; //Field offset: 0x10
	public static readonly DateTimeOffset UnixEpoch; //Field offset: 0x20
	private readonly DateTime _dateTime; //Field offset: 0x0
	private readonly short _offsetMinutes; //Field offset: 0x8

	private DateTime ClockDateTime
	{
		private get { } //Length: 208
	}

	public TimeSpan Offset
	{
		 get { } //Length: 44
	}

	public DateTime UtcDateTime
	{
		 get { } //Length: 92
	}

	public static DateTimeOffset UtcNow
	{
		 get { } //Length: 108
	}

	private static DateTimeOffset() { }

	private DateTimeOffset(SerializationInfo info, StreamingContext context) { }

	public DateTimeOffset(long ticks, TimeSpan offset) { }

	public DateTimeOffset(DateTime dateTime) { }

	public override int CompareTo(DateTimeOffset other) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(DateTimeOffset other) { }

	public static DateTimeOffset FromUnixTimeSeconds(long seconds) { }

	private DateTime get_ClockDateTime() { }

	public TimeSpan get_Offset() { }

	public DateTime get_UtcDateTime() { }

	public static DateTimeOffset get_UtcNow() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	public static DateTimeOffset Parse(string input) { }

	private override int System.IComparable.CompareTo(object obj) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

	public string ToString(IFormatProvider formatProvider) { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public long ToUnixTimeSeconds() { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

	public static bool TryParseExact(string input, String[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	private static short ValidateOffset(TimeSpan offset) { }

	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

}

