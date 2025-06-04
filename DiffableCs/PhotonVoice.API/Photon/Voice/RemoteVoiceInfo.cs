namespace Photon.Voice;

public class RemoteVoiceInfo
{
	[CompilerGenerated]
	private VoiceInfo <Info>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <ChannelId>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <PlayerId>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private byte <VoiceId>k__BackingField; //Field offset: 0x48

	public private int ChannelId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private VoiceInfo Info
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private int PlayerId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private byte VoiceId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info) { }

	[CompilerGenerated]
	public int get_ChannelId() { }

	[CompilerGenerated]
	public VoiceInfo get_Info() { }

	[CompilerGenerated]
	public int get_PlayerId() { }

	[CompilerGenerated]
	public byte get_VoiceId() { }

	[CompilerGenerated]
	private void set_ChannelId(int value) { }

	[CompilerGenerated]
	private void set_Info(VoiceInfo value) { }

	[CompilerGenerated]
	private void set_PlayerId(int value) { }

	[CompilerGenerated]
	private void set_VoiceId(byte value) { }

}

