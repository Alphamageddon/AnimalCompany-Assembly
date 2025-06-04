namespace Photon.Voice.Unity;

public class AndroidAudioInAEC : IAudioPusher<Int16>, IAudioDesc, IDisposable, IResettable
{
	private class DataCallback : AndroidJavaProxy
	{
		private Action<Int16[]> callback; //Field offset: 0x20
		private IntPtr javaBuf; //Field offset: 0x28
		private int cntFrame; //Field offset: 0x30
		private int cntShort; //Field offset: 0x34

		public DataCallback() { }

		public void OnData() { }

		public void OnStop() { }

		public void SetCallback(Action<Int16[]> callback, IntPtr javaBuf) { }

	}

	private AndroidJavaObject audioIn; //Field offset: 0x10
	private IntPtr javaBuf; //Field offset: 0x18
	private ILogger logger; //Field offset: 0x20
	private int audioInSampleRate; //Field offset: 0x28
	private DataCallback callback; //Field offset: 0x30
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x38

	public override int Channels
	{
		 get { } //Length: 8
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
		 get { } //Length: 8
	}

	public AndroidAudioInAEC(ILogger logger, bool enableAEC = false, bool enableAGC = false, bool enableNS = false) { }

	public override void Dispose() { }

	public override int get_Channels() { }

	[CompilerGenerated]
	public override string get_Error() { }

	public override int get_SamplingRate() { }

	public override void Reset() { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	public override void SetCallback(Action<Int16[]> callback, ObjectFactory<Int16[], Int32> bufferFactory) { }

}

