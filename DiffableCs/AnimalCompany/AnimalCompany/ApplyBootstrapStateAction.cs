namespace AnimalCompany;

public class ApplyBootstrapStateAction : BaseAction
{
	private ClientBootstrapResponse _bootstrapResponse; //Field offset: 0x18

	public ApplyBootstrapStateAction(ClientBootstrapResponse bootstrapResponse) { }

	public virtual void Execute(AppState state) { }

}

