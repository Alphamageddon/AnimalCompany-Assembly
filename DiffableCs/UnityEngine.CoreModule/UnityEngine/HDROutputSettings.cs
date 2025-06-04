namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/HDROutputSettings.h")]
[UsedByNativeCode]
public class HDROutputSettings
{
	public static HDROutputSettings[] displays; //Field offset: 0x0
	private static HDROutputSettings _mainDisplay; //Field offset: 0x8
	private int m_DisplayIndex; //Field offset: 0x10

	public bool active
	{
		 get { } //Length: 120
	}

	public bool automaticHDRTonemapping
	{
		 set { } //Length: 136
	}

	public bool available
	{
		 get { } //Length: 120
	}

	public ColorGamut displayColorGamut
	{
		 get { } //Length: 120
	}

	public static HDROutputSettings main
	{
		 get { } //Length: 88
	}

	public int maxFullFrameToneMapLuminance
	{
		 get { } //Length: 120
	}

	public int maxToneMapLuminance
	{
		 get { } //Length: 120
	}

	public int minToneMapLuminance
	{
		 get { } //Length: 120
	}

	public float paperWhiteNits
	{
		 get { } //Length: 120
	}

	private static HDROutputSettings() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"}])]
	internal HDROutputSettings() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"}])]
	internal HDROutputSettings(int displayIndex) { }

	public bool get_active() { }

	public bool get_available() { }

	public ColorGamut get_displayColorGamut() { }

	public static HDROutputSettings get_main() { }

	public int get_maxFullFrameToneMapLuminance() { }

	public int get_maxToneMapLuminance() { }

	public int get_minToneMapLuminance() { }

	public float get_paperWhiteNits() { }

	[FreeFunction("HDROutputSettingsBindings::GetActive", HasExplicitThis = False, ThrowsException = True)]
	private static bool GetActive(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetAvailable", HasExplicitThis = False, ThrowsException = True)]
	private static bool GetAvailable(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetDisplayColorGamut", HasExplicitThis = False, ThrowsException = True)]
	private static ColorGamut GetDisplayColorGamut(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetMaxFullFrameToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	private static int GetMaxFullFrameToneMapLuminance(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetMaxToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	private static int GetMaxToneMapLuminance(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetMinToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	private static int GetMinToneMapLuminance(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetPaperWhiteNits", HasExplicitThis = False, ThrowsException = True)]
	private static float GetPaperWhiteNits(int displayIndex) { }

	public void RequestHDRModeChange(bool enabled) { }

	[FreeFunction("HDROutputSettingsBindings::RequestHDRModeChange", HasExplicitThis = False, ThrowsException = True)]
	private static void RequestHDRModeChangeInternal(int displayIndex, bool enabled) { }

	public void set_automaticHDRTonemapping(bool value) { }

	[FreeFunction("HDROutputSettingsBindings::SetAutomaticHDRTonemapping", HasExplicitThis = False, ThrowsException = True)]
	private static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted) { }

}

