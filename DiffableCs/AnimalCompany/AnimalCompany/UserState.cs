namespace AnimalCompany;

public sealed class UserState : StateObject
{
	[CompilerGenerated]
	private StatePrimitive<String> <platformUserID>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<String> <userID>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private StatePrimitive<String> <username>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private StatePrimitive<String> <displayName>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private StatePrimitive<String> <profilePictureURL>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private UserAvatarState <avatar>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private UserAvatarState <draftAvatar>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private UserWalletState <wallet>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private UserInventoryState <inventory>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private StatePrimitive<Boolean> <canClaimDailyReward>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private StatePrimitive<Boolean> <isDeveloper>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private FriendsState <friends>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private NotificationsState <notifications>k__BackingField; //Field offset: 0xA8

	public private UserAvatarState avatar
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Boolean> canClaimDailyReward
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> displayName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private UserAvatarState draftAvatar
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private FriendsState friends
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private UserInventoryState inventory
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Boolean> isDeveloper
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private NotificationsState notifications
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> platformUserID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> profilePictureURL
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> userID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> username
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private UserWalletState wallet
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public UserState() { }

	[CompilerGenerated]
	public UserAvatarState get_avatar() { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_canClaimDailyReward() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_displayName() { }

	[CompilerGenerated]
	public UserAvatarState get_draftAvatar() { }

	[CompilerGenerated]
	public FriendsState get_friends() { }

	[CompilerGenerated]
	public UserInventoryState get_inventory() { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_isDeveloper() { }

	[CompilerGenerated]
	public NotificationsState get_notifications() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_platformUserID() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_profilePictureURL() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_userID() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_username() { }

	[CompilerGenerated]
	public UserWalletState get_wallet() { }

	[CompilerGenerated]
	private void set_avatar(UserAvatarState value) { }

	[CompilerGenerated]
	private void set_canClaimDailyReward(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_displayName(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_draftAvatar(UserAvatarState value) { }

	[CompilerGenerated]
	private void set_friends(FriendsState value) { }

	[CompilerGenerated]
	private void set_inventory(UserInventoryState value) { }

	[CompilerGenerated]
	private void set_isDeveloper(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_notifications(NotificationsState value) { }

	[CompilerGenerated]
	private void set_platformUserID(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_profilePictureURL(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_userID(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_username(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_wallet(UserWalletState value) { }

}

