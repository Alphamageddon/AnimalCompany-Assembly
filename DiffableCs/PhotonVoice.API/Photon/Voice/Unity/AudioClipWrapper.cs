namespace Photon.Voice.Unity;

public class AudioClipWrapper : IAudioReader<Single>, IDataReader<Single>, IDisposable, IAudioDesc
{
	private AudioClip audioClip; //Field offset: 0x10
	private int readPos; //Field offset: 0x18
	private float startTime; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <Loop>k__BackingField; //Field offset: 0x20
	private bool playing; //Field offset: 0x21
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x28

	public override int Channels
	{
		 get { } //Length: 28
	}

	public private override string Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool Loop
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override int SamplingRate
	{
		 get { } //Length: 28
	}

	public AudioClipWrapper(AudioClip audioClip) { }

	public override void Dispose() { }

	public override int get_Channels() { }

	[CompilerGenerated]
	public override string get_Error() { }

	[CompilerGenerated]
	public bool get_Loop() { }

	public override int get_SamplingRate() { }

	public override bool Read(Single[] buffer) { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	[CompilerGenerated]
	public void set_Loop(bool value) { }

}

