namespace Photon.Voice.Unity;

public class AudioOutCapture : MonoBehaviour
{
	[CompilerGenerated]
	private Action<Single[], Int32> OnAudioFrame; //Field offset: 0x20

	public event Action<Single[], Int32> OnAudioFrame
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public AudioOutCapture() { }

	[CompilerGenerated]
	public void add_OnAudioFrame(Action<Single[], Int32> value) { }

	private void OnAudioFilterRead(Single[] frame, int channels) { }

	[CompilerGenerated]
	public void remove_OnAudioFrame(Action<Single[], Int32> value) { }

}

