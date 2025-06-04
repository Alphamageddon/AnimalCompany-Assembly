namespace System.ComponentModel;

[AttributeUsage(708)]
public class DisplayNameAttribute : Attribute
{
	public static readonly DisplayNameAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	private string <DisplayNameValue>k__BackingField; //Field offset: 0x10

	public override string DisplayName
	{
		 get { } //Length: 8
	}

	protected string DisplayNameValue
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static DisplayNameAttribute() { }

	public DisplayNameAttribute() { }

	public DisplayNameAttribute(string displayName) { }

	public virtual bool Equals(object obj) { }

	public override string get_DisplayName() { }

	[CompilerGenerated]
	protected string get_DisplayNameValue() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	protected void set_DisplayNameValue(string value) { }

}

