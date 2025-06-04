namespace Oculus.Platform;

public class VoipAudioSourceHiLevel : MonoBehaviour
{
	internal class FilterReadDelegate : MonoBehaviour
	{
		public VoipAudioSourceHiLevel parent; //Field offset: 0x20
		private Single[] scratchBuffer; //Field offset: 0x28

		public FilterReadDelegate() { }

		private void Awake() { }

		private void OnAudioFilterRead(Single[] data, int channels) { }

	}

	private static int audioSystemPlaybackFrequency; //Field offset: 0x0
	private static bool verboseLogging; //Field offset: 0x4
	private int initialPlaybackDelayMS; //Field offset: 0x20
	public AudioSource audioSource; //Field offset: 0x28
	public float peakAmplitude; //Field offset: 0x30
	protected IVoipPCMSource pcmSource; //Field offset: 0x38

	public ulong senderID
	{
		 set { } //Length: 172
	}

	public VoipAudioSourceHiLevel() { }

	protected void Awake() { }

	protected override void CreatePCMSource() { }

	protected static int MSToElements(int ms) { }

	private VoipSampleRate SampleRateToEnum(int rate) { }

	public void set_senderID(ulong value) { }

	private void Start() { }

	protected void Stop() { }

	private void Update() { }

}

