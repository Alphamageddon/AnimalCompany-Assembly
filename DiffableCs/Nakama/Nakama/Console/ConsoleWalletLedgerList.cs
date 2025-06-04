namespace Nakama.Console;

internal class ConsoleWalletLedgerList : IConsoleWalletLedgerList
{
	[CompilerGenerated]
	private List<ConsoleWalletLedger> <_items>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "items")]
	public List<ConsoleWalletLedger> _items
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IConsoleWalletLedger> Items
	{
		 get { } //Length: 120
	}

	public ConsoleWalletLedgerList() { }

	[CompilerGenerated]
	public List<ConsoleWalletLedger> get__items() { }

	public override IEnumerable<IConsoleWalletLedger> get_Items() { }

	[CompilerGenerated]
	public void set__items(List<ConsoleWalletLedger> value) { }

	public virtual string ToString() { }

}

