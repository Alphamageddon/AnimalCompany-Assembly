namespace AnimalCompany;

public class LogInUserAction : BaseAction
{
	private LoginResult _loginResult; //Field offset: 0x18

	public LogInUserAction(LoginResult loginResult) { }

	public virtual void Execute(AppState state) { }

}

