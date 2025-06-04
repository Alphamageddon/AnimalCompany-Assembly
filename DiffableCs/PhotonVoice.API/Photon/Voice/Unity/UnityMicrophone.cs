namespace Photon.Voice.Unity;

public static class UnityMicrophone
{

	public static String[] devices
	{
		 get { } //Length: 8
	}

	public static string CheckDevice(ILogger logger, string logPref, string device, int suggestedFrequency, out int frequency) { }

	public static void End(string deviceName) { }

	public static String[] get_devices() { }

	public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq) { }

	public static int GetPosition(string deviceName) { }

	public static bool IsRecording(string deviceName) { }

	public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency) { }

}

