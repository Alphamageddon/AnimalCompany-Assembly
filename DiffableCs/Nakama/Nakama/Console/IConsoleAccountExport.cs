namespace Nakama.Console;

public interface IConsoleAccountExport
{

	public INakamaapiAccount Account
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiFriend> Friends
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiGroup> Groups
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiLeaderboardRecord> LeaderboardRecords
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiChannelMessage> Messages
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiNotification> Notifications
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiStorageObject> Objects
	{
		 get { } //Length: 0
	}

	public IEnumerable<IConsoleWalletLedger> WalletLedgers
	{
		 get { } //Length: 0
	}

	public INakamaapiAccount get_Account() { }

	public IEnumerable<IApiFriend> get_Friends() { }

	public IEnumerable<IApiGroup> get_Groups() { }

	public IEnumerable<IApiLeaderboardRecord> get_LeaderboardRecords() { }

	public IEnumerable<IApiChannelMessage> get_Messages() { }

	public IEnumerable<IApiNotification> get_Notifications() { }

	public IEnumerable<IApiStorageObject> get_Objects() { }

	public IEnumerable<IConsoleWalletLedger> get_WalletLedgers() { }

}

