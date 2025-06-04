namespace Photon.Voice;

public class LoadBalancingTransport : LoadBalancingClient, IVoiceTransport, IDisposable
{
	private class LBCLogger : ILogger
	{
		private LoadBalancingTransport lbt; //Field offset: 0x10

		public override LogLevel Level
		{
			 get { } //Length: 80
		}

		public LBCLogger(LoadBalancingTransport lbt) { }

		public override LogLevel get_Level() { }

		public override void Log(LogLevel level, string fmt, Object[] args) { }

	}

	internal const int REMOTE_VOICE_CHANNEL = 0; //Field offset: 0x0
	protected VoiceClient voiceClient; //Field offset: 0x188
	private PhotonTransportProtocol protocol; //Field offset: 0x190
	protected readonly bool cppCompatibilityMode; //Field offset: 0x198
	protected readonly ILogger logger; //Field offset: 0x1A0

	protected override byte FrameCode
	{
		 get { } //Length: 8
	}

	public VoiceClient VoiceClient
	{
		 get { } //Length: 8
	}

	public LoadBalancingTransport(ILogger logger = null, ConnectionProtocol connectionProtocol = 0, bool cppCompatibilityMode = false) { }

	private RaiseEventOptions buildEvOptFromTargets(bool targetMe, Int32[] targetPlayers) { }

	protected override object buildFrameMessage(byte voiceId, byte evNumber, byte frNumber, ArraySegment<Byte> data, FrameFlags flags) { }

	[Obsolete("Use LoadBalancingPeer::OpChangeGroups().")]
	public override bool ChangeAudioGroups(Byte[] groupsToRemove, Byte[] groupsToAdd) { }

	public override string ChannelIdStr(int channelId) { }

	public override void Dispose() { }

	protected override byte get_FrameCode() { }

	public VoiceClient get_VoiceClient() { }

	public override int GetPayloadFragmentSize(SendFrameParams par) { }

	public override bool IsChannelJoined(int channelId) { }

	protected override void onEventActionVoiceClient(EventData ev) { }

	private void onStateChangeVoiceClient(ClientState fromState, ClientState state) { }

	public override string PlayerIdStr(int playerId) { }

	public override void SendFrame(ArraySegment<Byte> data, FrameFlags flags, byte evNumber, byte frNumber, byte voiceId, int channelId, SendFrameParams par) { }

	public override void SendVoiceInfo(LocalVoice voice, int channelId, bool targetMe, Int32[] targetPlayers) { }

	public override void SendVoiceRemove(LocalVoice voice, int channelId, bool targetMe, Int32[] targetPlayers) { }

	public void Service() { }

}

