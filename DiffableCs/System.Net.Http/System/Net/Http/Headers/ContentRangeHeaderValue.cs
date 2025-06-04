namespace System.Net.Http.Headers;

public class ContentRangeHeaderValue : ICloneable
{
	private string unit; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable<Int64> <From>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable<Int64> <Length>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Nullable<Int64> <To>k__BackingField; //Field offset: 0x38

	public private Nullable<Int64> From
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Nullable<Int64> Length
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Nullable<Int64> To
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public string Unit
	{
		 get { } //Length: 8
	}

	private ContentRangeHeaderValue() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public Nullable<Int64> get_From() { }

	[CompilerGenerated]
	public Nullable<Int64> get_Length() { }

	[CompilerGenerated]
	public Nullable<Int64> get_To() { }

	public string get_Unit() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_From(Nullable<Int64> value) { }

	[CompilerGenerated]
	private void set_Length(Nullable<Int64> value) { }

	[CompilerGenerated]
	private void set_To(Nullable<Int64> value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

}

