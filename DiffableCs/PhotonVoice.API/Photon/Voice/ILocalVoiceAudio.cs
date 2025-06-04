namespace Photon.Voice;

public interface ILocalVoiceAudio
{

	public ILevelMeter LevelMeter
	{
		 get { } //Length: 0
	}

	public IVoiceDetector VoiceDetector
	{
		 get { } //Length: 0
	}

	public bool VoiceDetectorCalibrating
	{
		 get { } //Length: 0
	}

	public ILevelMeter get_LevelMeter() { }

	public IVoiceDetector get_VoiceDetector() { }

	public bool get_VoiceDetectorCalibrating() { }

	public void VoiceDetectorCalibrate(int durationMs, Action<Single> onCalibrated = null) { }

}

