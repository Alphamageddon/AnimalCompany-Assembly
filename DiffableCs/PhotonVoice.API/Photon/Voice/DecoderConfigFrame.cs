namespace Photon.Voice;

public class DecoderConfigFrame : IDisposable
{
	private ILogger logger; //Field offset: 0x10
	private IDecoder decoder; //Field offset: 0x18
	private FrameBuffer configFrame; //Field offset: 0x20
	private bool configFrameDecoded; //Field offset: 0x58

	public DecoderConfigFrame(ILogger logger, IDecoder decoder) { }

	public override void Dispose() { }

	public bool TryConfigure(ref FrameBuffer buf, bool decoderReady) { }

}

