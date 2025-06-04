namespace AnimalCompany;

public class UserWalletState : StateObject
{
	[CompilerGenerated]
	private StatePrimitive<Int32> <softCurrency>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<Int32> <hardCurrency>k__BackingField; //Field offset: 0x50

	public private StatePrimitive<Int32> hardCurrency
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Int32> softCurrency
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public UserWalletState() { }

	[CompilerGenerated]
	public StatePrimitive<Int32> get_hardCurrency() { }

	[CompilerGenerated]
	public StatePrimitive<Int32> get_softCurrency() { }

	[CompilerGenerated]
	private void set_hardCurrency(StatePrimitive<Int32> value) { }

	[CompilerGenerated]
	private void set_softCurrency(StatePrimitive<Int32> value) { }

}

