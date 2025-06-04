namespace Photon.Voice;

public interface IDecoder : IDisposable
{

	public string Error
	{
		 get { } //Length: 0
	}

	public string get_Error() { }

	public void Input(ref FrameBuffer buf) { }

	public void Open(VoiceInfo info) { }

}

