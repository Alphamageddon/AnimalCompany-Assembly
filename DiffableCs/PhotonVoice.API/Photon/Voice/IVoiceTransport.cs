namespace Photon.Voice;

public interface IVoiceTransport
{

	public string ChannelIdStr(int channelId) { }

	public int GetPayloadFragmentSize(SendFrameParams par) { }

	public bool IsChannelJoined(int channelId) { }

	public string PlayerIdStr(int playerId) { }

	public void SendFrame(ArraySegment<Byte> data, FrameFlags flags, byte evNumber, byte frNumber, byte voiceId, int channelId, SendFrameParams par) { }

	public void SendVoiceInfo(LocalVoice voice, int channelId, bool targetMe, Int32[] targetPlayers) { }

	public void SendVoiceRemove(LocalVoice voice, int channelId, bool targetMe, Int32[] targetPlayers) { }

}

