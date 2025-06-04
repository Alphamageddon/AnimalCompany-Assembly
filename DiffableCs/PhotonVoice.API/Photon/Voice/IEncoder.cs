namespace Photon.Voice;

public interface IEncoder : IDisposable
{

	public string Error
	{
		 get { } //Length: 0
	}

	public Action<ArraySegment`1<Byte>, FrameFlags> Output
	{
		 set { } //Length: 0
	}

	public ArraySegment<Byte> DequeueOutput(out FrameFlags flags) { }

	public void EndOfStream() { }

	public string get_Error() { }

	public I GetPlatformAPI() { }

	public void set_Output(Action<ArraySegment`1<Byte>, FrameFlags> value) { }

}

