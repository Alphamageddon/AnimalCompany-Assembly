namespace AnimalCompany;

public class FriendsBoardMediator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__11_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, FriendState>, Boolean> <>9__16_0; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, FriendState>, String> <>9__16_1; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, FriendState>, FriendState> <>9__16_2; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, FriendState>, Boolean> <>9__16_4; //Field offset: 0x28
		public static Func<KeyValuePair`2<String, FriendState>, String> <>9__16_5; //Field offset: 0x30
		public static Func<KeyValuePair`2<String, FriendState>, FriendState> <>9__16_6; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <HandleFriendsChanged>b__16_0(KeyValuePair<String, FriendState> kvp) { }

		internal string <HandleFriendsChanged>b__16_1(KeyValuePair<String, FriendState> kvp) { }

		internal FriendState <HandleFriendsChanged>b__16_2(KeyValuePair<String, FriendState> kvp) { }

		internal bool <HandleFriendsChanged>b__16_4(KeyValuePair<String, FriendState> kvp) { }

		internal string <HandleFriendsChanged>b__16_5(KeyValuePair<String, FriendState> kvp) { }

		internal FriendState <HandleFriendsChanged>b__16_6(KeyValuePair<String, FriendState> kvp) { }

		internal bool <HandleRoomUsersChanged>b__11_0(string k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Dictionary<String, FriendState> friends; //Field offset: 0x10
		public Dictionary<String, FriendState> blockedUsers; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal bool <HandleFriendsChanged>b__3(string k) { }

		internal bool <HandleFriendsChanged>b__7(string k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public StateDictionary<String, NotificationState> notifications; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <HandleNotificationsChanged>b__0(string k) { }

	}

	[SerializeField]
	private TerminalKeyInputListener _keyInputListener; //Field offset: 0x20
	[SerializeField]
	private FriendsBoardView _view; //Field offset: 0x28
	private Dictionary<String, RoomPlayerView> _roomPlayersViews; //Field offset: 0x30
	private Dictionary<String, FriendView> _friendViews; //Field offset: 0x38
	private Dictionary<String, FriendView> _blockedViews; //Field offset: 0x40
	private Dictionary<String, NotificationView> _notificationViews; //Field offset: 0x48

	public FriendsBoardMediator() { }

	private void AddTestViews() { }

	private void ClearNotifications() { }

	private UserAvatarState GetAvatar(string userID) { }

	private void HandleAcceptFriendRequest(string userID) { }

	private void HandleAddFriend(string userID) { }

	private void HandleAvatarCacheChanged(StateChangedEventArgs args) { }

	private void HandleBlock(string userID) { }

	private void HandleCancelFriendRequest(string userID) { }

	private void HandleDeclineFriendRequest(string userID) { }

	private void HandleDeleteFriend(string userID) { }

	private void HandleDeleteNotification(string notificationID) { }

	private void HandleFriendsChanged(StateChangedEventArgs args) { }

	private void HandleJoinFriend(string userID) { }

	private void HandleKeyInput(KeyCode keyCode, TerminalKeyType keyType) { }

	private void HandleLocalAvatarChanged(StateChangedEventArgs args) { }

	private void HandleMute(string userID) { }

	private void HandleNotificationsChanged(StateChangedEventArgs args) { }

	private void HandlePlayerVoiceChanged(StateChangedEventArgs args) { }

	private void HandleRoomChanged(StateChangedEventArgs args) { }

	private void HandleRoomUsersChanged(StateChangedEventArgs args) { }

	private void HandleUnmute(string userID) { }

	private bool IsValidRoomCode(string roomCode) { }

	private void OnDestroy() { }

	private void Start() { }

}

