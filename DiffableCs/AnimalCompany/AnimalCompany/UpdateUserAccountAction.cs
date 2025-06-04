namespace AnimalCompany;

public class UpdateUserAccountAction : BaseAction
{
	private IApiAccount _account; //Field offset: 0x18

	public UpdateUserAccountAction(IApiAccount account) { }

	public virtual void Execute(AppState state) { }

}

