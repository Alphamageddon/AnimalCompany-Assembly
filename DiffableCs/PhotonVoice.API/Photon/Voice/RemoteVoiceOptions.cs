namespace Photon.Voice;

public struct RemoteVoiceOptions
{
	[CompilerGenerated]
	private Action <OnRemoteVoiceRemoveAction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private IDecoder <Decoder>k__BackingField; //Field offset: 0x8
	private readonly ILogger logger; //Field offset: 0x10
	private readonly VoiceInfo voiceInfo; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <logPrefix>k__BackingField; //Field offset: 0x48

	public IDecoder Decoder
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	internal string logPrefix
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
	}

	public Action OnRemoteVoiceRemoveAction
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RemoteVoiceOptions(ILogger logger, string logPrefix, VoiceInfo voiceInfo) { }

	[CompilerGenerated]
	[IsReadOnly]
	public IDecoder get_Decoder() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal string get_logPrefix() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Action get_OnRemoteVoiceRemoveAction() { }

	[CompilerGenerated]
	public void set_Decoder(IDecoder value) { }

	[CompilerGenerated]
	public void set_OnRemoteVoiceRemoveAction(Action value) { }

	private void setOutput(Action<FrameOut`1<T>> output) { }

	public void SetOutput(Action<FrameOut`1<Single>> output) { }

	public void SetOutput(Action<FrameOut`1<Int16>> output) { }

}

