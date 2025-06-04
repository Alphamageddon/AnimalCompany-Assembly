namespace Photon.Voice;

public struct VoiceInfo
{
	[CompilerGenerated]
	private Codec <Codec>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <SamplingRate>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private int <Channels>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <FrameDurationUs>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private int <Bitrate>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Width>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <Height>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <FPS>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <KeyFrameInt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private object <UserData>k__BackingField; //Field offset: 0x28

	public int Bitrate
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int Channels
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Codec Codec
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int FPS
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int FrameDurationSamples
	{
		 get { } //Length: 48
	}

	public int FrameDurationUs
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int FrameSize
	{
		 get { } //Length: 56
	}

	public int Height
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int KeyFrameInt
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int SamplingRate
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public object UserData
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int Width
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public static VoiceInfo CreateAudio(Codec codec, int samplingRate, int channels, int frameDurationUs, object userdata = null) { }

	public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int channels, FrameDuration frameDurationUs, int bitrate, object userdata = null) { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Bitrate() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Channels() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Codec get_Codec() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_FPS() { }

	public int get_FrameDurationSamples() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_FrameDurationUs() { }

	public int get_FrameSize() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Height() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_KeyFrameInt() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_SamplingRate() { }

	[CompilerGenerated]
	[IsReadOnly]
	public object get_UserData() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Width() { }

	[CompilerGenerated]
	public void set_Bitrate(int value) { }

	[CompilerGenerated]
	public void set_Channels(int value) { }

	[CompilerGenerated]
	public void set_Codec(Codec value) { }

	[CompilerGenerated]
	public void set_FPS(int value) { }

	[CompilerGenerated]
	public void set_FrameDurationUs(int value) { }

	[CompilerGenerated]
	public void set_Height(int value) { }

	[CompilerGenerated]
	public void set_KeyFrameInt(int value) { }

	[CompilerGenerated]
	public void set_SamplingRate(int value) { }

	[CompilerGenerated]
	public void set_UserData(object value) { }

	[CompilerGenerated]
	public void set_Width(int value) { }

	public virtual string ToString() { }

}

