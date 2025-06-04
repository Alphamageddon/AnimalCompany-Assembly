namespace UnityEngine.Rendering.Universal;

internal class XRPassUniversal : XRPass
{
	[CompilerGenerated]
	private bool <isLateLatchEnabled>k__BackingField; //Field offset: 0x6C8
	[CompilerGenerated]
	private bool <canMarkLateLatch>k__BackingField; //Field offset: 0x6C9
	[CompilerGenerated]
	private bool <hasMarkedLateLatch>k__BackingField; //Field offset: 0x6CA

	internal bool canMarkLateLatch
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal bool hasMarkedLateLatch
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal bool isLateLatchEnabled
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public XRPassUniversal() { }

	public static XRPass Create(XRPassCreateInfo createInfo) { }

	[CompilerGenerated]
	internal bool get_canMarkLateLatch() { }

	[CompilerGenerated]
	internal bool get_hasMarkedLateLatch() { }

	[CompilerGenerated]
	internal bool get_isLateLatchEnabled() { }

	public virtual void Release() { }

	[CompilerGenerated]
	internal void set_canMarkLateLatch(bool value) { }

	[CompilerGenerated]
	internal void set_hasMarkedLateLatch(bool value) { }

	[CompilerGenerated]
	internal void set_isLateLatchEnabled(bool value) { }

}

