namespace Fusion;

[AttributeUsage(AttributeTargets::Property (128), AllowMultiple = False, Inherited = False)]
public sealed class RenderAttribute : Attribute
{
	[CompilerGenerated]
	private RenderTimeframe <Timeframe>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private RenderSource <Source>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <Method>k__BackingField; //Field offset: 0x18

	public string Method
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RenderSource Source
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RenderTimeframe Timeframe
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RenderAttribute() { }

	public RenderAttribute(RenderTimeframe timeframe, RenderSource source) { }

	[CompilerGenerated]
	public string get_Method() { }

	[CompilerGenerated]
	public RenderSource get_Source() { }

	[CompilerGenerated]
	public RenderTimeframe get_Timeframe() { }

	[CompilerGenerated]
	public void set_Method(string value) { }

	[CompilerGenerated]
	public void set_Source(RenderSource value) { }

	[CompilerGenerated]
	public void set_Timeframe(RenderTimeframe value) { }

}

