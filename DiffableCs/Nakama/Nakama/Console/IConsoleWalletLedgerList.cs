namespace Nakama.Console;

public interface IConsoleWalletLedgerList
{

	public IEnumerable<IConsoleWalletLedger> Items
	{
		 get { } //Length: 0
	}

	public IEnumerable<IConsoleWalletLedger> get_Items() { }

}

