namespace System.Net.Http.Headers;

public class RangeItemHeaderValue : ICloneable
{
	[CompilerGenerated]
	private Nullable<Int64> <From>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable<Int64> <To>k__BackingField; //Field offset: 0x20

	public private Nullable<Int64> From
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

	public RangeItemHeaderValue(Nullable<Int64> from, Nullable<Int64> to) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public Nullable<Int64> get_From() { }

	[CompilerGenerated]
	public Nullable<Int64> get_To() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_From(Nullable<Int64> value) { }

	[CompilerGenerated]
	private void set_To(Nullable<Int64> value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

}

