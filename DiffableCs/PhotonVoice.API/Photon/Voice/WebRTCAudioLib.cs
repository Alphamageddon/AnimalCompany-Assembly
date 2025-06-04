namespace Photon.Voice;

public class WebRTCAudioLib
{
	internal enum Error
	{
		kNoError = 0,
		kUnspecifiedError = -1,
		kCreationFailedError = -2,
		kUnsupportedComponentError = -3,
		kUnsupportedFunctionError = -4,
		kNullPointerError = -5,
		kBadParameterError = -6,
		kBadSampleRateError = -7,
		kBadDataLengthError = -8,
		kBadNumberChannelsError = -9,
		kFileError = -10,
		kStreamParameterNotSetError = -11,
		kNotEnabledError = -12,
		kBadStreamParameterWarning = -13,
	}

	internal enum Param
	{
		REVERSE_STREAM_DELAY_MS = 1,
		AEC = 10,
		AEC_HIGH_PASS_FILTER = 11,
		AECM = 20,
		HIGH_PASS_FILTER = 31,
		NS = 41,
		NS_LEVEL = 42,
		AGC = 51,
		AGC_TARGET_LEVEL_DBFS = 55,
		AGC_COMPRESSION_GAIN = 56,
		AGC_LIMITER = 57,
		VAD = 61,
		VAD_FRAME_SIZE_MS = 62,
		VAD_LIKELIHOOD = 63,
		AGC2 = 71,
	}

	private const string lib_name = "webrtc-audio"; //Field offset: 0x0

	public WebRTCAudioLib() { }

	public static IntPtr webrtc_audio_processor_create(int samplingRate, int channels, int frameSize, int revSamplingRate, int revChannels) { }

	public static void webrtc_audio_processor_destroy(IntPtr proc) { }

	public static int webrtc_audio_processor_init(IntPtr proc) { }

	public static int webrtc_audio_processor_process(IntPtr proc, Int16[] buffer, int offset, out bool voiceDetected) { }

	public static int webrtc_audio_processor_process_reverse(IntPtr proc, Int16[] buffer, int bufferSize) { }

	public static int webrtc_audio_processor_set_param(IntPtr proc, int param, int v) { }

}

