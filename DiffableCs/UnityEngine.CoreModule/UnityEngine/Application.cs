namespace UnityEngine;

[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
public class Application
{
	internal sealed class LogCallback : MulticastDelegate
	{

		public LogCallback(object object, IntPtr method) { }

		public override void Invoke(string condition, string stackTrace, LogType type) { }

	}

	internal sealed class LowMemoryCallback : MulticastDelegate
	{

		public LowMemoryCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal sealed class MemoryUsageChangedCallback : MulticastDelegate
	{

		public MemoryUsageChangedCallback(object object, IntPtr method) { }

		public override void Invoke(in ApplicationMemoryUsageChange usage) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static MemoryUsageChangedCallback memoryUsageChanged; //Field offset: 0x8
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x10
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Boolean> focusChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String> deepLinkActivated; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Func<Boolean> wantsToQuit; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action quitting; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action unloading; //Field offset: 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; //Field offset: 0x48

	public static event Action<Boolean> focusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 244
		[CompilerGenerated]
		 remove { } //Length: 244
	}

	public static event LogCallback logMessageReceived
	{
		 add { } //Length: 220
		 remove { } //Length: 184
	}

	public static event UnityAction onBeforeRender
	{
		 add { } //Length: 84
		 remove { } //Length: 84
	}

	public static event Action quitting
	{
		[CompilerGenerated]
		 add { } //Length: 220
		[CompilerGenerated]
		 remove { } //Length: 220
	}

	public static NetworkReachability internetReachability
	{
		[FreeFunction("GetInternetReachability")]
		 get { } //Length: 40
	}

	public static bool isBatchMode
	{
		[FreeFunction("::IsBatchmode")]
		 get { } //Length: 40
	}

	public static bool isEditor
	{
		 get { } //Length: 8
	}

	public static bool isFocused
	{
		[FreeFunction("IsPlayerFocused")]
		 get { } //Length: 40
	}

	public static bool isMobilePlatform
	{
		 get { } //Length: 196
	}

	public static bool isPlaying
	{
		[FreeFunction("IsWorldPlaying")]
		 get { } //Length: 40
	}

	public static string persistentDataPath
	{
		[FreeFunction("GetPersistentDataPathApplicationSpecific")]
		 get { } //Length: 40
	}

	public static RuntimePlatform platform
	{
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
		 get { } //Length: 40
	}

	public static bool runInBackground
	{
		[FreeFunction("GetPlayerSettingsRunInBackground")]
		 get { } //Length: 40
		[FreeFunction("SetPlayerSettingsRunInBackground")]
		 set { } //Length: 60
	}

	public static string unityVersion
	{
		[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
		 get { } //Length: 40
	}

	public static string version
	{
		[FreeFunction("GetApplicationInfo().GetVersion")]
		 get { } //Length: 40
	}

	private static Application() { }

	[CompilerGenerated]
	public static void add_focusChanged(Action<Boolean> value) { }

	public static void add_logMessageReceived(LogCallback value) { }

	public static void add_onBeforeRender(UnityAction value) { }

	[CompilerGenerated]
	public static void add_quitting(Action value) { }

	[RequiredByNativeCode]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCode]
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[FreeFunction("GetInternetReachability")]
	public static NetworkReachability get_internetReachability() { }

	[FreeFunction("::IsBatchmode")]
	public static bool get_isBatchMode() { }

	public static bool get_isEditor() { }

	[FreeFunction("IsPlayerFocused")]
	public static bool get_isFocused() { }

	public static bool get_isMobilePlatform() { }

	[FreeFunction("IsWorldPlaying")]
	public static bool get_isPlaying() { }

	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	public static string get_persistentDataPath() { }

	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	public static RuntimePlatform get_platform() { }

	[FreeFunction("GetPlayerSettingsRunInBackground")]
	public static bool get_runInBackground() { }

	[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
	public static string get_unityVersion() { }

	[FreeFunction("GetApplicationInfo().GetVersion")]
	public static string get_version() { }

	[RequiredByNativeCode]
	internal static bool HasLogCallback() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationInit() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCode]
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	internal static void InvokeDeepLinkActivated(string url) { }

	[RequiredByNativeCode]
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	internal static void InvokeOnBeforeRender() { }

	[FreeFunction("OpenURL")]
	public static void OpenURL(string url) { }

	[FreeFunction("GetInputManager().QuitApplication")]
	public static void Quit(int exitCode) { }

	public static void Quit() { }

	[CompilerGenerated]
	public static void remove_focusChanged(Action<Boolean> value) { }

	public static void remove_logMessageReceived(LogCallback value) { }

	public static void remove_onBeforeRender(UnityAction value) { }

	[CompilerGenerated]
	public static void remove_quitting(Action value) { }

	[FreeFunction("SetPlayerSettingsRunInBackground")]
	public static void set_runInBackground(bool value) { }

	[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
	private static void SetLogCallbackDefined(bool defined) { }

}

