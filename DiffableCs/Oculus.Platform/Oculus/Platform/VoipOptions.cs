namespace Oculus.Platform;

public class VoipOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public VoipOptions() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(VoipOptions options) { }

	public void SetBitrateForNewConnections(VoipBitrate value) { }

	public void SetCreateNewConnectionUseDtx(VoipDtxState value) { }

}

