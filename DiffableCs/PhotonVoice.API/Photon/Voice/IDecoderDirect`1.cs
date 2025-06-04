namespace Photon.Voice;

public interface IDecoderDirect : IDecoder, IDisposable
{

	public Action<B> Output
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Action<B> get_Output() { }

	public void set_Output(Action<B> value) { }

}

