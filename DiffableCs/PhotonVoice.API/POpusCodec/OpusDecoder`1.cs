namespace POpusCodec;

public class OpusDecoder : IDisposable
{
	private const bool UseInbandFEC = True; //Field offset: 0x0
	protected static readonly T[] EmptyBuffer; //Field offset: 0x0
	protected Action<FrameOut`1<T>> output; //Field offset: 0x0
	protected bool TisFloat; //Field offset: 0x0
	protected int sizeofT; //Field offset: 0x0
	protected FrameOut<T> frameOut; //Field offset: 0x0
	protected IntPtr handle; //Field offset: 0x0
	protected int channels; //Field offset: 0x0
	protected int frameSamples; //Field offset: 0x0
	private T[] buffer; //Field offset: 0x0
	private bool prevPacketInvalid; //Field offset: 0x0

	private static OpusDecoder`1() { }

	public OpusDecoder`1(Action<FrameOut`1<T>> output, SamplingRate outputSamplingRateHz, Channels channels, int frameSamples) { }

	protected void decodePacket(FrameBuffer data, int decodeFEC, int channels, bool endOfStream) { }

	public void DecodePacket(ref FrameBuffer packetData, bool endOfStream) { }

	public override void Dispose() { }

	protected void procOutput(T[] buffer, bool endOfStream) { }

}

