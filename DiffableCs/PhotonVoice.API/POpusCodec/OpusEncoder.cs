namespace POpusCodec;

public class OpusEncoder : IDisposable
{
	public const int BitrateMax = -1; //Field offset: 0x0
	private const int RecommendedMaxPacketSize = 4000; //Field offset: 0x0
	private static readonly ArraySegment<Byte> EmptyBuffer; //Field offset: 0x0
	public static Dictionary<IntPtr, OpusEncoder> handles; //Field offset: 0x10
	private IntPtr handle; //Field offset: 0x10
	private int frameSamples; //Field offset: 0x18
	private SamplingRate inputSamplingRate; //Field offset: 0x1C
	private Channels channels; //Field offset: 0x20
	private readonly Byte[] writePacket; //Field offset: 0x28
	private Delay _encoderDelay; //Field offset: 0x30
	private Byte[] bufOut; //Field offset: 0x38
	public Action<ArraySegment`1<Byte>, FrameFlags> Output; //Field offset: 0x40

	public int Bitrate
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public Complexity Complexity
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public bool DtxEnabled
	{
		 get { } //Length: 32
		 set { } //Length: 16
	}

	public Delay EncoderDelay
	{
		 get { } //Length: 8
		 set { } //Length: 276
	}

	public int ExpectedPacketLossPercentage
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public ForceChannels ForceChannels
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public int FrameSizePerChannel
	{
		 get { } //Length: 8
	}

	public Channels InputChannels
	{
		 get { } //Length: 8
	}

	public SamplingRate InputSamplingRate
	{
		 get { } //Length: 8
	}

	public Bandwidth MaxBandwidth
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public int PacketLossPercentage
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public SignalHint SignalHint
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public bool UseInbandFEC
	{
		 get { } //Length: 32
		 set { } //Length: 16
	}

	public bool UseUnconstrainedVBR
	{
		 get { } //Length: 32
		 set { } //Length: 20
	}

	private static OpusEncoder() { }

	public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay) { }

	private void dataCallback(IntPtr p, int count) { }

	[MonoPInvokeCallback(typeof(System.Action`3<System.IntPtr, System.IntPtr, System.Int32>))]
	public static void DataCallbackStatic(IntPtr handle, IntPtr p, int count) { }

	public override void Dispose() { }

	public void Encode(Int16[] pcmSamples) { }

	public void Encode(Single[] pcmSamples) { }

	public int get_Bitrate() { }

	public Complexity get_Complexity() { }

	public bool get_DtxEnabled() { }

	public Delay get_EncoderDelay() { }

	public int get_ExpectedPacketLossPercentage() { }

	public ForceChannels get_ForceChannels() { }

	public int get_FrameSizePerChannel() { }

	public Channels get_InputChannels() { }

	public SamplingRate get_InputSamplingRate() { }

	public Bandwidth get_MaxBandwidth() { }

	public int get_PacketLossPercentage() { }

	public SignalHint get_SignalHint() { }

	public bool get_UseInbandFEC() { }

	public bool get_UseUnconstrainedVBR() { }

	public void set_Bitrate(int value) { }

	public void set_Complexity(Complexity value) { }

	public void set_DtxEnabled(bool value) { }

	public void set_EncoderDelay(Delay value) { }

	public void set_ExpectedPacketLossPercentage(int value) { }

	public void set_ForceChannels(ForceChannels value) { }

	public void set_MaxBandwidth(Bandwidth value) { }

	public void set_PacketLossPercentage(int value) { }

	public void set_SignalHint(SignalHint value) { }

	public void set_UseInbandFEC(bool value) { }

	public void set_UseUnconstrainedVBR(bool value) { }

}

