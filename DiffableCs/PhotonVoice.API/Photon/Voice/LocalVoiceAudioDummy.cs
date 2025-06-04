namespace Photon.Voice;

public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
{
	public static LocalVoiceAudioDummy Dummy; //Field offset: 0x0
	private VoiceDetectorDummy voiceDetector; //Field offset: 0x108
	private LevelMeterDummy levelMeter; //Field offset: 0x110

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
		 get { } //Length: 8
	}

	private static LocalVoiceAudioDummy() { }

	public LocalVoiceAudioDummy() { }

	public override ILevelMeter get_LevelMeter() { }

	public override IVoiceDetector get_VoiceDetector() { }

	public override bool get_VoiceDetectorCalibrating() { }

	public override void VoiceDetectorCalibrate(int durationMs, Action<Single> onCalibrated = null) { }

}

