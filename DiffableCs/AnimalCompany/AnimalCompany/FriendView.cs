namespace AnimalCompany;

public class FriendView : AvatarHeadContainer
{
	[SerializeField]
	private TMP_Text _nameLabel; //Field offset: 0x28
	[SerializeField]
	private TMP_Text _onlineLabel; //Field offset: 0x30
	[SerializeField]
	private TMP_Text _offlineLabel; //Field offset: 0x38
	[SerializeField]
	private GameObject _inRoomLabel; //Field offset: 0x40
	[SerializeField]
	private SlowHoverButton _joinButton; //Field offset: 0x48
	[SerializeField]
	private SlowHoverButton _acceptButton; //Field offset: 0x50
	[SerializeField]
	private SlowHoverButton _declineButton; //Field offset: 0x58
	[SerializeField]
	private SlowHoverButton _unfriendButton; //Field offset: 0x60
	[SerializeField]
	private SlowHoverButton _unblockButton; //Field offset: 0x68
	[SerializeField]
	private SlowHoverButton _cancelButton; //Field offset: 0x70
	private string _id; //Field offset: 0x78
	private FriendshipState _friendshipState; //Field offset: 0x80
	[CompilerGenerated]
	private Action<String> onJoin; //Field offset: 0x88
	[CompilerGenerated]
	private Action<String> onAccept; //Field offset: 0x90
	[CompilerGenerated]
	private Action<String> onDecline; //Field offset: 0x98
	[CompilerGenerated]
	private Action<String> onDelete; //Field offset: 0xA0
	[CompilerGenerated]
	private Action<String> onCancel; //Field offset: 0xA8

	public event Action<String> onAccept
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

	public event Action<String> onDecline
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<String> onDelete
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<String> onJoin
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

	public FriendshipState friendshipState
	{
		 get { } //Length: 8
	}

	public string id
	{
		 get { } //Length: 8
	}

	public bool isInRoom
	{
		 get { } //Length: 40
	}

	public bool isOffline
	{
		 get { } //Length: 40
	}

	public bool isOnline
	{
		 get { } //Length: 40
	}

	public FriendView() { }

	[CompilerGenerated]
	public void add_onAccept(Action<String> value) { }

	[CompilerGenerated]
	public void add_onCancel(Action<String> value) { }

	[CompilerGenerated]
	public void add_onDecline(Action<String> value) { }

	[CompilerGenerated]
	public void add_onDelete(Action<String> value) { }

	[CompilerGenerated]
	public void add_onJoin(Action<String> value) { }

	public string get_displayName() { }

	public FriendshipState get_friendshipState() { }

	public string get_id() { }

	public bool get_isInRoom() { }

	public bool get_isOffline() { }

	public bool get_isOnline() { }

	private void HandleAcceptPressed() { }

	private void HandleCancelPressed() { }

	private void HandleDeclinePressed() { }

	private void HandleDeletePressed() { }

	private void HandleJoinPressed() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_onAccept(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onCancel(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onDecline(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onDelete(Action<String> value) { }

	[CompilerGenerated]
	public void remove_onJoin(Action<String> value) { }

	public void SetInRoom(bool inRoom) { }

	public void Setup(string id, string name, FriendshipState friendshipState, bool inRoom, bool isOnline) { }

	public void SetupAvatarView(UserAvatarState avatarState) { }

	public void UpdateVoice(float voice) { }

}

