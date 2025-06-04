namespace Photon.Voice.Unity;

public class MicWrapperPusher : IAudioPusher<Single>, IAudioDesc, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Action<Single[]> callback; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal void <SetCallback>b__0(Single[] buf, int ch) { }

	}

	private AudioSource audioSource; //Field offset: 0x10
	private AudioClip mic; //Field offset: 0x18
	private string device; //Field offset: 0x20
	private ILogger logger; //Field offset: 0x28
	private MicWrapperPusherOnAudioFilterRead onRead; //Field offset: 0x30
	private int sampleRate; //Field offset: 0x38
	private int channels; //Field offset: 0x3C
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x40

	public override int Channels
	{
		 get { } //Length: 24
	}

	public private override string Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override int SamplingRate
	{
		 get { } //Length: 24
	}

	public MicWrapperPusher(GameObject parent, string device, int suggestedFrequency, ILogger logger) { }

	public override void Dispose() { }

	public override int get_Channels() { }

	[CompilerGenerated]
	public override string get_Error() { }

	public override int get_SamplingRate() { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	public override void SetCallback(Action<Single[]> callback, ObjectFactory<Single[], Int32> bufferFactory) { }

}

