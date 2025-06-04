namespace Photon.Voice;

internal class PhotonTransportProtocol
{
	private enum EventParam
	{
		VoiceId = 1,
		SamplingRate = 2,
		Channels = 3,
		FrameDurationUs = 4,
		Bitrate = 5,
		Width = 6,
		Height = 7,
		FPS = 8,
		KeyFrameInt = 9,
		UserData = 10,
		EventNumber = 11,
		Codec = 12,
	}

	private enum EventSubcode
	{
		VoiceInfo = 1,
		VoiceRemove = 2,
		Frame = 3,
	}

	private VoiceClient voiceClient; //Field offset: 0x10
	private ILogger logger; //Field offset: 0x18

	public PhotonTransportProtocol(VoiceClient voiceClient, ILogger logger) { }

	internal Object[] buildFrameMessage(byte voiceId, byte evNumber, byte frNumber, ArraySegment<Byte> data, FrameFlags flags) { }

	internal Object[] buildVoiceRemoveMessage(LocalVoice v) { }

	internal Object[] buildVoicesInfo(LocalVoice v) { }

	private VoiceInfo createVoiceInfoFromEventPayload(Dictionary<Byte, Object> h) { }

	internal void onVoiceEvent(object content0, int channelId, int playerId, bool isLocalPlayer) { }

	private void onVoiceInfo(int channelId, int playerId, object payload) { }

	private void onVoiceRemove(int channelId, int playerId, object payload) { }

}

