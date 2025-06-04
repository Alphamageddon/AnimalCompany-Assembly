namespace Photon.Voice;

public static class Platform
{

	public static IAudioInChangeNotifier CreateAudioInChangeNotifier(Action callback, ILogger logger) { }

	public static IDeviceEnumerator CreateAudioInEnumerator(ILogger logger) { }

	public static IEncoder CreateDefaultAudioEncoder(ILogger logger, VoiceInfo info) { }

	public static IAudioDesc CreateDefaultAudioSource(ILogger logger, DeviceInfo dev, int samplingRate, int channels, object otherParams = null) { }

}

