namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("GetAudioManager()", StaticAccessorType::Dot (0))]
public sealed class AudioSettings
{
	internal sealed class AudioConfigurationChangeHandler : MulticastDelegate
	{

		public AudioConfigurationChangeHandler(object object, IntPtr method) { }

		public override void Invoke(bool deviceWasChanged) { }

	}

	internal static class Mobile
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private static bool <muteState>k__BackingField; //Field offset: 0x0
		private static bool _stopAudioOutputOnMute; //Field offset: 0x1
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private static Action<Boolean> OnMuteStateChanged; //Field offset: 0x8

		public private static bool muteState
		{
			[CompilerGenerated]
			 get { } //Length: 72
			[CompilerGenerated]
			private set { } //Length: 80
		}

		public static bool stopAudioOutputOnMute
		{
			 get { } //Length: 72
		}

		[CompilerGenerated]
		public static bool get_muteState() { }

		public static bool get_stopAudioOutputOnMute() { }

		[RequiredByNativeCode]
		internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

		[RequiredByNativeCode]
		internal static void InvokeOnMuteStateChanged(bool mute) { }

		[CompilerGenerated]
		private static void set_muteState(bool value) { }

		public static void StartAudioOutput() { }

		public static void StopAudioOutput() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action OnAudioSystemShuttingDown; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action OnAudioSystemStartedUp; //Field offset: 0x10

	public static event AudioConfigurationChangeHandler OnAudioConfigurationChanged
	{
		[CompilerGenerated]
		 add { } //Length: 184
		[CompilerGenerated]
		 remove { } //Length: 184
	}

	public static int outputSampleRate
	{
		 get { } //Length: 40
	}

	public static AudioSpeakerMode speakerMode
	{
		 get { } //Length: 40
	}

	[CompilerGenerated]
	public static void add_OnAudioConfigurationChanged(AudioConfigurationChangeHandler value) { }

	public static int get_outputSampleRate() { }

	public static AudioSpeakerMode get_speakerMode() { }

	[NativeMethod(Name = "AudioSettings::GetSampleRate", IsFreeFunction = True)]
	private static int GetSampleRate() { }

	private static AudioSpeakerMode GetSpeakerMode() { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioSystemStartedUp() { }

	[CompilerGenerated]
	public static void remove_OnAudioConfigurationChanged(AudioConfigurationChangeHandler value) { }

	internal static bool StartAudioOutput() { }

	internal static bool StopAudioOutput() { }

}

