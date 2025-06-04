namespace UnityEngine.Rendering.Universal;

internal static class PlatformAutoDetect
{
	private static List<XRDisplaySubsystem> displaySubsystemList; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <isXRMobile>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <isShaderAPIMobileDefined>k__BackingField; //Field offset: 0x9
	[CompilerGenerated]
	private static bool <isSwitch>k__BackingField; //Field offset: 0xA

	internal static bool isShaderAPIMobileDefined
	{
		[CompilerGenerated]
		internal get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 96
	}

	internal static bool isSwitch
	{
		[CompilerGenerated]
		internal get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 96
	}

	internal static bool isXRMobile
	{
		[CompilerGenerated]
		internal get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 96
	}

	private static PlatformAutoDetect() { }

	[CompilerGenerated]
	internal static bool get_isShaderAPIMobileDefined() { }

	[CompilerGenerated]
	internal static bool get_isSwitch() { }

	[CompilerGenerated]
	internal static bool get_isXRMobile() { }

	internal static void Initialize() { }

	private static bool IsRunningXRMobile() { }

	[CompilerGenerated]
	private static void set_isShaderAPIMobileDefined(bool value) { }

	[CompilerGenerated]
	private static void set_isSwitch(bool value) { }

	[CompilerGenerated]
	private static void set_isXRMobile(bool value) { }

	internal static ShEvalMode ShAutoDetect(ShEvalMode mode) { }

}

