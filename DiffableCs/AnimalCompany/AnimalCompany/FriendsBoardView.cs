namespace AnimalCompany;

public class FriendsBoardView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Transform, FriendView> <>9__42_0; //Field offset: 0x8
		public static Func<FriendView, Boolean> <>9__42_1; //Field offset: 0x10
		public static Func<FriendView, String> <>9__42_2; //Field offset: 0x18
		public static Func<FriendView, Boolean> <>9__42_3; //Field offset: 0x20
		public static Func<FriendView, Boolean> <>9__42_4; //Field offset: 0x28
		public static Func<FriendView, String> <>9__42_5; //Field offset: 0x30
		public static Func<FriendView, Boolean> <>9__42_6; //Field offset: 0x38
		public static Func<FriendView, String> <>9__42_7; //Field offset: 0x40
		public static Func<Transform, FriendView> <>9__44_0; //Field offset: 0x48
		public static Func<FriendView, Boolean> <>9__44_1; //Field offset: 0x50
		public static Func<FriendView, String> <>9__44_2; //Field offset: 0x58
		public static Func<Transform, RoomPlayerView> <>9__45_0; //Field offset: 0x60
		public static Func<RoomPlayerView, String> <>9__45_1; //Field offset: 0x68
		public static Func<Transform, NotificationView> <>9__46_0; //Field offset: 0x70
		public static Func<NotificationView, Boolean> <>9__46_1; //Field offset: 0x78
		public static Func<NotificationView, DateTime> <>9__46_2; //Field offset: 0x80

		private static <>c() { }

		public <>c() { }

		internal FriendView <SortBlocked>b__44_0(Transform t) { }

		internal bool <SortBlocked>b__44_1(FriendView f) { }

		internal string <SortBlocked>b__44_2(FriendView f) { }

		internal FriendView <SortFriends>b__42_0(Transform t) { }

		internal bool <SortFriends>b__42_1(FriendView f) { }

		internal string <SortFriends>b__42_2(FriendView f) { }

		internal bool <SortFriends>b__42_3(FriendView f) { }

		internal bool <SortFriends>b__42_4(FriendView f) { }

		internal string <SortFriends>b__42_5(FriendView f) { }

		internal bool <SortFriends>b__42_6(FriendView f) { }

		internal string <SortFriends>b__42_7(FriendView f) { }

		internal NotificationView <SortNotifications>b__46_0(Transform t) { }

		internal bool <SortNotifications>b__46_1(NotificationView v) { }

		internal DateTime <SortNotifications>b__46_2(NotificationView rp) { }

		internal RoomPlayerView <SortRoomPlayers>b__45_0(Transform t) { }

		internal string <SortRoomPlayers>b__45_1(RoomPlayerView rp) { }

	}

	internal enum Tab
	{
		Room = 0,
		Friends = 1,
		Blocked = 2,
		Notifications = 3,
	}

	[SerializeField]
	private RectTransform _viewport; //Field offset: 0x20
	[SerializeField]
	private Transform _roomParent; //Field offset: 0x28
	[SerializeField]
	private Transform _friendsParent; //Field offset: 0x30
	[SerializeField]
	private Transform _blockedParent; //Field offset: 0x38
	[SerializeField]
	private Transform _notificationsParent; //Field offset: 0x40
	[SerializeField]
	private RoomPlayerView _roomPrefab; //Field offset: 0x48
	[SerializeField]
	private FriendView _friendPrefab; //Field offset: 0x50
	[SerializeField]
	private FriendView _blockedPrefab; //Field offset: 0x58
	[SerializeField]
	private NotificationView _notificationsPrefab; //Field offset: 0x60
	[SerializeField]
	private TabButtonView _roomTab; //Field offset: 0x68
	[SerializeField]
	private TabButtonView _friendsTab; //Field offset: 0x70
	[SerializeField]
	private TabButtonView _blockedTab; //Field offset: 0x78
	[SerializeField]
	private TabButtonView _notificationsTab; //Field offset: 0x80
	[SerializeField]
	private GameObject _incomingHeader; //Field offset: 0x88
	[SerializeField]
	private GameObject _friendsHeader; //Field offset: 0x90
	[SerializeField]
	private GameObject _outgoingHeader; //Field offset: 0x98
	[SerializeField]
	private GameObject _notificationsHeader; //Field offset: 0xA0
	[SerializeField]
	private UIScrollWheel _scrollWheel; //Field offset: 0xA8
	[SerializeField]
	private SlowHoverButton _clearNotificationsButton; //Field offset: 0xB0
	private Tab _currentTab; //Field offset: 0xB8
	public float scrollSensitivity; //Field offset: 0xBC
	private RectTransform _scrollContent; //Field offset: 0xC0
	private AvatarHeadContainer[] _headContainers; //Field offset: 0xC8
	private float _viewportMin; //Field offset: 0xD0
	private float _viewportMax; //Field offset: 0xD4

	public SlowHoverButton clearNotificationsButton
	{
		 get { } //Length: 8
	}

	public RectTransform scrollContent
	{
		 get { } //Length: 8
	}

	public FriendsBoardView() { }

	public FriendView CreateBlockedView() { }

	public FriendView CreateFriendView() { }

	public NotificationView CreateNotificationView() { }

	public RoomPlayerView CreateRoomPlayerView() { }

	public SlowHoverButton get_clearNotificationsButton() { }

	public RectTransform get_scrollContent() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private bool OnTryScroll(float dist) { }

	private void ScrollToTop() { }

	private void SetSelectedTab(Transform tabContent, TabButtonView tabButton, bool selected) { }

	public void ShowTab(Tab tab) { }

	public void SortBlocked() { }

	private void SortCategory(IEnumerable<FriendView> views, GameObject header) { }

	public void SortFriends() { }

	public void SortNotifications() { }

	public void SortRoomPlayers() { }

	private void Update() { }

	private void UpdateHeadContainers() { }

}

