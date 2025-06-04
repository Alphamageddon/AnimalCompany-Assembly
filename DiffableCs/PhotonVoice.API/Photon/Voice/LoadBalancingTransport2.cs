namespace Photon.Voice;

public class LoadBalancingTransport2 : LoadBalancingTransport
{
	private const int MAX_DATA_OFFSET = 5; //Field offset: 0x0

	protected virtual byte FrameCode
	{
		 get { } //Length: 8
	}

	public LoadBalancingTransport2(ILogger logger = null, ConnectionProtocol connectionProtocol = 0, bool cppCompatibilityMode = false) { }

	protected virtual object buildFrameMessage(byte voiceId, byte evNumber, byte frNumber, ArraySegment<Byte> data, FrameFlags flags) { }

	protected virtual byte get_FrameCode() { }

	public virtual int GetPayloadFragmentSize(SendFrameParams par) { }

	protected virtual void onEventActionVoiceClient(EventData ev) { }

	internal void onVoiceFrameEvent(object content0, int channelId, int playerId, int localPlayerId) { }

}

