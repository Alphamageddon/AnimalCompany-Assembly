namespace Photon.Voice.Unity;

internal class MicWrapperPusherOnAudioFilterRead : MonoBehaviour
{
	private Single[] frame2; //Field offset: 0x20
	[CompilerGenerated]
	private Action<Single[], Int32> OnAudioFrame; //Field offset: 0x28

	public event Action<Single[], Int32> OnAudioFrame
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public MicWrapperPusherOnAudioFilterRead() { }

	[CompilerGenerated]
	public void add_OnAudioFrame(Action<Single[], Int32> value) { }

	private void OnAudioFilterRead(Single[] frame, int channels) { }

	[CompilerGenerated]
	public void remove_OnAudioFrame(Action<Single[], Int32> value) { }

}

