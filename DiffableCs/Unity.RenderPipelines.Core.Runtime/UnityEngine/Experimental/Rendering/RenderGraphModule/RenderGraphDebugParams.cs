namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class RenderGraphDebugParams
{
	private static class Strings
	{
		public static readonly NameAndTooltip ClearRenderTargetsAtCreation; //Field offset: 0x0
		public static readonly NameAndTooltip DisablePassCulling; //Field offset: 0x10
		public static readonly NameAndTooltip ImmediateMode; //Field offset: 0x20
		public static readonly NameAndTooltip EnableLogging; //Field offset: 0x30
		public static readonly NameAndTooltip LogFrameInformation; //Field offset: 0x40
		public static readonly NameAndTooltip LogResources; //Field offset: 0x50

		private static Strings() { }

	}

	private Widget[] m_DebugItems; //Field offset: 0x10
	private Panel m_DebugPanel; //Field offset: 0x18
	public bool clearRenderTargetsAtCreation; //Field offset: 0x20
	public bool clearRenderTargetsAtRelease; //Field offset: 0x21
	public bool disablePassCulling; //Field offset: 0x22
	public bool immediateMode; //Field offset: 0x23
	public bool enableLogging; //Field offset: 0x24
	public bool logFrameInformation; //Field offset: 0x25
	public bool logResources; //Field offset: 0x26

	public RenderGraphDebugParams() { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__10_0() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__10_1(bool value) { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__10_2() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__10_3(bool value) { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__10_4() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__10_5(bool value) { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__10_6() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__10_7(bool value) { }

	[CompilerGenerated]
	private void <RegisterDebug>b__10_8() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__10_9() { }

	public void RegisterDebug(string name, Panel debugPanel = null) { }

	public void UnRegisterDebug(string name) { }

}

