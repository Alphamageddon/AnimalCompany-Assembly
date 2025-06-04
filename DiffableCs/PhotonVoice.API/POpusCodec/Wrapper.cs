namespace POpusCodec;

internal class Wrapper
{
	private const string lib_name = "opus_egpv"; //Field offset: 0x0
	public const bool AsyncAPI = False; //Field offset: 0x0
	private const string jsProxyPref = ""; //Field offset: 0x0
	private const string ctl_entry_point_set = ""; //Field offset: 0x0
	private const string ctl_entry_point_get = ""; //Field offset: 0x0

	public Wrapper() { }

	public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request) { }

	public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request) { }

	private static void HandleStatusCode(OpusStatusCode statusCode, Object[] info) { }

	private static int opus_decode(IntPtr st, IntPtr data, int len, Int16[] pcm, int frame_size, int decode_fec) { }

	public static int opus_decode(IntPtr st, FrameBuffer data, Single[] pcm, int frame_size, int decode_fec) { }

	public static int opus_decode(IntPtr st, FrameBuffer data, Int16[] pcm, int frame_size, int decode_fec) { }

	public static int opus_decode_async(IntPtr st, IntPtr data, int len, int decodeFEC, bool eos) { }

	private static int opus_decode_float(IntPtr st, IntPtr data, int len, Single[] pcm, int frame_size, int decode_fec) { }

	public static int opus_decode_float_async(IntPtr st, IntPtr data, int len, int decodeFEC, bool eos) { }

	public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels, Action<IntPtr, Boolean> dataCallbackStatic = null) { }

	private static int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value) { }

	private static int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value) { }

	public static void opus_decoder_destroy(IntPtr st) { }

	private static int opus_decoder_get_size(Channels channels) { }

	private static OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels) { }

	private static int opus_encode(IntPtr st, Int16[] pcm, int frame_size, Byte[] data, int max_data_bytes) { }

	public static int opus_encode(IntPtr st, Single[] pcm, int frame_size, Byte[] data) { }

	public static int opus_encode(IntPtr st, Int16[] pcm, int frame_size, Byte[] data) { }

	private static int opus_encode_float(IntPtr st, Single[] pcm, int frame_size, Byte[] data, int max_data_bytes) { }

	public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application) { }

	private static int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value) { }

	private static int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value) { }

	public static void opus_encoder_destroy(IntPtr st) { }

	private static int opus_encoder_get_size(Channels channels) { }

	private static OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application) { }

	public static IntPtr opus_get_version_string() { }

	public static int opus_packet_get_bandwidth(IntPtr data) { }

	public static int opus_packet_get_nb_channels(Byte[] data) { }

	private static IntPtr opus_strerror(OpusStatusCode error) { }

	public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value) { }

	public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value) { }

}

