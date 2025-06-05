namespace AnimalCompany;

public sealed class UserState : StateObject
{
	[CompilerGenerated]
	private StatePrimitive<String> <userID>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<String> <username>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private StatePrimitive<String> <displayName>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private StatePrimitive<String> <profilePictureURL>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private UserWalletState <wallet>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private StatePrimitive<Boolean> <isDeveloper>k__BackingField; //Field offset: 0x70

	public private StatePrimitive<String> displayName
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
	public StatePrimitive<String> get_displayName() { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_isDeveloper() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_profilePictureURL() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_userID() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_username() { }

	[CompilerGenerated]
	public UserWalletState get_wallet() { }

	[CompilerGenerated]
	private void set_displayName(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_isDeveloper(StatePrimitive<Boolean> value) { }

	[CompilerGenerated]
	private void set_profilePictureURL(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_userID(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_username(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_wallet(UserWalletState value) { }

}

