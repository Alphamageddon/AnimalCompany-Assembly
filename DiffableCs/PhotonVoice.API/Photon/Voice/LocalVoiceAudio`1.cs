namespace Photon.Voice;

public abstract class LocalVoiceAudio : LocalVoiceFramed<T>, ILocalVoiceAudio
{
	protected VoiceDetector<T> voiceDetector; //Field offset: 0x0
	protected VoiceDetectorCalibration<T> voiceDetectorCalibration; //Field offset: 0x0
	protected LevelMeter<T> levelMeter; //Field offset: 0x0
	protected int channels; //Field offset: 0x0

	public override ILevelMeter LevelMeter
	{
		 get { } //Length: 8
	}

	public override IVoiceDetector VoiceDetector
	{
		 get { } //Length: 8
	}

	public override bool VoiceDetectorCalibrating
	{
		 get { } //Length: 36
	}

	internal LocalVoiceAudio`1(VoiceClient voiceClient, byte id, VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId, VoiceCreateOptions opt) { }

	internal static LocalVoiceAudio<T> Create(VoiceClient voiceClient, byte voiceId, VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId, VoiceCreateOptions options = null) { }

	public override ILevelMeter get_LevelMeter() { }

	public override IVoiceDetector get_VoiceDetector() { }

	public override bool get_VoiceDetectorCalibrating() { }

	protected void initBuiltinProcessors() { }

	public override void VoiceDetectorCalibrate(int durationMs, Action<Single> onCalibrated = null) { }

}

