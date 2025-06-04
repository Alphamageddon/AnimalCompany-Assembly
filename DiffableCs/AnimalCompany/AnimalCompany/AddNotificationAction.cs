namespace AnimalCompany;

public class AddNotificationAction : BaseAction
{
	private IApiNotification _notification; //Field offset: 0x18

	public AddNotificationAction(IApiNotification notification) { }

	public virtual void Execute(AppState state) { }

}

