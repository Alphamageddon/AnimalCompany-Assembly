namespace AnimalCompany;

public class SetNetSessionPropertiesAction : BaseAction
{
	private SessionProperties _properties; //Field offset: 0x18

	public SetNetSessionPropertiesAction(SessionProperties props) { }

	public virtual void Execute(AppState state) { }

}

