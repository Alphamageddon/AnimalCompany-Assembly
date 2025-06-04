namespace AnimalCompany;

public sealed class AppState : StateRoot
{
	[CompilerGenerated]
	private StatePrimitive<Boolean> <startupCompleted>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private StatePrimitive<AppPlatform> <platform>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private StatePrimitive<String> <clientVersion>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private StatePrimitive<String> <clientVersionSHA>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private StatePrimitive<String> <clientUserAgent>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private StatePrimitive<String> <apiOrigin>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private StatePrimitive<String> <apiToken>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private StatePrimitive<Boolean> <apiSocketConnected>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private StatePrimitive<DateTime> <softCurrencyResetTime>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private DebugState <debug>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private StatePrimitive<Boolean> <isLoggedIn>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private UserState <user>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private ProductsState <products>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private AvatarItemsState <avatarItems>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private StateDictionary<String, UserAvatarState> <userAvatars>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private StateDictionary<String, UserCacheState> <userCache>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private NetSessionState <netSession>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private NetConnectionStatus <connectionStatus>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private NetSessionTargetRoomState <targetRoom>k__BackingField; //Field offset: 0xF0

	public private StatePrimitive<String> apiOrigin
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Boolean> apiSocketConnected
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> apiToken
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private AvatarItemsState avatarItems
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> clientUserAgent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> clientVersion
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> clientVersionSHA
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private NetConnectionStatus connectionStatus
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private DebugState debug
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Boolean> isLoggedIn
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private NetSessionState netSession
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<AppPlatform> platform
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ProductsState products
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<DateTime> softCurrencyResetTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Boolean> startupCompleted
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private NetSessionTargetRoomState targetRoom
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private UserState user
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StateDictionary<String, UserAvatarState> userAvatars
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StateDictionary<String, UserCacheState> userCache
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public AppState(IStateObservationContext context, IStateTypeIDManifest typeIDManifest) { }

	public AppState() { }

	[CompilerGenerated]
	private void <PostInitialize>b__78_0(StateChangedEventArgs args) { }

	[CompilerGenerated]
	public StatePrimitive<String> get_apiOrigin() { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_apiSocketConnected() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_apiToken() { }

	[CompilerGenerated]
	public AvatarItemsState get_avatarItems() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_clientUserAgent() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_clientVersion() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_clientVersionSHA() { }

	[CompilerGenerated]
	public NetConnectionStatus get_connectionStatus() { }

	[CompilerGenerated]
	public DebugState get_debug() { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_isLoggedIn() { }

	[CompilerGenerated]
	public NetSessionState get_netSession() { }

	[CompilerGenerated]
	public StatePrimitive<AppPlatform> get_platform() { }

	[CompilerGenerated]
	public ProductsState get_products() { }

	[CompilerGenerated]
	public StatePrimitive<DateTime> get_softCurrencyResetTime() { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_startupCompleted() { }

	[CompilerGenerated]
	public NetSessionTargetRoomState get_targetRoom() { }

	[CompilerGenerated]
	public UserState get_user() { }

	[CompilerGenerated]
	public StateDictionary<String, UserAvatarState> get_userAvatars() { }

	[CompilerGenerated]
	public StateDictionary<String, UserCacheState> get_userCache() { }

	protected virtual void PostInitialize() { }

	public virtual void Reset(bool recursively = true) { }

	[CompilerGenerated]
	private void set_apiOrigin(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_apiSocketConnected(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_apiToken(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_avatarItems(AvatarItemsState value) { }

	[CompilerGenerated]
	private void set_clientUserAgent(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_clientVersion(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_clientVersionSHA(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_connectionStatus(NetConnectionStatus value) { }

	[CompilerGenerated]
	private void set_debug(DebugState value) { }

	[CompilerGenerated]
	private void set_isLoggedIn(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_netSession(NetSessionState value) { }

	[CompilerGenerated]
	private void set_platform(StatePrimitive<AppPlatform> value) { }

	[CompilerGenerated]
	private void set_products(ProductsState value) { }

	[CompilerGenerated]
	private void set_softCurrencyResetTime(StatePrimitive<DateTime> value) { }

	[CompilerGenerated]
	private void set_startupCompleted(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_targetRoom(NetSessionTargetRoomState value) { }

	[CompilerGenerated]
	private void set_user(UserState value) { }

	[CompilerGenerated]
	private void set_userAvatars(StateDictionary<String, UserAvatarState> value) { }

	[CompilerGenerated]
	private void set_userCache(StateDictionary<String, UserCacheState> value) { }

}

