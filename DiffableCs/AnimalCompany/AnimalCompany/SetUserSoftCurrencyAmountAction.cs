namespace AnimalCompany;

public class SetUserSoftCurrencyAmountAction : BaseAction
{
	private int _amount; //Field offset: 0x14

	public SetUserSoftCurrencyAmountAction(int amount) { }

	public virtual void Execute(AppState state) { }

}

