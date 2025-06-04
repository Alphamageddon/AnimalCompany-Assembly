namespace Photon.Voice.Unity;

public class MicWrapper : IAudioReader<Single>, IDataReader<Single>, IDisposable, IAudioDesc
{
	private AudioClip mic; //Field offset: 0x10
	private string device; //Field offset: 0x18
	private ILogger logger; //Field offset: 0x20
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x28
	private int micPrevPos; //Field offset: 0x30
	private int micLoopCnt; //Field offset: 0x34
	private int readAbsPos; //Field offset: 0x38

	public override int Channels
	{
		 get { } //Length: 48
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
		 get { } //Length: 48
	}

	public MicWrapper(string device, int suggestedFrequency, ILogger logger) { }

	public override void Dispose() { }

	public override int get_Channels() { }

	[CompilerGenerated]
	public override string get_Error() { }

	public override int get_SamplingRate() { }

	public override bool Read(Single[] buffer) { }

	[CompilerGenerated]
	private void set_Error(string value) { }

}

