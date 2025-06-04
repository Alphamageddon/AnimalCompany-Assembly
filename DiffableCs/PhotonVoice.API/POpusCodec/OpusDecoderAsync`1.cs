namespace POpusCodec;

public class OpusDecoderAsync : OpusDecoder<T>
{
	protected static Dictionary<IntPtr, OpusDecoderAsync`1<T>> handles; //Field offset: 0x0
	private Single[] bufOutFloat; //Field offset: 0x0
	private Int16[] bufOutShort; //Field offset: 0x0

	private static OpusDecoderAsync`1() { }

	public OpusDecoderAsync`1(Action<FrameOut`1<T>> output, SamplingRate outputSamplingRateHz, Channels numChannels, int frameDurationSamples) { }

	protected void dataCallback(IntPtr p, int count, bool endOfStream) { }

	[MonoPInvokeCallback(typeof(System.Action`4<System.IntPtr, System.IntPtr, System.Int32, System.Boolean>))]
	public static void DataCallbackStatic(IntPtr handle, IntPtr p, int count, bool endOfStream) { }

	public virtual void Dispose() { }

}

