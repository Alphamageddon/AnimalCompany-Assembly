namespace Photon.Voice;

public class VoiceClient : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0
	{
		public VoiceClient <>4__this; //Field offset: 0x10
		public VoiceInfo voiceInfo; //Field offset: 0x18
		public int channelId; //Field offset: 0x48
		public VoiceCreateOptions options; //Field offset: 0x50

		public <>c__DisplayClass85_0() { }

		internal LocalVoice <CreateLocalVoice>b__0(byte vId, int chId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public VoiceClient <>4__this; //Field offset: 0x0
		public VoiceInfo voiceInfo; //Field offset: 0x0
		public IAudioDesc audioSourceDesc; //Field offset: 0x0
		public int channelId; //Field offset: 0x0
		public VoiceCreateOptions options; //Field offset: 0x0

		public <>c__DisplayClass86_0`1() { }

		internal LocalVoice <CreateLocalVoiceAudio>b__0(byte vId, int chId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_0
	{
		public LocalVoiceAudio<Int16> localVoice; //Field offset: 0x10

		public <>c__DisplayClass87_0() { }

		internal void <CreateLocalVoiceAudioFromSource>b__0(Single[] buf) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_1
	{
		public LocalVoiceAudio<Single> localVoice; //Field offset: 0x10

		public <>c__DisplayClass87_1() { }

		internal void <CreateLocalVoiceAudioFromSource>b__1(Single[] buf) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_2
	{
		public LocalVoiceAudio<Single> localVoice; //Field offset: 0x10

		public <>c__DisplayClass87_2() { }

		internal void <CreateLocalVoiceAudioFromSource>b__2(Int16[] buf) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_3
	{
		public LocalVoiceAudio<Int16> localVoice; //Field offset: 0x10

		public <>c__DisplayClass87_3() { }

		internal void <CreateLocalVoiceAudioFromSource>b__3(Int16[] buf) { }

	}

	[CompilerGenerated]
	private sealed class <get_RemoteVoiceInfos>d__76 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private RemoteVoiceInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public VoiceClient <>4__this; //Field offset: 0x28
		private Enumerator<Int32, Dictionary<Byte, RemoteVoice>> <>7__wrap1; //Field offset: 0x30
		private KeyValuePair<Int32, Dictionary`2<Byte, RemoteVoice>> <playerVoices>5__3; //Field offset: 0x58
		private Enumerator<Byte, RemoteVoice> <>7__wrap3; //Field offset: 0x68

		private override RemoteVoiceInfo System.Collections.Generic.IEnumerator<Photon.Voice.RemoteVoiceInfo>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <get_RemoteVoiceInfos>d__76(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<RemoteVoiceInfo> System.Collections.Generic.IEnumerable<Photon.Voice.RemoteVoiceInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override RemoteVoiceInfo System.Collections.Generic.IEnumerator<Photon.Voice.RemoteVoiceInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct CreateOptions
	{
		public static CreateOptions Default; //Field offset: 0x0
		public byte VoiceIDMin; //Field offset: 0x0
		public byte VoiceIDMax; //Field offset: 0x1

		private static CreateOptions() { }

	}

	internal sealed class RemoteVoiceInfoDelegate : MulticastDelegate
	{

		public RemoteVoiceInfoDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref RemoteVoiceOptions options, IAsyncResult result) { }

		public override void Invoke(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options) { }

	}

	internal IVoiceTransport transport; //Field offset: 0x10
	internal ILogger logger; //Field offset: 0x18
	[CompilerGenerated]
	private bool <ThreadingEnabled>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <EventsLost>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <FramesLost>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <FramesFragPart>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <FramesRecovered>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <FramesLate>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <FramesReceived>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <FramesReceivedFEC>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private int <FramesTryFEC>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <FramesReceivedFragments>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private int <FramesReceivedFragmented>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <RoundTripTime>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private int <RoundTripTimeVariance>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <SuppressInfoDuplicateWarning>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private RemoteVoiceInfoDelegate <OnRemoteVoiceInfoAction>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <DebugLostPercent>k__BackingField; //Field offset: 0x60
	private int prevRtt; //Field offset: 0x64
	private Dictionary<Codec, Int32> remoteVoiceDelayFramesPerCodec; //Field offset: 0x68
	private byte voiceIDMin; //Field offset: 0x70
	private byte voiceIDMax; //Field offset: 0x71
	private byte voiceIdLast; //Field offset: 0x72
	private Dictionary<Byte, LocalVoice> localVoices; //Field offset: 0x78
	private Dictionary<Int32, List`1<LocalVoice>> localVoicesPerChannel; //Field offset: 0x80
	private Dictionary<Int32, Dictionary`2<Byte, RemoteVoice>> remoteVoices; //Field offset: 0x88
	private Random rnd; //Field offset: 0x90

	public int DebugLostPercent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public internal int EventsLost
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int FramesFragPart
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int FramesLate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int FramesLost
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public private int FramesReceived
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public internal int FramesReceivedFEC
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int FramesReceivedFragmented
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int FramesReceivedFragments
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int FramesRecovered
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public int FramesSent
	{
		 get { } //Length: 352
	}

	public int FramesSentBytes
	{
		 get { } //Length: 352
	}

	public internal int FramesTryFEC
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public IEnumerable<LocalVoice> LocalVoices
	{
		 get { } //Length: 208
	}

	public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
	{
		[IteratorStateMachine(typeof(<get_RemoteVoiceInfos>d__76))]
		 get { } //Length: 112
	}

	public private int RoundTripTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int RoundTripTimeVariance
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool SuppressInfoDuplicateWarning
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool ThreadingEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public VoiceClient(IVoiceTransport transport, ILogger logger, CreateOptions opt = null) { }

	private void addVoice(byte newId, int channelId, LocalVoice v) { }

	internal string channelStr(int channelId) { }

	private void clearRemoteVoices() { }

	private void clearRemoteVoicesInChannel(int channelId) { }

	private void clearRemoteVoicesInChannelForPlayer(int channelId, int playerId) { }

	private LocalVoice createLocalVoice(int channelId, Func<Byte, Int32, LocalVoice> voiceFactory) { }

	public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId, VoiceCreateOptions options = null) { }

	public LocalVoiceAudio<T> CreateLocalVoiceAudio(VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId, VoiceCreateOptions options = null) { }

	public LocalVoice CreateLocalVoiceAudioFromSource(VoiceInfo voiceInfo, IAudioDesc source, AudioSampleType sampleType, int channelId, VoiceCreateOptions options = null) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public int get_DebugLostPercent() { }

	[CompilerGenerated]
	public int get_EventsLost() { }

	[CompilerGenerated]
	public int get_FramesFragPart() { }

	[CompilerGenerated]
	public int get_FramesLate() { }

	[CompilerGenerated]
	public int get_FramesLost() { }

	[CompilerGenerated]
	public int get_FramesReceived() { }

	[CompilerGenerated]
	public int get_FramesReceivedFEC() { }

	[CompilerGenerated]
	public int get_FramesReceivedFragmented() { }

	[CompilerGenerated]
	public int get_FramesReceivedFragments() { }

	[CompilerGenerated]
	public int get_FramesRecovered() { }

	public int get_FramesSent() { }

	public int get_FramesSentBytes() { }

	[CompilerGenerated]
	public int get_FramesTryFEC() { }

	public IEnumerable<LocalVoice> get_LocalVoices() { }

	[CompilerGenerated]
	public RemoteVoiceInfoDelegate get_OnRemoteVoiceInfoAction() { }

	[IteratorStateMachine(typeof(<get_RemoteVoiceInfos>d__76))]
	public IEnumerable<RemoteVoiceInfo> get_RemoteVoiceInfos() { }

	[CompilerGenerated]
	public int get_RoundTripTime() { }

	[CompilerGenerated]
	public int get_RoundTripTimeVariance() { }

	[CompilerGenerated]
	public bool get_SuppressInfoDuplicateWarning() { }

	[CompilerGenerated]
	public bool get_ThreadingEnabled() { }

	private byte getNewVoiceId() { }

	private byte idInc(byte id) { }

	public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId) { }

	public void LogSpacingProfiles() { }

	public void LogStats() { }

	public void onFrame(int playerId, byte voiceId, byte evNumber, ref FrameBuffer receivedBytes, bool isLocalPlayer) { }

	public void onJoinAllChannels() { }

	public void onJoinChannel(int channelId) { }

	public void onLeaveAllChannels() { }

	public void onLeaveChannel(int channel) { }

	public void onPlayerJoin(int channelId, int playerId) { }

	public void onPlayerJoin(int playerId) { }

	public void onPlayerLeave(int channelId, int playerId) { }

	public void onPlayerLeave(int playerId) { }

	public void onVoiceInfo(int channelId, int playerId, byte voiceId, byte eventNumber, VoiceInfo info) { }

	public void onVoiceRemove(int playerId, Byte[] voiceIds) { }

	internal string playerStr(int playerId) { }

	public void RemoveLocalVoice(LocalVoice voice) { }

	public void Service() { }

	[CompilerGenerated]
	public void set_DebugLostPercent(int value) { }

	[CompilerGenerated]
	internal void set_EventsLost(int value) { }

	[CompilerGenerated]
	internal void set_FramesFragPart(int value) { }

	[CompilerGenerated]
	internal void set_FramesLate(int value) { }

	[CompilerGenerated]
	internal void set_FramesLost(int value) { }

	[CompilerGenerated]
	private void set_FramesReceived(int value) { }

	[CompilerGenerated]
	internal void set_FramesReceivedFEC(int value) { }

	[CompilerGenerated]
	internal void set_FramesReceivedFragmented(int value) { }

	[CompilerGenerated]
	internal void set_FramesReceivedFragments(int value) { }

	[CompilerGenerated]
	internal void set_FramesRecovered(int value) { }

	[CompilerGenerated]
	internal void set_FramesTryFEC(int value) { }

	[CompilerGenerated]
	public void set_OnRemoteVoiceInfoAction(RemoteVoiceInfoDelegate value) { }

	[CompilerGenerated]
	private void set_RoundTripTime(int value) { }

	[CompilerGenerated]
	private void set_RoundTripTimeVariance(int value) { }

	[CompilerGenerated]
	public void set_SuppressInfoDuplicateWarning(bool value) { }

	[CompilerGenerated]
	public void set_ThreadingEnabled(bool value) { }

	public void SetRemoteVoiceDelayFrames(Codec codec, int delayFrames) { }

}

