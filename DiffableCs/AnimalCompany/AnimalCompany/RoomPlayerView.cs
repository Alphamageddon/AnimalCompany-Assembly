namespace AnimalCompany;

public class RoomPlayerView : AvatarHeadContainer
{
	internal enum PlayerType
	{
		Stranger = 0,
		Friend = 1,
		IncomingRequest = 2,
		OutgoingRequest = 3,
		Blocked = 4,
		LocalPlayer = 5,
	}

	[SerializeField]
	private TextMeshProUGUI _nameLabel; //Field offset: 0x28
	[SerializeField]
	private GameObject _requestSentLabel; //Field offset: 0x30
	[SerializeField]
	private SlowHoverButton _muteButton; //Field offset: 0x38
	[SerializeField]
	private SlowHoverButton _unmuteButton; //Field offset: 0x40
	[SerializeField]
	private SlowHoverButton _addFriendButton; //Field offset: 0x48
	[SerializeField]
	private SlowHoverButton _blockButton; //Field offset: 0x50
	[SerializeField]
	private SlowHoverButton _unblockButton; //Field offset: 0x58
	[SerializeField]
	private SlowHoverButton _cancelButton; //Field offset: 0x60
	private string _id; //Field offset: 0x68
	[CompilerGenerated]
	private Action<String> onAddFriend; //Field offset: 0x70
	[CompilerGenerated]
	private Action<String> onBlock; //Field offset: 0x78
	[CompilerGenerated]
	private Action<String> onUnblock; //Field offset: 0x80
	[CompilerGenerated]
	private Action<String> onMute; //Field offset: 0x88
	[CompilerGenerated]
	private Action<String> onUnmute; //Field offset: 0x90
	[CompilerGenerated]
	private Action<String> onCancel; //Field offset: 0x98

	public event Action<String> onAddFriend
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<String> onBlock
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<String> onCancel
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<String> onMute
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<String> onUnblock
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<String> onUnmute
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public string displayName
	{
		 get { } //Length: 36
	}

	public RoomPlayerView() { }

	[CompilerGenerated]
	public void add_onAddFriend(Action<String> value) { }

	[CompilerGenerated]
	public void add_onBlock(Action<String> value) { }

	[CompilerGenerated]
	public void add_onCancel(Action<String> value) { }

	[CompilerGenerated]
	public void add_onMute(Action<String> value) { }

	[CompilerGenerated]
	public void add_onUnblock(Action<String> value) { }

	[CompilerGenerated]
	public void add_onUnmute(Action<String> value) { }

	public string get_displayName() { }

	private void HandleAddFriendPressed() { }

	private void HandleBlockPressed() { }

	private void HandleCancelPressed() { }

	private void HandleMutePressed() { }

	private void HandleUnblockPressed() { }

	private void HandleUnmutePressed() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_onAddFriend(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onBlock(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onCancel(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onMute(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onUnblock(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onUnmute(Action<String> value) { }

	public void Setup(string id, string name, bool mute, PlayerType playerType) { }

	public void SetupAvatarView(UserAvatarState avatarState) { }

	public void UpdateVoice(float voice) { }

}

