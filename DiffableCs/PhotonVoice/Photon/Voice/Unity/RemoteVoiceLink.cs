namespace Photon.Voice.Unity;

public class RemoteVoiceLink
{
	public readonly VoiceInfo VoiceInfo; //Field offset: 0x10
	public readonly int PlayerId; //Field offset: 0x40
	public readonly byte VoiceId; //Field offset: 0x44
	public readonly int ChannelId; //Field offset: 0x48
	[CompilerGenerated]
	private Action<FrameOut`1<Single>> FloatFrameDecoded; //Field offset: 0x50
	[CompilerGenerated]
	private Action RemoteVoiceRemoved; //Field offset: 0x58
	private string cached; //Field offset: 0x60

	public event Action<FrameOut`1<Single>> FloatFrameDecoded
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action RemoteVoiceRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public RemoteVoiceLink(VoiceInfo info, int playerId, byte voiceId, int channelId, ref RemoteVoiceOptions options) { }

	[CompilerGenerated]
	public void add_FloatFrameDecoded(Action<FrameOut`1<Single>> value) { }

	[CompilerGenerated]
	public void add_RemoteVoiceRemoved(Action value) { }

	private void OnDecodedFrameFloatAction(FrameOut<Single> floats) { }

	private void OnRemoteVoiceRemoveAction() { }

	[CompilerGenerated]
	public void remove_FloatFrameDecoded(Action<FrameOut`1<Single>> value) { }

	[CompilerGenerated]
	public void remove_RemoteVoiceRemoved(Action value) { }

	public virtual string ToString() { }

}

