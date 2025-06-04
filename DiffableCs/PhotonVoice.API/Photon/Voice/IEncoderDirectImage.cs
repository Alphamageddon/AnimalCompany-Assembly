namespace Photon.Voice;

public interface IEncoderDirectImage : IEncoderDirect<ImageBufferNative>, IEncoder, IDisposable
{

	public ImageFormat ImageFormat
	{
		 get { } //Length: 0
	}

	public ImageFormat get_ImageFormat() { }

}

