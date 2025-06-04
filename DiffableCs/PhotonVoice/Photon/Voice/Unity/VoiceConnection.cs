namespace Photon.Voice.Unity;

[DisallowMultipleComponent]
public class VoiceConnection : ConnectionHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public VoiceConnection <>4__this; //Field offset: 0x10
		public GameObject go; //Field offset: 0x18

		public <>c__DisplayClass70_0() { }

		internal void <InstantiateSpeakerPrefab>b__0(Speaker s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public VoiceConnection <>4__this; //Field offset: 0x10
		public RemoteVoiceLink remoteVoice; //Field offset: 0x18

		public <>c__DisplayClass71_0() { }

		internal void <OnRemoteVoiceInfo>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public VoiceConnection <>4__this; //Field offset: 0x10
		public Speaker speaker; //Field offset: 0x18

		public <>c__DisplayClass74_0() { }

		internal void <LinkSpeaker>b__0() { }

	}

	public const int ChannelAudio = 1; //Field offset: 0x0
	public const int ChannelVideo = 2; //Field offset: 0x0
	private const string PlayerPrefsKey = "VoiceCloudBestRegion"; //Field offset: 0x0
	private VoiceComponentImpl voiceComponentImpl; //Field offset: 0x40
	private LoadBalancingTransport client; //Field offset: 0x48
	private SupportLogger supportLoggerComponent; //Field offset: 0x50
	[SerializeField]
	private bool runInBackground; //Field offset: 0x58
	[SerializeField]
	private int statsResetInterval; //Field offset: 0x5C
	private int nextStatsTickCount; //Field offset: 0x60
	private float statsReferenceTime; //Field offset: 0x64
	private int referenceFramesLost; //Field offset: 0x68
	private int referenceFramesReceived; //Field offset: 0x6C
	[SerializeField]
	private GameObject speakerPrefab; //Field offset: 0x70
	private List<RemoteVoiceLink> cachedRemoteVoices; //Field offset: 0x78
	[FormerlySerializedAs("PrimaryRecorder")]
	[SerializeField]
	private Recorder primaryRecorder; //Field offset: 0x80
	[SerializeField]
	[Tooltip("Use primary recorder directly by Voice Client")]
	private bool usePrimaryRecorder; //Field offset: 0x88
	[SerializeField]
	[Tooltip("Use the protocol compatible with Photon Voice C++ API")]
	private bool cppCompatibilityMode; //Field offset: 0x89
	private List<Speaker> linkedSpeakers; //Field offset: 0x90
	private List<Recorder> recorders; //Field offset: 0x98
	public AppSettings Settings; //Field offset: 0xA0
	[CompilerGenerated]
	private Action<Speaker> SpeakerLinked; //Field offset: 0xA8
	[CompilerGenerated]
	private Action<RemoteVoiceLink> RemoteVoiceAdded; //Field offset: 0xB0
	[CompilerGenerated]
	private float <FramesReceivedPerSecond>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private float <FramesLostPerSecond>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private float <FramesLostPercent>k__BackingField; //Field offset: 0xC0

	public event Action<RemoteVoiceLink> RemoteVoiceAdded
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<Speaker> SpeakerLinked
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override bool AlwaysUsePrimaryRecorder
	{
		 get { } //Length: 8
	}

	public string BestRegionSummaryInPreferences
	{
		 get { } //Length: 72
		 set { } //Length: 116
	}

	public LoadBalancingTransport Client
	{
		 get { } //Length: 8
	}

	public ClientState ClientState
	{
		 get { } //Length: 28
	}

	public private float FramesLostPercent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private float FramesLostPerSecond
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private float FramesReceivedPerSecond
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public ILogger Logger
	{
		 get { } //Length: 28
	}

	public Recorder PrimaryRecorder
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GameObject SpeakerPrefab
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool UsePrimaryRecorder
	{
		 get { } //Length: 8
	}

	public VoiceClient VoiceClient
	{
		 get { } //Length: 28
	}

	public VoiceLogger VoiceLogger
	{
		 get { } //Length: 28
	}

	public VoiceConnection() { }

	[CompilerGenerated]
	public void add_RemoteVoiceAdded(Action<RemoteVoiceLink> value) { }

	[CompilerGenerated]
	public void add_SpeakerLinked(Action<Speaker> value) { }

	public bool AddRecorder(Recorder rec) { }

	public bool AddSpeaker(Speaker speaker, object userData) { }

	protected virtual void Awake() { }

	protected void CalcStatistics() { }

	public override bool ConnectUsingSettings(AppSettings overwriteSettings = null) { }

	protected override void FixedUpdate() { }

	public override bool get_AlwaysUsePrimaryRecorder() { }

	public string get_BestRegionSummaryInPreferences() { }

	public LoadBalancingTransport get_Client() { }

	public ClientState get_ClientState() { }

	[CompilerGenerated]
	public float get_FramesLostPercent() { }

	[CompilerGenerated]
	public float get_FramesLostPerSecond() { }

	[CompilerGenerated]
	public float get_FramesReceivedPerSecond() { }

	public ILogger get_Logger() { }

	public Recorder get_PrimaryRecorder() { }

	public GameObject get_SpeakerPrefab() { }

	public bool get_UsePrimaryRecorder() { }

	public VoiceClient get_VoiceClient() { }

	public VoiceLogger get_VoiceLogger() { }

	private void Init() { }

	protected override Speaker InstantiateSpeakerForRemoteVoice(int playerId, byte voiceId, object userData) { }

	public Speaker InstantiateSpeakerPrefab(GameObject parent, bool destroyOnRemove) { }

	private void LateUpdate() { }

	private void LinkSpeaker(Speaker speaker, RemoteVoiceLink remoteVoice) { }

	protected override void OnDestroy() { }

	protected override void OnOperationResponseReceived(OperationResponse operationResponse) { }

	private void OnRemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options) { }

	protected override void OnVoiceStateChanged(ClientState fromState, ClientState toState) { }

	[CompilerGenerated]
	public void remove_RemoteVoiceAdded(Action<RemoteVoiceLink> value) { }

	[CompilerGenerated]
	public void remove_SpeakerLinked(Action<Speaker> value) { }

	public void RemoveRecorder(Recorder rec) { }

	public void set_BestRegionSummaryInPreferences(string value) { }

	[CompilerGenerated]
	private void set_FramesLostPercent(float value) { }

	[CompilerGenerated]
	private void set_FramesLostPerSecond(float value) { }

	[CompilerGenerated]
	private void set_FramesReceivedPerSecond(float value) { }

	public void set_PrimaryRecorder(Recorder value) { }

	public void set_SpeakerPrefab(GameObject value) { }

	protected override void Update() { }

}

