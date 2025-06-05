namespace AnimalCompany;

public class LogInUserAction : BaseAction
{
	private ISession _session; //Field offset: 0x18
	private IApiAccount _account; //Field offset: 0x20

	public LogInUserAction(ISession session, IApiAccount account) { }

	public virtual void Execute(AppState state) { }

}

