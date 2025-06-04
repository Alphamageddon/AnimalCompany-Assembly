namespace Photon.Voice;

public class AudioDesc : IAudioDesc, IDisposable
{
	[CompilerGenerated]
	private int <SamplingRate>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Channels>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x18

	public private override int Channels
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override string Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override int SamplingRate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public AudioDesc(int samplingRate, int channels, string error) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public override int get_Channels() { }

	[CompilerGenerated]
	public override string get_Error() { }

	[CompilerGenerated]
	public override int get_SamplingRate() { }

	[CompilerGenerated]
	private void set_Channels(int value) { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	[CompilerGenerated]
	private void set_SamplingRate(int value) { }

}

