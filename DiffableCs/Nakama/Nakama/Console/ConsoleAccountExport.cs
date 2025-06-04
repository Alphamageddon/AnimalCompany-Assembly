namespace Nakama.Console;

internal class ConsoleAccountExport : IConsoleAccountExport
{
	[CompilerGenerated]
	private NakamaapiAccount <_account>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiFriend> <_friends>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<ApiGroup> <_groups>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List<ApiLeaderboardRecord> <_leaderboardRecords>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private List<ApiChannelMessage> <_messages>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private List<ApiNotification> <_notifications>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private List<ApiStorageObject> <_objects>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private List<ConsoleWalletLedger> <_walletLedgers>k__BackingField; //Field offset: 0x48

	[DataMember(Name = "account")]
	public NakamaapiAccount _account
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "friends")]
	public List<ApiFriend> _friends
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "groups")]
	public List<ApiGroup> _groups
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "leaderboard_records")]
	public List<ApiLeaderboardRecord> _leaderboardRecords
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "messages")]
	public List<ApiChannelMessage> _messages
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "notifications")]
	public List<ApiNotification> _notifications
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "objects")]
	public List<ApiStorageObject> _objects
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "wallet_ledgers")]
	public List<ConsoleWalletLedger> _walletLedgers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override INakamaapiAccount Account
	{
		 get { } //Length: 8
	}

	public override IEnumerable<IApiFriend> Friends
	{
		 get { } //Length: 120
	}

	public override IEnumerable<IApiGroup> Groups
	{
		 get { } //Length: 120
	}

	public override IEnumerable<IApiLeaderboardRecord> LeaderboardRecords
	{
		 get { } //Length: 120
	}

	public override IEnumerable<IApiChannelMessage> Messages
	{
		 get { } //Length: 120
	}

	public override IEnumerable<IApiNotification> Notifications
	{
		 get { } //Length: 120
	}

	public override IEnumerable<IApiStorageObject> Objects
	{
		 get { } //Length: 120
	}

	public override IEnumerable<IConsoleWalletLedger> WalletLedgers
	{
		 get { } //Length: 120
	}

	public ConsoleAccountExport() { }

	[CompilerGenerated]
	public NakamaapiAccount get__account() { }

	[CompilerGenerated]
	public List<ApiFriend> get__friends() { }

	[CompilerGenerated]
	public List<ApiGroup> get__groups() { }

	[CompilerGenerated]
	public List<ApiLeaderboardRecord> get__leaderboardRecords() { }

	[CompilerGenerated]
	public List<ApiChannelMessage> get__messages() { }

	[CompilerGenerated]
	public List<ApiNotification> get__notifications() { }

	[CompilerGenerated]
	public List<ApiStorageObject> get__objects() { }

	[CompilerGenerated]
	public List<ConsoleWalletLedger> get__walletLedgers() { }

	public override INakamaapiAccount get_Account() { }

	public override IEnumerable<IApiFriend> get_Friends() { }

	public override IEnumerable<IApiGroup> get_Groups() { }

	public override IEnumerable<IApiLeaderboardRecord> get_LeaderboardRecords() { }

	public override IEnumerable<IApiChannelMessage> get_Messages() { }

	public override IEnumerable<IApiNotification> get_Notifications() { }

	public override IEnumerable<IApiStorageObject> get_Objects() { }

	public override IEnumerable<IConsoleWalletLedger> get_WalletLedgers() { }

	[CompilerGenerated]
	public void set__account(NakamaapiAccount value) { }

	[CompilerGenerated]
	public void set__friends(List<ApiFriend> value) { }

	[CompilerGenerated]
	public void set__groups(List<ApiGroup> value) { }

	[CompilerGenerated]
	public void set__leaderboardRecords(List<ApiLeaderboardRecord> value) { }

	[CompilerGenerated]
	public void set__messages(List<ApiChannelMessage> value) { }

	[CompilerGenerated]
	public void set__notifications(List<ApiNotification> value) { }

	[CompilerGenerated]
	public void set__objects(List<ApiStorageObject> value) { }

	[CompilerGenerated]
	public void set__walletLedgers(List<ConsoleWalletLedger> value) { }

	public virtual string ToString() { }

}

