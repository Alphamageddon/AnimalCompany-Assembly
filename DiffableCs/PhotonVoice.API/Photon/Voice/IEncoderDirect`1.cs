namespace Photon.Voice;

public interface IEncoderDirect : IEncoder, IDisposable
{

	public void Input(B buf) { }

}

