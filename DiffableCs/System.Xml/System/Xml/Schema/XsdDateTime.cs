namespace System.Xml.Schema;

internal struct XsdDateTime
{
	private enum DateTimeTypeCode
	{
		DateTime = 0,
		Time = 1,
		Date = 2,
		GYearMonth = 3,
		GYear = 4,
		GMonthDay = 5,
		GDay = 6,
		GMonth = 7,
		XdrDateTime = 8,
	}

	private enum XsdDateTimeKind
	{
		Unspecified = 0,
		Zulu = 1,
		LocalWestOfZulu = 2,
		LocalEastOfZulu = 3,
	}

	private static readonly int Lzyyyy; //Field offset: 0x0
	private static readonly int Lzyyyy_; //Field offset: 0x4
	private static readonly int Lzyyyy_MM; //Field offset: 0x8
	private static readonly int Lzyyyy_MM_; //Field offset: 0xC
	private static readonly int Lzyyyy_MM_dd; //Field offset: 0x10
	private static readonly int Lzyyyy_MM_ddT; //Field offset: 0x14
	private static readonly int LzHH; //Field offset: 0x18
	private static readonly int LzHH_; //Field offset: 0x1C
	private static readonly int LzHH_mm; //Field offset: 0x20
	private static readonly int LzHH_mm_; //Field offset: 0x24
	private static readonly int LzHH_mm_ss; //Field offset: 0x28
	private static readonly int Lz_; //Field offset: 0x2C
	private static readonly int Lz_zz; //Field offset: 0x30
	private static readonly int Lz_zz_; //Field offset: 0x34
	private static readonly int Lz_zz_zz; //Field offset: 0x38
	private static readonly int Lz__; //Field offset: 0x3C
	private static readonly int Lz__mm; //Field offset: 0x40
	private static readonly int Lz__mm_; //Field offset: 0x44
	private static readonly int Lz__mm__; //Field offset: 0x48
	private static readonly int Lz__mm_dd; //Field offset: 0x4C
	private static readonly int Lz___; //Field offset: 0x50
	private static readonly int Lz___dd; //Field offset: 0x54
	private static readonly XmlTypeCode[] typeCodes; //Field offset: 0x58
	private DateTime dt; //Field offset: 0x0
	private uint extra; //Field offset: 0x8

	public int Day
	{
		 get { } //Length: 88
	}

	public int Fraction
	{
		 get { } //Length: 280
	}

	public int Hour
	{
		 get { } //Length: 88
	}

	private XsdDateTimeKind InternalKind
	{
		private get { } //Length: 8
	}

	private DateTimeTypeCode InternalTypeCode
	{
		private get { } //Length: 8
	}

	public int Minute
	{
		 get { } //Length: 88
	}

	public int Month
	{
		 get { } //Length: 88
	}

	public int Second
	{
		 get { } //Length: 88
	}

	public int Year
	{
		 get { } //Length: 88
	}

	public int ZoneHour
	{
		 get { } //Length: 8
	}

	public int ZoneMinute
	{
		 get { } //Length: 8
	}

	private static XsdDateTime() { }

	public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds) { }

	public int get_Day() { }

	public int get_Fraction() { }

	public int get_Hour() { }

	private XsdDateTimeKind get_InternalKind() { }

	private DateTimeTypeCode get_InternalTypeCode() { }

	public int get_Minute() { }

	public int get_Month() { }

	public int get_Second() { }

	public int get_Year() { }

	public int get_ZoneHour() { }

	public int get_ZoneMinute() { }

	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	private void PrintDate(StringBuilder sb) { }

	private void PrintTime(StringBuilder sb) { }

	private void PrintZone(StringBuilder sb) { }

	private void ShortToCharArray(Char[] text, int start, int value) { }

	public virtual string ToString() { }

}

