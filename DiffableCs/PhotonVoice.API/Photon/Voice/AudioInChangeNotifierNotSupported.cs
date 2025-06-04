namespace Photon.Voice;

public class AudioInChangeNotifierNotSupported : IAudioInChangeNotifier, IDisposable
{

	public override string Error
	{
		 get { } //Length: 64
	}

	public override bool IsSupported
	{
		 get { } //Length: 8
	}

	public AudioInChangeNotifierNotSupported(Action callback, ILogger logger) { }

	public override void Dispose() { }

	public override string get_Error() { }

	public override bool get_IsSupported() { }

}

