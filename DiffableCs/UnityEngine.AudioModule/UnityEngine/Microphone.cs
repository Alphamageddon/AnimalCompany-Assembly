namespace UnityEngine;

[StaticAccessor("GetAudioManager()", StaticAccessorType::Dot (0))]
public sealed class Microphone
{

	public static String[] devices
	{
		[NativeName("GetRecordDevices")]
		 get { } //Length: 40
	}

	public static void End(string deviceName) { }

	private static void EndRecord(int deviceID) { }

	[NativeName("GetRecordDevices")]
	public static String[] get_devices() { }

	private static void GetDeviceCaps(int deviceID, out int minFreq, out int maxFreq) { }

	public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq) { }

	[NativeMethod(IsThreadSafe = True)]
	private static int GetMicrophoneDeviceIDFromName(string name) { }

	public static int GetPosition(string deviceName) { }

	[NativeMethod(IsThreadSafe = True)]
	private static int GetRecordPosition(int deviceID) { }

	private static bool IsRecording(int deviceID) { }

	public static bool IsRecording(string deviceName) { }

	public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency) { }

	private static AudioClip StartRecord(int deviceID, bool loop, float lengthSec, int frequency) { }

}

